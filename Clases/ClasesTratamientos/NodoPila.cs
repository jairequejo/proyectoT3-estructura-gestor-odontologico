using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.clsTratamientos
{
    public class NodoPila
    {
        public Tratamiento Dato;
        public NodoPila Siguiente;

        public NodoPila(Tratamiento dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
