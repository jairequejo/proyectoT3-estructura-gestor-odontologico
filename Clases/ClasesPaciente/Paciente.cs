using System;

namespace Clases
{
    public class Paciente
    {
        public int DNI;
        public string Apellido;
        public string Nombre;
        public int Edad;
        public int Telefono;
        public Pila HistorialTratamientos; // Pila para el historial

        public Paciente(int dNI, string apellido, string nombre, int edad, int telefono)
        {
            DNI = dNI;
            Apellido = apellido;
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            HistorialTratamientos = new Pila(); // Inicializa la pila
        }

        public override string ToString()
        {
            return $"{DNI}\n  Nombre: {Apellido} {Nombre}\n  Edad: {Edad}\n  Teléfono: {Telefono}";
        }

        // Método para mostrar el historial del paciente
        public void MostrarHistorial()
        {
            Console.WriteLine($"\n--- Historial de Tratamientos de {Nombre} {Apellido} ---");
            HistorialTratamientos.MostrarPilaConsola();
        }
    }
}
