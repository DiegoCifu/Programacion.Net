using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploClases
{
    public class Empleado
    {
        public string Nombre
        { get; set; }

        public string Departamento
        { get; set; }

        public string Telefono { get; set; }

        public string NumeroEmpleado { get; set; }

        public string NSS { get; set; }

        public string IBAN { get; set; }


        // Metodo (Funcion) MostrarDatosEmpleado
        public void MostrarDatosEmpleado()
        {
            // Concatenación
            //Console.WriteLine("Nombre empleado: "+Nombre+" Departamento: "+Departamento+ " Telefono: "+Telefono);

            // Formato compuesto (string formatting)
            //Console.WriteLine("Nombre empleado: {0} Departamento: {1} Telefono: {2}",Nombre,Departamento,Telefono);

            // Mediante interpolación de cadenas
            Console.WriteLine($"Nombre empleado: {Nombre} Departamento Empleado: {Departamento} Telefono Empleado: {Telefono}");
        }
        public Empleado()
        {
            Nombre = "Sin nombre";
            Departamento = "Sin departamento";
            Telefono = "Sin Telefono";
        }

        // Constructor con parámetros
        public Empleado(string nombre, string departamento, string telefono, string iban, string numeroEmpleado)
        {
            Nombre = nombre;
            Departamento = departamento;
            Telefono = telefono;
            IBAN = iban;
            NumeroEmpleado = numeroEmpleado;
        }
    }
}