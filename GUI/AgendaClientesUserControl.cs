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

    public partial class AgendaClientesUserControl : UserControl
    {
        private SistemaClinico sistema;

        public AgendaClientesUserControl(SistemaClinico sistema)
        {
            InitializeComponent();
            this.sistema = sistema;
            //ActualizarColaCitas();
        }
    }
}
