using System;

namespace Clases
{
    public class Paciente
    {
        public int DNI;
        public string Apellido;
        public string Nombre;
        public DateTime FechaNacimiento;
        public int Edad
        {
            get
            {
                // Calcula la diferencia de años
                int edad = DateTime.Today.Year - FechaNacimiento.Year;

                // Resta 1 si aún no ha cumplido años este año.
                if (FechaNacimiento.Date > DateTime.Today.AddYears(-edad))
                {
                    edad--;
                }
                return edad;
            }
        }
        public int Telefono;
        public Pila HistorialTratamientos; // Pila para el historial

        public Paciente(int dNI, string apellido, string nombre, DateTime fechaNacimiento, int telefono)
        {
            DNI = dNI;
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
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
