using EjemploCalculadora;

// Crear una instancia de la calculadora

Calculadora calculadora = new Calculadora();



// implementar un menu para la calculadora
bool salir = false;
while (!salir)
{
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("M. Guardar en la memoria");
    Console.WriteLine("R. Para recuperar el ultimo resultado");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Seleccine una opción");

    double num1, num2, resultado;
    string? opcion = Console.ReadLine();

    switch (opcion.ToUpper()) //ToUpper permite usar mayusculas y minusculas
    {
        case "1":
            Sumar(calculadora);
            break;

        //{
        //    //antes lo tenía así
        //    //Console.WriteLine("Ingrese el primer número: ");
        //    //num1 = calculadora.ObtenerNumero(Console.ReadLine());
        //    //Console.WriteLine("Ingrese el segundo número: ");
        //    //num2 = calculadora.ObtenerNumero(Console.ReadLine());
        //    //double suma = calculadora.Sumar(num1, num2);
        //    //calculadora.MostrarMensaje($"El resultado de la suma es: {suma}");
        //    //break;
        //    //lo que hicimos fue crear la clase parametros, luego refactorizamos para no repetir codigo en los otros case
        //    ParametrosCalculadora parametros = PedirParametros(calculadora);
        //    double suma = calculadora.Sumar(parametros.Num1, parametros.Num2);
        //    calculadora.MostrarMensaje($"El resultado de la suma es: {suma}");
        //    break;
        //}
        case "2":
            Restar(calculadora);
            break;
            
        case "3":
          Multiplicar(calculadora);
            break;
        case "4":
           Dividir(calculadora);   
            break;
        case "M":
            {
                Console.WriteLine("Ingrese el valor que desea guardar en la memoria");
                resultado = Convert.ToDouble(Console.ReadLine());
                calculadora.GuardarEnMemoria(resultado);
                break;
            }
        case "R":
            {
                resultado = calculadora.RecuperarUltimoResultado();
                calculadora.MostrarMensaje($"Valor recuperado: {resultado}");
                break;
            }
        case "5":
            salir = true;
            break;
        default:
            calculadora.MostrarMensaje("Opcion inválida");
            break;
    }
}

static void Sumar(Calculadora calculadora)
{
    // Suma de dos numeros
    ParametrosCalculadora parametros = PedirParametros(calculadora);
    double suma = calculadora.Sumar(parametros.Num1, parametros.Num2);
    calculadora.MostrarMensaje($"El resultado de la suma es: {suma}");
}
static void Restar(Calculadora calculadora)
{
    ParametrosCalculadora parametros = PedirParametros(calculadora);
    double resta = calculadora.Restar(parametros.Num1, parametros.Num2);
    calculadora.MostrarMensaje($"El resultado de la resta es: {resta}");
}

static void Multiplicar(Calculadora calculadora)
{
    ParametrosCalculadora parametros = PedirParametros(calculadora);
    double multiplicacion = calculadora.Multiplicar(parametros.Num1, parametros.Num2);
    calculadora.MostrarMensaje($"El resultado de la multiplicacion es: {multiplicacion}");
}
static void Dividir(Calculadora calculadora)
{
    ParametrosCalculadora parametros = PedirParametros(calculadora);
    double division = calculadora.Dividir(parametros.Num1, parametros.Num2);
    calculadora.MostrarMensaje($"El resultado de la división es: {division}");
}

static ParametrosCalculadora PedirParametros(Calculadora calculadora)
{
    var parametros = new ParametrosCalculadora();

    // Obtener el primer número
    Console.WriteLine("Ingrese el primer número o presione 'M' si desea usar el número de la memoria, o 'R' para usar el último resultado:");
    parametros.Num1 = ObtenerNumeroConOpcion(calculadora, null); // Primer número sin restricciones

    // Obtener el segundo número
    Console.WriteLine("Ingrese el segundo número o presione 'M' si desea usar el número de la memoria, o 'R' para usar el último resultado:");
    parametros.Num2 = ObtenerNumeroConOpcion(calculadora, parametros.Num1); // Segundo número no puede ser igual al primero

    return parametros;
}

// Método para obtener el número, permitiendo usar memoria o último resultado
static double ObtenerNumeroConOpcion(Calculadora calculadora, double? numeroYaIngresado)
{
    string? entrada;
    double numero;

    while (true)
    {
        entrada = Console.ReadLine();

        if (entrada.ToUpper() == "M")
        {
            numero = calculadora.RecuperarDeMemoria();
            Console.WriteLine($"Usando el número de la memoria: {numero}");
        }
        else if (entrada.ToUpper() == "R")
        {
            numero = calculadora.RecuperarUltimoResultado();
            Console.WriteLine($"Usando el último resultado: {numero}");
        }
        else
        {
            numero = calculadora.ObtenerNumero(entrada); // Si el usuario ingresa un número manualmente
        }

        // Si el segundo número es igual al primero, pedimos que ingrese otro
        if (numeroYaIngresado.HasValue && numero == numeroYaIngresado)
        {
            Console.WriteLine("El segundo número no puede ser igual al primero. Por favor ingrese otro número.");
        }
        else
        {
            break; // Salir del bucle si el número es válido
        }
    }

    return numero;
}