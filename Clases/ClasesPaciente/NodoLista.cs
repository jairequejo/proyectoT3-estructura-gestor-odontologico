using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class NodoLista
    {
        public Paciente Dato;
        public NodoLista Siguiente;
        public NodoLista Anterior;

        public NodoLista(Paciente dato)
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }
    }
}
