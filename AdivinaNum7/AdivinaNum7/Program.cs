internal class Program
{
    private static void Main(string[] args)
    {
        int numeroSecreto = 7; // Número que el usuario debe adivinar
        int intento = 0; // Variable para almacenar el intento del usuario
        bool adivinado = false; // Variable para controlar el estado del juego

        Console.WriteLine("¡Adivina el número! (Entre 1 y 10)");

        // Bucle que permite al usuario intentar adivinar
        while (!adivinado)
        {
            Console.Write("Introduce tu intento: ");
            string input = Console.ReadLine(); // Leer entrada del usuario

            // Intentar convertir la entrada a un número entero
            if (int.TryParse(input, out intento))
            {
                if (intento < 1 || intento > 10)
                {
                    Console.WriteLine("Por favor, introduce un número entre 1 y 10.");
                }
                else if (intento < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("¡Correcto! Has adivinado el número.");
                    adivinado = true; // Cambia el estado a verdadero para salir del bucle
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }
}