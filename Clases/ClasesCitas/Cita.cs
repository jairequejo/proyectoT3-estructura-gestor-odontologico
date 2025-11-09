using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cita
    {
        public int DNI;
        public string Nombre;
        public string Motivo;
        public DateTime Fecha;
        public bool EsPreferencial;

        public Cita(int dNI, string nombre, string motivo, DateTime fecha, bool esPreferencial)
        {
            DNI = dNI;
            Nombre = nombre;
            Motivo = motivo;
            Fecha = fecha;
            EsPreferencial = esPreferencial;
        }
        public Cita(int dNI, bool esPreferencial)
        {
            DNI = dNI;
            EsPreferencial = esPreferencial;
        }

        public override string ToString()
        {
            return $">>> Fecha: {Fecha.Date} Cliente: {DNI} - {Nombre}\n    | Motivo: {Motivo} - Preferencial: {EsPreferencial}";
        }
    }
}
