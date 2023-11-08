namespace UD2T2SanJuanThompsonJosephLuca

///////////////////////////////////////////

// Tarea: UD2T2

// Alumno: Joseph Luca San Juan Thompson

// Curso: 2023/2024

///////////////////////////////////////////
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string nombre = "";
            string apellido1 = "";
            string apellido2 = "";
            int edad = 0;
            string NIF = "";
            double salario = 0;
            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado = new Empleado(nombre, apellido1, apellido2, edad, NIF, salario);
            Boolean salir = false;
            string nif;

            while (!salir)
            {
                Console.WriteLine("\n0. Salir");
                Console.WriteLine("1. Crea un empleado");
                Console.WriteLine("2. Actualiza el salario de un empleado");
                Console.WriteLine("3. Muestra el nombre de un empleado");
                Console.WriteLine("4. Muestra la edad de un empleado");
                Console.WriteLine("5. Muestra un empleado");
                Console.WriteLine("6. Muestra todos los empleados");
                Console.WriteLine("7. Borra un empleado");
                int opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 0:
                        salir = true;
                        break;
                
                    case 1:
                        // Crear un empleado
                        empleado.NuevoEmpleado();
                        break;

                    case 2:
                        // Actualiza el salario
                        Console.WriteLine("Introduce el nif del empleado");
                        nif = Console.ReadLine();
                        Console.WriteLine("Escribe el nuevo salario");
                        double newSal = Double.Parse(Console.ReadLine());
                        empleado.ActualizarSalarioEmpleado(nif, newSal);
                        break;

                    case 3:
                        // Mostrar el nombre
                        Console.WriteLine("Introduce el nif del empleado");
                        nif = Console.ReadLine();
                        empleado.MostrarNombreEmpleado(nif);
                        break;

                    case 4:
                        // Mostrar la edad
                        Console.WriteLine("Introduce el nif del empleado");
                        nif = Console.ReadLine();
                        empleado.MostrarEdadEmpleado(nif);
                        break;

                    case 5:
                        // Mostrar un empleado
                        Console.WriteLine("Introduce el nif del empleado");
                        nif = Console.ReadLine();
                        empleado.MostrarUnEmpleado(nif);
                        break;

                    case 6:
                        // Mostrar todos los empleados
                        empleado.MostrarEmpleados();
                        break;

                    case 7:
                        // Borrar un empleado
                        Console.WriteLine("Introduce el nif del empleado");
                        nif = Console.ReadLine();
                        break;
                }
            }
        }
    }
}