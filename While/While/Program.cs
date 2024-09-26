// See https://aka.ms/new-console-template for more information
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
