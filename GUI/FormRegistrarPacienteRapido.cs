using Clases; // Importante
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormRegistrarPacienteRapido : Form
    {
        // Propiedad pública para que el otro formulario pueda recoger al paciente
        public Paciente PacienteCreado { get; private set; }

        private int dni;

        public FormRegistrarPacienteRapido(int dni, string nombreCita)
        {
            InitializeComponent();
            this.dni = dni;

            // Pre-llenamos los datos que ya tenemos de la cita
            tbDNI.Text = dni.ToString();
            tbNombre.Text = nombreCita;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos
                if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
                    string.IsNullOrWhiteSpace(tbApellido.Text) ||
                    string.IsNullOrWhiteSpace(tbTelefono.Text))
                {
                    MessageBox.Show("Debe completar Nombre, Apellido y Teléfono.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbTelefono.Text.Trim(), out int telefono))
                {
                    MessageBox.Show("El teléfono debe ser numérico.", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Creamos el paciente
                this.PacienteCreado = new Paciente(
                    this.dni,
                    tbApellido.Text.Trim(),
                    tbNombre.Text.Trim(),
                    dtpFechaNacimiento.Value,
                    telefono
                );

                // Cerramos el formulario con resultado "OK"
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}