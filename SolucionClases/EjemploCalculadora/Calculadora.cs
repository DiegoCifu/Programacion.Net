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

        // Campo para almacenar el último resultado
        private double ultimoResultado;

        // Método que suma dos números
        public double Sumar(double num1, double num2)
        {
            MostrarMensaje($"Se van a sumar dos números: {num1} y {num2}");
            ultimoResultado = num1 + num2;
            return ultimoResultado;
        }

        // Método que resta dos números
        public double Restar(double num1, double num2)
        {
            MostrarMensaje($"Se van a restar dos números: {num1} y {num2}");
            ultimoResultado = num1 - num2;
            return ultimoResultado;
        }

        // Método que multiplica dos números
        public double Multiplicar(double num1, double num2)
        {
            MostrarMensaje($"Se van a multiplicar dos números: {num1} y {num2}");
            ultimoResultado = num1 * num2;
            return ultimoResultado;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                MostrarMensaje("Error: No se puede dividir por cero.");
                return 0;
            }
            MostrarMensaje($"Se van a dividir dos números: {num1} y {num2}");
            ultimoResultado = num1 / num2;
            return ultimoResultado;
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

        public double RecuperarUltimoResultado()
        {
            MostrarMensaje($"Se ha recuperado el último resultado: {ultimoResultado}");
            return ultimoResultado;
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        // Método para verificar si se debe usar la memoria, el último resultado, o ingresar un número nuevo
        public double ObtenerNumero(string mensaje)
        {
            double numero;
            bool esNumeroValido = false;

            // Mostrar mensaje una sola vez
            Console.WriteLine($"{mensaje} o presione 'M' si desea usar el número de la memoria, o 'R' para usar el último resultado: ");
            string input = Console.ReadLine();

            // Si el usuario ingresa 'M', se usa la memoria
            if (input.ToUpper() == "M")
            {
                return RecuperarDeMemoria();
            }
            // Si el usuario ingresa 'R', se usa el último resultado
            else if (input.ToUpper() == "R")
            {
                return RecuperarUltimoResultado();
            }
            else
            {
                // Intentar convertir el valor ingresado a número
                esNumeroValido = Double.TryParse(input, out numero);
                if (esNumeroValido)
                {
                    return numero;
                }
                else
                {
                    MostrarMensaje("Error: Debe ingresar un número válido.");
                    return ObtenerNumero(mensaje); // Volver a llamar al método si no es válido
                }
            }
        }

    }
}
