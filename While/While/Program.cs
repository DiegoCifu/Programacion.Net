// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

//Intentos averiguar la contraseña
string contraseña = "1234";
string contraseñaIntroducida = "";

int intentos = 0;

while (contraseñaIntroducida != contraseña)
{
    Console.WriteLine("Introduce la contraseña:");
    contraseñaIntroducida = Console.ReadLine();
    intentos++;

    if (contraseña == contraseñaIntroducida)
    {
        Console.WriteLine("¡Contraseña correcta!");
    }

    else
    {
        Console.WriteLine("Contraseña Incorrecta, intentalo de nuevo");

        if (intentos >= 3)
        {
            Console.WriteLine("¡Has superado el número de intentos!");
            return;
        }
    }
}
    int opcion;

    do
    {
        Console.WriteLine("\nMenú de opciones:");
        Console.WriteLine("1. Mostrar la fecha y hora actuales");
        Console.WriteLine("2. Sumar dos números");
        Console.WriteLine("3. Contar hasta un número");
        Console.WriteLine("4. Salir");

        Console.WriteLine("Introduzca una opcion");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion) {
            case 1:
                DateTime fechaEntrada = DateTime.Now;
                Console.WriteLine(fechaEntrada);
                break;
            case 2:
            Console.WriteLine("Introduce el primer número:");
            string input1 = Console.ReadLine(); // Leer entrada del usuario
            int numero1 = Convert.ToInt32(input1); // Convertir la entrada a entero

            // Solicitar al usuario el segundo número
            Console.WriteLine("Introduce el segundo número:");
            string input2 = Console.ReadLine(); // Leer entrada del usuario
            int numero2 = Convert.ToInt32(input2); // Convertir la entrada a entero

            // Sumar los dos números
            int suma = numero1 + numero2; // Realizar la suma

            // Mostrar el resultado
            Console.WriteLine("La suma de {0} y {1} es: {2}", numero1, numero2, suma);

            break;
            case 3:
            // Solicitar al usuario un número
            Console.WriteLine("Introduce un número hasta el cual deseas contar:");
            string input = Console.ReadLine(); // Leer entrada del usuario

            // Convertir la entrada a un entero
            int numero;
            if (int.TryParse(input, out numero))
            {
                // Contar desde 1 hasta el número introducido
                for (int i = 1; i <= numero; i++)
                {
                    Console.WriteLine(i); // Mostrar el número actual
                }
            }
            else
            {
                // Mensaje de error si la conversión falla
                Console.WriteLine("Por favor, introduce un número válido.");
            }
            break;
            case 4:
                Console.WriteLine("Ha seleccionado la opción 4");
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    } while (opcion != 4);
