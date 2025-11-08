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
        public NodoCola Primero = null;
        public NodoCola Ultimo = null;

        public void Encolar(Cita p)
        {
            //1. Crear nuevo Nodo
            NodoCola nodoNuevo = new NodoCola(p);

            //2. encolar
            if (Primero == null)
            {
                Primero = nodoNuevo;
                Ultimo = nodoNuevo;
            }
            else
            {
                // Cola Preferencial
                if (p.EsPreferencial)
                {
                    if (Primero.Dato.EsPreferencial)
                    {
                        // Se compila despues del ultimo preferencial
                        NodoCola aux = Primero;
                        while (aux.Siguiente != null && aux.Siguiente.Dato.EsPreferencial)
                        {
                            aux = aux.Siguiente;
                        }

                        // Auxiliar ya es igual al ultimo preferencial

                        nodoNuevo.Siguiente = aux.Siguiente;
                        aux.Siguiente = nodoNuevo;
                    }
                    else
                    {
                        // El nuevo es preferencial y el frente no, se encola al frente
                        nodoNuevo.Siguiente = Primero;
                        Primero = nodoNuevo;
                    }
                }
                else
                {
                    Ultimo.Siguiente = nodoNuevo;
                    Ultimo = nodoNuevo;
                }
            }
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
    }
}
