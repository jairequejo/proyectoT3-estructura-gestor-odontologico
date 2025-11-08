using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    // Lista Enlazada Doble
    public class ListaEnlazadaDoble
    {
        public NodoLista nodoPrimero;
        public NodoLista nodoUltimo;

        public void Insertar(Paciente dato)
        {
            NodoLista nodoNuevo = new NodoLista(dato);
            if (nodoPrimero == null)
            {
                nodoPrimero = nodoNuevo;
                nodoUltimo = nodoNuevo;
            }
            else
            {
                nodoUltimo.Siguiente = nodoNuevo;
                nodoNuevo.Anterior = nodoUltimo;
                nodoUltimo = nodoNuevo;
            }
        }

        public void Mostrar_Adelante()
        {
            NodoLista nodoTemporal = nodoPrimero;
            while (nodoTemporal != null)
            {
                Console.WriteLine(nodoTemporal.Dato);
                nodoTemporal = nodoTemporal.Siguiente;
                Console.WriteLine();
            }
        }
        //public void Mostrar_Atras()
        //{
        //    NodoLista nodoTemporal = nodoUltimo;
        //    while (nodoTemporal != null)
        //    {
        //        Console.WriteLine(nodoTemporal.Dato);
        //        nodoTemporal = nodoTemporal.Anterior;
        //        Console.WriteLine();
        //    }
        //}
        //public void Eliminar(Paciente dato)
        //{
        //    if (nodoPrimero == null)
        //    {
        //        Console.WriteLine("La lista está vacía.");
        //        return;
        //    }
        //    else if (Convert.ToString(nodoPrimero.Dato) == Convert.ToString(dato))
        //    {
        //        nodoPrimero = nodoPrimero.Siguiente;
        //        nodoPrimero.Anterior = null;
        //    }
        //    else if (Convert.ToString(nodoUltimo.Dato) == Convert.ToString(dato))
        //    {
        //        nodoUltimo = nodoUltimo.Anterior;
        //        nodoUltimo.Siguiente = null;
        //    }
        //    else
        //    {
        //        NodoLista nodoTemporal = nodoPrimero;
        //        while (nodoTemporal != null)
        //        {
        //            if (Convert.ToString(nodoTemporal.Dato) == Convert.ToString(dato))
        //            {
        //                nodoTemporal.Anterior.Siguiente = nodoTemporal.Siguiente;
        //                nodoTemporal.Siguiente.Anterior = nodoTemporal.Anterior;
        //                break;
        //            }
        //            nodoTemporal = nodoTemporal.Siguiente;
        //        }
        //    }
        //}
        public Paciente Buscar(int dni)
        {
            NodoLista nodoTemporal = nodoPrimero;

            while (nodoTemporal != null)
            {
                if (nodoTemporal.Dato.DNI == dni)
                {
                    return nodoTemporal.Dato; // Devuelve el paciente encontrado
                }
                nodoTemporal = nodoTemporal.Siguiente;
            }

            return null; // Si no se encuentra, devuelve null
        }
    }
}
