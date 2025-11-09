using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgendaClientes_Click(object sender, EventArgs e)
        {
            // 1. Limpiar el contenido anterior del Panel
            pnlContenedor.Controls.Clear();

            // 2. Crear una instancia del nuevo User Control (la "página")
            AgendaClientesUserControl agenda = new AgendaClientesUserControl();

            // 3. Ajustar propiedades
            agenda.Dock = DockStyle.Fill; // Hace que el control ocupe todo el Panel.

            // 4. Agregar el User Control al Panel Contenedor
            pnlContenedor.Controls.Add(agenda);
        }
    }
}
