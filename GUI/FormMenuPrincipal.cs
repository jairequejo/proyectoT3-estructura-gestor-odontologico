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
        private SistemaClinico sistema; // ← instancia compartida

        public FormMenuPrincipal()
        {
            InitializeComponent();
            sistema = new SistemaClinico(); // inicializa una sola vez
            CargarUserControl(new AgendaClientesUserControl(sistema)); // pasa el sistema
        }

        private void CargarUserControl(UserControl control)
        {
            pnlContenedor.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(control);
        }

        private void linkCitas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CargarUserControl(new AgendaClientesUserControl(sistema));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CargarUserControl(new GestorPacientesUserControl(sistema));
        }
    }
}
