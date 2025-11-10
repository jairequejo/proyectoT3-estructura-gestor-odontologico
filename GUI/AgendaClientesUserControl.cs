using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Clases;

namespace GUI
{
    public partial class AgendaClientesUserControl : UserControl
    {
        private SistemaClinico sistema;
        private Paciente pacienteEnAtencion = null;

        // Propiedad de solo lectura para el DNI en el panel de Agendar
        private int DniCita
        {
            get
            {
                if (int.TryParse(tbDNICita.Text.Trim(), out int dni))
                {
                    return dni;
                }
                return 0;
            }
        }

        public AgendaClientesUserControl(SistemaClinico sistema)
        {
            InitializeComponent();
            this.sistema = sistema ?? throw new ArgumentNullException(nameof(sistema), "El objeto SistemaClinico no puede ser nulo.");

            tbDNICita.Leave += TbDNICita_Leave;

            // Estado Inicial
            ActualizarCola(sistema.ColaCitas.ObtenerTodos());
            ActualizarLabelSiguiente();
            LimpiarPanelAtencion();
        }

        //  LÓGICA DE AGENDAR CITA
        private void TbDNICita_Leave(object sender, EventArgs e)
        {
            int dni = DniCita;
            if (dni > 0)
            {
                var paciente = sistema.ListaPacientes.BuscarPorDNI(dni);
                if (paciente != null)
                {
                    tbNombreTemporal.Text = $"{paciente.Nombre} {paciente.Apellido}";
                    tbNombreTemporal.Enabled = false;
                }
                else
                {
                    tbNombreTemporal.Clear();
                    tbNombreTemporal.Enabled = true;
                }
            }
            else
            {
                tbNombreTemporal.Clear();
                tbNombreTemporal.Enabled = true;
            }
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            try
            {
                // MEJORA DE VALIDACIÓN: Usamos DniCita y nos aseguramos de que el texto no solo no sea nulo, 
                // sino que contenga caracteres significativos después del Trim.
                if (DniCita <= 0)
                {
                    MessageBox.Show("El DNI debe ser un número válido y positivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDNICita.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbNombreTemporal.Text))
                {
                    MessageBox.Show("Complete el Nombre/Apellido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNombreTemporal.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbMotivoCita.Text))
                {
                    MessageBox.Show("Complete el Motivo de la cita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbMotivoCita.Focus();
                    return;
                }


                Cita nuevaCita = new Cita(DniCita, // Ya validado
                                          tbNombreTemporal.Text.Trim(),
                                          tbMotivoCita.Text.Trim(),
                                          dtpFechaCita.Value.Date,
                                          chbPreferencial.Checked);

                sistema.ColaCitas.Encolar(nuevaCita);

                MessageBox.Show($"Cita agendada correctamente para: {nuevaCita.Nombre}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCamposAgendar();
                ActualizarCola(sistema.ColaCitas.ObtenerTodos());
                ActualizarLabelSiguiente();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agendar cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposAgendar()
        {
            tbDNICita.Clear();
            tbNombreTemporal.Clear();
            tbNombreTemporal.Enabled = true;
            tbMotivoCita.Clear();
            dtpFechaCita.Value = DateTime.Now;
            chbPreferencial.Checked = false;
        }


        // LÓGICA DE LA COLA (FILTROS Y VISTA)
        private void btnActualizarCola_Click(object sender, EventArgs e)
        {
            ActualizarCola(sistema.ColaCitas.ObtenerTodos());
        }

        private void btnFiltrarHoy_Click(object sender, EventArgs e)
        {
            ActualizarCola(sistema.ColaCitas.ObtenerCitasPorFecha(DateTime.Today));
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ActualizarCola(sistema.ColaCitas.ObtenerTodos());
        }

        private void btnFiltrarPorFecha_Click(object sender, EventArgs e)
        {
            ActualizarCola(sistema.ColaCitas.ObtenerCitasPorFecha(dtpFiltrarPorFecha.Value.Date));
        }


        /// Método Central para actualizar el DataGridView de la Cola.
        private void ActualizarCola(List<Cita> listaCitas)
        {
            dgvCola.Rows.Clear();
            if (listaCitas == null) return;

            foreach (var cita in listaCitas)
            {
                dgvCola.Rows.Add(
                    cita.Fecha.ToShortDateString(),
                    cita.DNI.ToString("D"),
                    cita.Nombre,
                    cita.Motivo,
                    cita.EsPreferencial
                );
            }
        }

        private void ActualizarLabelSiguiente()
        {
            try
            {
                if (sistema.ColaCitas.EstaVacia() || sistema.ColaCitas.Primero == null)
                {
                    lblSiguienteUsuarioCola.Text = "No hay nadie en la cola.";
                }
                else
                {
                    Cita siguiente = sistema.ColaCitas.Primero.Dato;
                    lblSiguienteUsuarioCola.Text = $"{siguiente.Nombre} (DNI: {siguiente.DNI}) - {(siguiente.EsPreferencial ? "⭐ Preferencial" : "Estandar")}";
                }
            }
            catch (Exception ex)
            {
                lblSiguienteUsuarioCola.Text = "Error al obtener el siguiente de la cola.";
                Console.WriteLine($"Error en ActualizarLabelSiguiente: {ex.Message}");
            }
        }

        private void btnActualizarHistorial_Click(object sender, EventArgs e)
        {
            // Refresca el historial del PACIENTE EN ATENCIÓN, no del seleccionado.
            if (this.pacienteEnAtencion != null)
            {
                lblUsuarioAtendido.Text = $"Historial de: **{pacienteEnAtencion.Nombre} {pacienteEnAtencion.Apellido}**";
                MostrarHistorialPaciente(this.pacienteEnAtencion);
            }
            else
            {
                lblUsuarioAtendido.Text = "No hay paciente en atención.";
                dgvHistorial.Rows.Clear();
            }
        }

        private void MostrarHistorialPaciente(Paciente paciente)
        {
            dgvHistorial.Rows.Clear();
            if (paciente?.HistorialTratamientos == null) return;

            List<Tratamiento> lista = paciente.HistorialTratamientos.ObtenerTodos();
            if (lista == null) return;

            // Mostrar los más recientes primero (LIFO visualmente)
            lista.Reverse();

            foreach (var t in lista)
            {
                dgvHistorial.Rows.Add(
                    t.Fecha.ToShortDateString(),
                    t.Tipo,
                    t.Descripcion,
                    t.Costo.ToString("C2")
                );
            }
        }

        // ATENDER PACIENTE (PANEL DERECHO)

        private void btnAtenderCliente_Click(object sender, EventArgs e)
        {
            if (sistema.ColaCitas.EstaVacia())
            {
                MessageBox.Show("No hay pacientes en la cola para atender.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cita citaAtendida = sistema.ColaCitas.Desencolar();
            Paciente paciente = sistema.ListaPacientes.BuscarPorDNI(citaAtendida.DNI);

            if (paciente == null)
            {
                MessageBox.Show($"El paciente {citaAtendida.Nombre} (DNI: {citaAtendida.DNI}) no está registrado. Por favor, complete la ficha para iniciar la atención.", "Paciente Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (FormRegistrarPacienteRapido formRegistro = new FormRegistrarPacienteRapido(citaAtendida.DNI, citaAtendida.Nombre))
                {
                    DialogResult result = formRegistro.ShowDialog();

                    if (result == DialogResult.OK && formRegistro.PacienteCreado != null)
                    {
                        paciente = formRegistro.PacienteCreado;
                        sistema.ListaPacientes.InsertarAlFinal(paciente);
                        MessageBox.Show("Paciente nuevo registrado con éxito.", "Éxito");
                    }
                    else
                    {
                        MessageBox.Show("Registro cancelado o fallido. La cita será descartada y el paciente no será atendido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ActualizarCola(sistema.ColaCitas.ObtenerTodos());
                        ActualizarLabelSiguiente();
                        return;
                    }
                }
            }

            this.pacienteEnAtencion = paciente;

            lblPacienteEnAtencion.Text = $"{paciente.Nombre} {paciente.Apellido} (DNI: {paciente.DNI})";
            btnRegistrarTratamiento.Enabled = true;
            btnCompletarAtencion.Enabled = true;


            MostrarHistorialPaciente(paciente);
            lblUsuarioAtendido.Text = $"Historial de: {paciente.Nombre} {paciente.Apellido}";

            ActualizarCola(sistema.ColaCitas.ObtenerTodos());
            ActualizarLabelSiguiente();
        }

        private void btnRegistrarTratamiento_Click(object sender, EventArgs e)
        {
            if (this.pacienteEnAtencion == null)
            {
                MessageBox.Show("Debe 'Atender Cliente' primero para registrar un tratamiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbTipoTratamiento.Text) ||
                string.IsNullOrWhiteSpace(rtbDescripcionTratamiento.Text))
            {
                MessageBox.Show("Debe ingresar el **Tipo** y la **Descripción** del tratamiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Tratamiento nuevo = new Tratamiento(
                    tbTipoTratamiento.Text.Trim(),
                    rtbDescripcionTratamiento.Text.Trim(),
                    dtpFechaTratamiento.Value.Date,
                    Convert.ToDouble(nudCosto.Value)
                );

                pacienteEnAtencion.HistorialTratamientos.Apilar(nuevo);

                MessageBox.Show("Tratamiento registrado en el historial.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos campos de tratamiento para el siguiente
                tbTipoTratamiento.Clear();
                rtbDescripcionTratamiento.Clear();
                nudCosto.Value = 0;
                dtpFechaTratamiento.Value = DateTime.Now;

                // Refrescamos el historial para ver el nuevo tratamiento
                MostrarHistorialPaciente(pacienteEnAtencion);
            }
            catch (FormatException)
            {
                MessageBox.Show("El costo ingresado no es un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar tratamiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompletarAtencion_Click(object sender, EventArgs e)
        {
            if (this.pacienteEnAtencion == null)
            {
                MessageBox.Show("No hay un paciente actualmente en atención.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Atención a **{pacienteEnAtencion.Nombre} {pacienteEnAtencion.Apellido}** completada. Historial guardado.", "Atención Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarPanelAtencion();
        }

        private void LimpiarPanelAtencion()
        {
            this.pacienteEnAtencion = null;
            lblPacienteEnAtencion.Text = "---";
            btnRegistrarTratamiento.Enabled = false;
            btnCompletarAtencion.Enabled = false;

            tbTipoTratamiento.Clear();
            rtbDescripcionTratamiento.Clear();
            nudCosto.Value = 0;
            dtpFechaTratamiento.Value = DateTime.Now;

            // Limpiamos el historial al terminar la atención
            dgvHistorial.Rows.Clear();
            lblUsuarioAtendido.Text = "Estado del Historial: En espera de atención.";
        }
    }
}