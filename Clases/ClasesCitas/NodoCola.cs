using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ClasesCitas
{
    public class NodoCola
    {
        public Cita Dato;
        public NodoCola Siguiente;

        public NodoCola(Cita dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
