using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tratamiento
    {
        public string Tipo;
        public string Descripcion;

        public DateTime Fecha;
        public double Costo;

        public Tratamiento(string tipo, string descripcion, DateTime fecha, double costo)
        {
            Tipo = tipo;
            Descripcion = descripcion;
            Fecha = fecha;
            Costo = costo;
        }
        public override string ToString()
        {
            return $"{Tipo}\n {Descripcion}";
        }
    }
}
