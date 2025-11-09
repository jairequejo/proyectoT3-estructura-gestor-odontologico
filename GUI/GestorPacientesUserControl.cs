using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Clases;
using Clases.ClasesCitas;

namespace GUI
{
    public partial class GestorPacientesUserControl : UserControl
    {
        private SistemaClinico sistema;

        public GestorPacientesUserControl(SistemaClinico sistema)
        {
            InitializeComponent();
            this.sistema = sistema ?? throw new ArgumentNullException(nameof(sistema));

            // inicializar eventos
            dgvPacientes.SelectionChanged += DgvPacientes_SelectionChanged;

            // Si quieres que al abrir muestre la lista:
            ActualizarListaPacientes();
            lblNombreDNISeleccionado.Text = "Seleccione un paciente.";
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbDNIRegistroCliente.Text) ||
                    string.IsNullOrWhiteSpace(tbApellido.Text) ||
                    string.IsNullOrWhiteSpace(tbNombre.Text) ||
                    string.IsNullOrWhiteSpace(tbTelefono.Text))
                {
                    MessageBox.Show("Complete todos los campos del paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbDNIRegistroCliente.Text.Trim(), out int dni))
                {
                    MessageBox.Show("DNI inválido (debe ser numérico).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(tbTelefono.Text.Trim(), out int telefono))
                {
                    MessageBox.Show("Teléfono inválido (debe ser numérico).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // verificar duplicado
                var existente = sistema.ListaPacientes.BuscarPorDNI(dni);
                if (existente != null)
                {
                    MessageBox.Show("Ya existe un paciente con ese DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // crear y guardar paciente
                Paciente nuevo = new Paciente(dni, tbApellido.Text.Trim(), tbNombre.Text.Trim(), dtpFNacimiento.Value.Date, telefono);
                sistema.ListaPacientes.InsertarAlFinal(nuevo);

                MessageBox.Show("Paciente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposPaciente();
                ActualizarListaPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposPaciente()
        {
            tbDNIRegistroCliente.Clear();
            tbApellido.Clear();
            tbNombre.Clear();
            tbTelefono.Clear();
            dtpFNacimiento.Value = DateTime.Now;
        }
        private void btnActualizarListaPacientes_Click(object sender, EventArgs e)
        {
            ActualizarListaPacientes();
        }

        private void ActualizarListaPacientes()
        {
            dgvPacientes.Rows.Clear();

            List<Paciente> lista = sistema.ListaPacientes.ObtenerTodos();
            if (lista == null) return;

            foreach (var p in lista)
            {
                dgvPacientes.Rows.Add(p.DNI, p.Apellido, p.Nombre, p.Edad, p.Telefono);
            }

            // limpiar la vista del historial al recargar lista
            dgvHistorial.Rows.Clear();
            lblNombreDNISeleccionado.Text = "Seleccione un paciente.";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBuscarDNI.Text))
            {
                MessageBox.Show("Ingrese DNI para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(tbBuscarDNI.Text.Trim(), out int dni))
            {
                MessageBox.Show("DNI inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var paciente = sistema.ListaPacientes.BuscarPorDNI(dni);
            if (paciente == null)
            {
                MessageBox.Show("Paciente no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // mostrar solo ese paciente en la tabla y su historial
            dgvPacientes.Rows.Clear();
            dgvPacientes.Rows.Add(paciente.DNI, paciente.Apellido, paciente.Nombre, paciente.Edad, paciente.Telefono);

            // seleccionar la primera (y única) fila para disparar el evento de selección
            if (dgvPacientes.Rows.Count > 0)
            {
                dgvPacientes.ClearSelection();
                dgvPacientes.Rows[0].Selected = true;
                MostrarHistorialPaciente(paciente);
                lblNombreDNISeleccionado.Text = $"{paciente.Nombre} {paciente.Apellido} (DNI: {paciente.DNI})";
            }
        }
        private void DgvPacientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count == 0)
                {
                    // si no hay selección, limpiar
                    dgvHistorial.Rows.Clear();
                    lblNombreDNISeleccionado.Text = "Seleccione un paciente.";
                    return;
                }

                // tomamos la primera fila seleccionada
                var fila = dgvPacientes.SelectedRows[0];

                // obtener DNI desde la columna clDNI (asegúrate que la columna se llame así en el Designer)
                object valorDni = fila.Cells["clDNI"].Value;
                if (valorDni == null) return;

                if (!int.TryParse(valorDni.ToString(), out int dni)) return;

                // buscar paciente en la lista enlazada
                var paciente = sistema.ListaPacientes.BuscarPorDNI(dni);
                if (paciente == null)
                {
                    dgvHistorial.Rows.Clear();
                    lblNombreDNISeleccionado.Text = "Paciente no encontrado.";
                    return;
                }

                // actualizar label y grid de historial con SOLO el historial de ese paciente
                lblNombreDNISeleccionado.Text = $"{paciente.Nombre} {paciente.Apellido} (DNI: {paciente.DNI})";
                MostrarHistorialPaciente(paciente);
            }
            catch
            {
                
            }
        }

        private void btnRegistrarTratamiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbDNIPacienteTratamiento.Text) ||
                    string.IsNullOrWhiteSpace(tbTipoTratamiento.Text) ||
                    string.IsNullOrWhiteSpace(tbDescripcionTratamiento.Text))
                {
                    MessageBox.Show("Complete todos los campos del tratamiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbDNIPacienteTratamiento.Text.Trim(), out int dni))
                {
                    MessageBox.Show("DNI inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var paciente = sistema.ListaPacientes.BuscarPorDNI(dni);
                if (paciente == null)
                {
                    MessageBox.Show("No existe paciente con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tipo = tbTipoTratamiento.Text.Trim();
                string descripcion = tbDescripcionTratamiento.Text.Trim();
                DateTime fecha = dtpFechaTratamiento.Value;
                double costo = Convert.ToDouble(nudCostoTratamiento.Value);

                Tratamiento t = new Tratamiento(tipo, descripcion, fecha, costo);
                paciente.HistorialTratamientos.Apilar(t);

                MessageBox.Show("Tratamiento registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // si el historial mostrado es de ese paciente, actualizar la vista
                if (lblNombreDNISeleccionado.Text.Contains($"(DNI: {paciente.DNI})"))
                {
                    MostrarHistorialPaciente(paciente);
                }

                // limpiar campos de tratamiento
                tbDNIPacienteTratamiento.Clear();
                tbTipoTratamiento.Clear();
                tbDescripcionTratamiento.Clear();
                nudCostoTratamiento.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar tratamiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = lblNombreDNISeleccionado.Text;
                if (string.IsNullOrWhiteSpace(texto) || !texto.Contains("DNI:")) return;

                int start = texto.IndexOf("DNI:") + 4;
                int end = texto.IndexOf(")", start);
                if (start < 0 || end < 0) return;

                string dniStr = texto.Substring(start, end - start).Trim();
                if (!int.TryParse(dniStr, out int dni)) return;

                var paciente = sistema.ListaPacientes.BuscarPorDNI(dni);
                if (paciente != null)
                    MostrarHistorialPaciente(paciente);
            }
            catch
            {

            }
        }

        private void MostrarHistorialPaciente(Paciente paciente)
        {
            dgvHistorial.Rows.Clear();

            if (paciente == null) return;

            // obtener todos los tratamientos de la pila (método ObtenerTodos())
            List<Tratamiento> tratamientos = paciente.HistorialTratamientos.ObtenerTodos();
            if (tratamientos == null) return;

            // Los agregamos al DataGridView en orden de cima fondo (según ObtenerTodos)
            foreach (var t in tratamientos)
            {
                dgvHistorial.Rows.Add(t.Tipo, t.Descripcion, t.Costo, t.Fecha.ToShortDateString());
            }
        }
    }
}
