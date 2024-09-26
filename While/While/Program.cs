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
    int suma = 0;

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
                Console.WriteLine("Ingresa 2 números que quieras sumar");
            for (int i = 1; i<=2; i++)
            {
                Console.WriteLine($"Pon el numero {i}");
                Console.WriteLine("");
                Console.WriteLine("");

                int input = int.Parse(Console.ReadLine());
                suma += input;

                Console.WriteLine($"La suma es {suma}");
                Console.ReadLine();
            }
                break;
            case 3:
                Console.WriteLine("Ha seleccionado la opción 3");
                break;
            case 4:
                Console.WriteLine("Ha seleccionado la opción 4");
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    } while (opcion != 4);
