using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCalculadora
{
    public class Calculadora
    {
        //Metodo que suma dos numeros

        public double Sumar(double num1, double num2)
        //Sumar sería el método
        {
            MostrarMensaje($"Se van a sumar dos números {num1} y {num2}");
            return (num1 + num2);
        }
        public double Restar(double num1, double num2)

        {
            MostrarMensaje($"Se van a restar dos números {num1} y {num2}");
            return (num1 - num2);
        }

        public double Multiplicar(double num1, double num2)

        {
            MostrarMensaje($"Se van a multiplicar dos números {num1} y {num2}");
            return (num1 * num2);
        }

        public double Dividir(double num1, double num2)

        {
            if (num2 == 0)
            {
                MostrarMensaje("Error: No se puede dividir por cero.");
                return 0;
            }
            MostrarMensaje($"Se van a dividir dos números: {num1} y {num2}");
            return num1 / num2;
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

       
    }
}
