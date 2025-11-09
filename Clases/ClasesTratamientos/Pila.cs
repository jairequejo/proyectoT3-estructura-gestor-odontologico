using Clases.clsTratamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pila
    {
        public NodoPila Cima;
        public int Count { get; private set; }

        public Pila()
        {
            Cima = null;
            Count = 0;
        }

        public void Apilar(Tratamiento dato)
        {
            NodoPila nuevoElemento = new NodoPila(dato);
            nuevoElemento.Siguiente = Cima;
            Cima = nuevoElemento;
            Count++;
        }

        //public Tratamiento Desapilar()
        //{
        //    if (Cima == null)
        //    {
        //        throw new InvalidOperationException("La pila está vacía.");
        //    }
        //    Tratamiento dato = Cima.Dato;
        //    Cima = Cima.Siguiente;
        //    Count--;
        //    return dato;
        //}

        //public Tratamiento VerCima()
        //{
        //    if (Cima == null)
        //    {
        //        throw new InvalidOperationException("La pila está vacía.");
        //    }
        //    return Cima.Dato;
        //}

        public bool EstaVacia()
        {
            return Cima == null;
        }

        public void MostrarPilaConsola()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }

            Console.WriteLine("=== Contenido de la Pila (de arriba hacia abajo) ===");
            NodoPila actual = Cima;
            int indice = 1;

            while (actual != null)
            {
                Console.WriteLine($"[{indice}] {actual.Dato}");
                actual = actual.Siguiente;
                indice++;
            }
        }

        // Devuelve todos los tratamientos como lista para el GUI
        public List<Tratamiento> ObtenerTodos()
        {
            List<Tratamiento> tratamientos = new List<Tratamiento>();
            NodoPila actual = Cima;

            while (actual != null)
            {
                tratamientos.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            return tratamientos;
        }
    }
}

    
