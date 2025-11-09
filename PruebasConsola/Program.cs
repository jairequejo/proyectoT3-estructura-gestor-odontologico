using System;
using Clases;
using Clases.ClasesCitas;

namespace PruebasConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaDoble listaPacientes = new ListaEnlazadaDoble();
            Cola colaCitas = new Cola();
            Pila pilaTratamientos = new Pila();

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Registrar Paciente");
                Console.WriteLine("2. Mostrar Pacientes");
                Console.WriteLine("3. Buscar Paciente por DNI");
                Console.WriteLine("4. Registrar Cita");
                Console.WriteLine("5. Mostrar Citas de Hoy");
                Console.WriteLine("6. Mostrar Citas por Fecha");
                Console.WriteLine("7. Mostrar Todas las Citas");
                Console.WriteLine("8. Registrar Tratamiento");
                Console.WriteLine("9. Mostrar Historial de un Paciente");
                Console.WriteLine("10. Atender siguiente Cita");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");

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
                        RegistrarCita(colaCitas, listaPacientes);
                        break;

                    case 5:
                        Console.WriteLine("=== Citas de Hoy ===");
                        colaCitas.MostrarCitasDeHoy();
                        break;

                    case 6:
                        Console.Write("Ingrese la fecha (YYYY-MM-DD): ");
                        DateTime fecha = DateTime.Parse(Console.ReadLine());
                        colaCitas.MostrarPorFecha(fecha);
                        break;

                    case 7:
                        Console.WriteLine("=== Todas las Citas ===");
                        colaCitas.MostrarCitasGenerales();
                        break;

                    case 8:
                        RegistrarTratamiento(listaPacientes);
                        break;

                    case 9:
                        MostrarHistorialPaciente(listaPacientes);
                        break;

                    case 10:
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

        static void RegistrarCita(Cola cola, ListaEnlazadaDoble listaPacientes)
        {
            Console.WriteLine("=== Registro de Cita ===");

            int dni;
            string nombre = "";

            while (true)
            {
                Console.Write("DNI del Paciente: ");
                dni = int.Parse(Console.ReadLine());

                var pacienteExistente = listaPacientes.Buscar(dni);

                if (pacienteExistente != null)
                {
                    Console.WriteLine($">> Paciente encontrado: {pacienteExistente.Nombre} {pacienteExistente.Apellido}");
                    Console.Write("¿Desea registrar la cita para este paciente? (s/n): ");
                    string resp = Console.ReadLine().ToLower();

                    if (resp == "s")
                    {
                        nombre = $"{pacienteExistente.Nombre} {pacienteExistente.Apellido}";
                        break; // sale del bucle, ya se confirmó el paciente correcto
                    }
                    else
                    {
                        Console.WriteLine(">< DNI incorrecto, intente nuevamente.\n");
                        continue; // vuelve a pedir el DNI
                    }
                }
                else
                {
                    Console.WriteLine(">< Paciente no registrado.");
                    Console.Write("¿Desea registrarlo temporalmente para esta cita? (s/n): ");
                    string resp = Console.ReadLine().ToLower();

                    if (resp == "s")
                    {
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();
                        break; // sale del bucle con los datos ingresados manualmente
                    }
                    else
                    {
                        Console.WriteLine(">< Reintentando ingreso del DNI...\n");
                    }
                }
            }

            // Resto de datos de la cita
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

            Console.WriteLine($"Atendiendo cita: {cita.DNI} - {cita.Nombre} | Motivo: {cita.Motivo}");
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
