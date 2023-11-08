using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T2SanJuanThompsonJosephLuca
{
    internal class Empleado
    {
        private string nombre;
        private string apellido1;
        private string apellido2;
        private int edad;
        private string NIF;
        private double salario;
        List<Empleado> empleados = new List<Empleado>();

        public Empleado(string nombre, string apellido1, string apellido2, int edad, string NIF, double salario)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Edad = edad;
            Nif = NIF;
            Salario = salario;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public string Apellido1 { get { return apellido1; } set { apellido1 = value; } }

        public string Apellido2 { get { return apellido2; } set { apellido2 = value; } }

        public string Nif { get {  return Nif; } set {  Nif = value; } }

        public double Salario { get {  return salario; } set {  salario = value; } }

        public int Edad { get { return edad; } set { edad = value; } }

        public string toString()
        {
            String sb = "Nombre: " + nombre + " " + apellido1 + " " + apellido2;
                   sb += "\nEdad: " + edad + " años";
                   sb += "\nNIF: " + NIF;
                   sb += "\nSalario " + salario + "€";
            return sb;
        }
        public Empleado ObtenerEmpleado(string nif)
        {
            Empleado e;
            foreach (Empleado emp in empleados)
            {
                if (emp.Nif == nif)
                {
                    e = emp;
                    return e;
                }
            }
            return null;
        }

        public void NuevoEmpleado()
        {
            Console.WriteLine("Introduce el nombre del empleado:");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce su primer apellido");
            apellido1 = Console.ReadLine();
            Console.WriteLine("Introduce su segundo apellido");
            apellido2 = Console.ReadLine();
            Console.WriteLine("Introduce la edad del empleado");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el NIF");
            NIF = Console.ReadLine();
            Console.WriteLine("Introduce el salario");
            salario = double.Parse(Console.ReadLine());
            Empleado empleado = new Empleado(nombre, apellido1, apellido2, edad, NIF, salario);
            empleados.Add(empleado);
        }

        public void ActualizarSalarioEmpleado(string nif, double sal)
        {
            Empleado e = ObtenerEmpleado(nif);
            e.Salario = sal;
        }

        public void MostrarNombreEmpleado(string nif)
        {
            Empleado e = ObtenerEmpleado(nif);
            Console.WriteLine(e.NombreCompleto());
        }
        public String NombreCompleto()
        {
            return nombre + " " + apellido1 + " " + apellido2;
        }

        public void MostrarEdadEmpleado(string nif)
        {
            Empleado e = ObtenerEmpleado(nif);
            Console.WriteLine(e.Edad);
        }

        public void MostrarUnEmpleado(string nif)
        {
            Empleado e = ObtenerEmpleado(nif);
            Console.WriteLine(e.ToString());
        }

        public void MostrarEmpleados()
        {
            foreach (Empleado empleado in empleados)
            {
                empleado.toString();
            }
        }

        public void BorrarEmpleado(string nif)
        {
            Empleado e = ObtenerEmpleado(nif);
            empleados.Remove(e);
        }
    }
}
