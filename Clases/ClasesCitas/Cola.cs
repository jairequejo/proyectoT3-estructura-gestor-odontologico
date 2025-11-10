using Clases.ClasesCitas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cola
    {
        /// Cola con prioridad jerárquica:
        /// 1. Prioridad automática por fecha (más próxima primero)
        /// 2. Prioridad manual por preferencialidad del paciente
        /// 3. En caso de empate, se respeta el orden de llegada (FIFO)

        public NodoCola Primero = null;
        public NodoCola Ultimo = null;

        public void Encolar(Cita p)
        {
            NodoCola nuevo = new NodoCola(p);

            // Caso base: cola vacía
            if (Primero == null)
            {
                Primero = Ultimo = nuevo;
                return;
            }

            // Si la cita es más próxima que la primera
            if (p.Fecha.Date < Primero.Dato.Fecha.Date ||
               (p.Fecha.Date == Primero.Dato.Fecha.Date && p.EsPreferencial && !Primero.Dato.EsPreferencial))
            {
                nuevo.Siguiente = Primero;
                Primero = nuevo;
                return;
            }

            // Buscar la posición adecuada
            NodoCola actual = Primero;
            while (actual.Siguiente != null)
            {
                Cita siguiente = actual.Siguiente.Dato;

                // Si la nueva cita es antes que la siguiente
                if (p.Fecha.Date < siguiente.Fecha.Date)
                    break;

                // Si es el mismo día pero preferencial y el siguiente no lo es
                if (p.Fecha.Date == siguiente.Fecha.Date && p.EsPreferencial && !siguiente.EsPreferencial)
                    break;

                actual = actual.Siguiente;
            }

            // Insertar en la posición encontrada
            nuevo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevo;

            if (nuevo.Siguiente == null)
                Ultimo = nuevo;
        }


        public Cita Desencolar()
        {
            if (Primero != null)
            {
                Cita p = Primero.Dato;

                Primero = Primero.Siguiente;

                return p;
            }
            return null;
        }

        public bool EstaVacia()
        {
            if (Primero == null)
            {
                return true;
            }
            return false;
        }

        public void MostrarColaConsola()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            Console.WriteLine("=== Citas en Cola ===");
            NodoCola actual = Primero;
            int indice = 1;

            while (actual != null)
            {
                Console.WriteLine($"[{indice}] {actual.Dato}");
                actual = actual.Siguiente;
                indice++;
            }
        }
        public void MostrarCitasDeHoy()
        {
            Console.WriteLine("=== Citas de Hoy ===");
            DateTime hoy = DateTime.Today;
            MostrarPorFecha(hoy);
        }

        public void MostrarPorFecha(DateTime fecha)
        {
            bool encontrado = false;
            NodoCola aux = Primero;

            while (aux != null)
            {
                if (aux.Dato.Fecha.Date == fecha.Date)
                {
                    Console.WriteLine(aux.Dato);
                    encontrado = true;
                }
                aux = aux.Siguiente;
            }

            if (!encontrado)
                Console.WriteLine("No hay citas en esa fecha.");
        }

        public void MostrarCitasGenerales()
        {
            Console.WriteLine("=== Todas las Citas ===");
            NodoCola aux = Primero;
            while (aux != null)
            {
                Console.WriteLine(aux.Dato);
                aux = aux.Siguiente;
            }
        }

        public List<Cita> ObtenerTodos()
        {
            List<Cita> citas = new List<Cita>();
            NodoCola actual = Primero;
            while (actual != null)
            {
                citas.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return citas;
        }

        public List<Cita> ObtenerCitasPorFecha(DateTime fecha)
        {
            List<Cita> citasFiltradas = new List<Cita>();
            NodoCola actual = Primero;

            while (actual != null)
            {
                if (actual.Dato.Fecha.Date == fecha.Date)
                {
                    citasFiltradas.Add(actual.Dato);
                }
                // Como la cola está ordenada por fecha, si ya pasamos la fecha, podemos parar
                else if (actual.Dato.Fecha.Date > fecha.Date)
                {
                    break;
                }
                actual = actual.Siguiente;
            }
            return citasFiltradas;
        }
    }
}
