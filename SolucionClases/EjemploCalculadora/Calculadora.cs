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
        private double memoria;
        public double Sumar(double num1, double num2)
        //Sumar sería el método
        {
            MostrarMensaje($"Se van a sumar dos números {num1} y {num2}");
            return (num1 + num2);
        }
        //Restar
        public double Restar(double num1, double num2)

        {
            MostrarMensaje($"Se van a restar dos números {num1} y {num2}");
            return (num1 - num2);
        }
        // multiplicar
        public double Multiplicar(double num1, double num2)

        {
            MostrarMensaje($"Se van a multiplicar dos números {num1} y {num2}");
            return (num1 * num2);
        }

        // Método para dividir
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

        // Método para guardar el resultado en memoria
        public void GuardarEnMemoria(double resultado)
        {
            memoria = resultado;
            MostrarMensaje($"Se ha guardado en memoria el valor: {memoria}");
        }

        // Método para recuperar el valor guardado en memoria
        public double RecuperarDeMemoria()
        {
            MostrarMensaje($"Se ha recuperado el valor de memoria: {memoria}");
            return memoria;
        }
        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        // Método para verificar si se debe usar la memoria o ingresar un número nuevo
        public double ObtenerNumero(string mensaje)
        {
            Console.WriteLine($"{mensaje} (Escriba 'M' para usar el valor en memoria): ");
            string input = Console.ReadLine();

            // Si el usuario ingresa 'M', se usa la memoria
            if (input.ToUpper() == "M")
            {
                return RecuperarDeMemoria();
            }
            else
            {
                // Intentar convertir el valor ingresado a número
                double numero;
                bool esNumeroValido = Double.TryParse(input, out numero);

                if (esNumeroValido)
                {
                    return numero;
                }
                else
                {
                    MostrarMensaje("Error: Debe ingresar un número válido.");
                    return ObtenerNumero(mensaje);  // Vuelve a solicitar el número si no es válido
                }
            }
        }

    }
}
