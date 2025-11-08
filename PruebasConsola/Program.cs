using System;
using Clases;

namespace PruebasConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaDoble listaPacientes = new ListaEnlazadaDoble();
            Cola colaCitas = new Cola();

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Registrar Paciente");
                Console.WriteLine("2. Mostrar Pacientes");
                Console.WriteLine("3. Buscar Paciente por DNI");
                Console.WriteLine("4. Registrar Cita");
                Console.WriteLine("5. Mostrar Citas");
                Console.WriteLine("6. Registrar Tratamiento");
                Console.WriteLine("7. Mostrar Historial de un Paciente");
                Console.WriteLine("8. Atender siguiente Cita");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        RegistrarPaciente(listaPacientes);
                        break;

                    case 2:
                        Console.WriteLine("=== Lista de Pacientes ===");
                        listaPacientes.Mostrar_Adelante();
                        break;

                    case 3:
                        BuscarPaciente(listaPacientes);
                        break;

                    case 4:
                        RegistrarCita(colaCitas);
                        break;

                    case 5:
                        Console.WriteLine("=== Citas Registradas ===");
                        colaCitas.MostrarColaConsola();
                        break;

                    case 6:
                        RegistrarTratamiento(listaPacientes);
                        break;

                    case 7:
                        MostrarHistorialPaciente(listaPacientes);
                        break;

                    case 8:
                        AtenderCita(listaPacientes, colaCitas);
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        // ===== FUNCIONES AUXILIARES =====

        static void RegistrarPaciente(ListaEnlazadaDoble lista)
        {
            Console.WriteLine("=== Registro de Paciente ===");
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());

            if (lista.Buscar(dni) != null)
            {
                Console.WriteLine(" >< El paciente ya está registrado.");
                return;
            }

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Teléfono: ");
            int telefono = int.Parse(Console.ReadLine());

            Paciente nuevo = new Paciente(dni, apellido, nombre, edad, telefono);
            lista.Insertar(nuevo);
            Console.WriteLine(" >>> Paciente registrado correctamente.");
        }

        static void BuscarPaciente(ListaEnlazadaDoble lista)
        {
            Console.Write("Ingrese el DNI del paciente a buscar: ");
            int dni = int.Parse(Console.ReadLine());

            var paciente = lista.Buscar(dni);
            if (paciente != null)
            {
                Console.WriteLine(">> Paciente encontrado:");
                Console.WriteLine(paciente);
            }
            else
            {
                Console.WriteLine(">< Paciente no encontrado.");
            }
        }

        static void RegistrarCita(Cola cola)
        {
            Console.WriteLine("=== Registro de Cita ===");
            Console.Write("DNI del Paciente: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Motivo: ");
            string motivo = Console.ReadLine();
            Console.Write("Fecha (YYYY-MM-DD): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.Write("¿Es preferencial? (s/n): ");
            bool preferencial = Console.ReadLine().ToLower() == "s";

            Cita nuevaCita = new Cita(dni, nombre, motivo, fecha, preferencial);
            cola.Encolar(nuevaCita);
            Console.WriteLine(">>> Cita registrada correctamente.");
        }

        static void RegistrarTratamiento(ListaEnlazadaDoble listaPacientes)
        {
            Console.WriteLine("=== Registro de Tratamiento ===");
            Console.Write("DNI del Paciente: ");
            int dni = int.Parse(Console.ReadLine());

            var paciente = listaPacientes.Buscar(dni);
            if (paciente == null)
            {
                Console.WriteLine(">< Paciente no encontrado. Regístrelo primero.");
                return;
            }

            Console.Write("Tipo: ");
            string tipo = Console.ReadLine();
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();
            Console.Write("Fecha (YYYY-MM-DD): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.Write("Costo: ");
            double costo = double.Parse(Console.ReadLine());

            Tratamiento nuevo = new Tratamiento(tipo, descripcion, fecha, costo);
            paciente.HistorialTratamientos.Apilar(nuevo);

            Console.WriteLine(">>> Tratamiento agregado al historial del paciente.");
        }

        static void MostrarHistorialPaciente(ListaEnlazadaDoble listaPacientes)
        {
            Console.Write("Ingrese el DNI del paciente: ");
            int dni = int.Parse(Console.ReadLine());

            var paciente = listaPacientes.Buscar(dni);
            if (paciente == null)
            {
                Console.WriteLine(" >>> Paciente no encontrado.");
                return;
            }

            paciente.MostrarHistorial();
        }

        static void AtenderCita(ListaEnlazadaDoble listaPacientes, Cola colaCitas)
        {
            Console.WriteLine("=== Atención de Citas ===");

            var cita = colaCitas.Desencolar();
            if (cita == null)
            {
                Console.WriteLine(" >>> No hay citas en la cola.");
                return;
            }

            Console.WriteLine($"Atendiendo cita: {cita.DNI} - {cita.Nombre} | Motivo: {cita.Motivo}" );
            var paciente = listaPacientes.Buscar(cita.DNI);

            if (paciente == null)
            {
                Console.WriteLine(" >> Paciente no registrado. Ingrese los datos:");
                Console.Write("Apellido: ");
                string apellido = Console.ReadLine();
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("Teléfono: ");
                int telefono = int.Parse(Console.ReadLine());

                paciente = new Paciente(cita.DNI, apellido, nombre, edad, telefono);
                listaPacientes.Insertar(paciente);
                Console.WriteLine(">> Paciente agregado a la lista.");
            }

            Console.WriteLine(">>> Cita atendida correctamente.");
        }
    }
}
