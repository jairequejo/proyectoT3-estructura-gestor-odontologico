using System;
using Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class SistemaClinico
    {
        public ListaEnlazadaDoble ListaPacientes { get; set; } = new ListaEnlazadaDoble();
        public Cola ColaCitas { get; set; } = new Cola();
        public Pila PilaTratamientos { get; set; } = new Pila();
    }
}
