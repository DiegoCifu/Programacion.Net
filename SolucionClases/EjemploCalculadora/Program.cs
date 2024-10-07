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
    Console.WriteLine("R. Para recuperar valores anteriores");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Seleccine una opción");
    string opcion = Console.ReadLine();

    double num1, num2, resultado;

    switch (opcion.ToUpper())
    {
        case "1":
            Console.WriteLine("Ingrese el primer número: ");
            num1 = calculadora.ObtenerNumero(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = calculadora.ObtenerNumero(Console.ReadLine());
            double suma = calculadora.Sumar(num1, num2);
            calculadora.MostrarMensaje($"El resultado de la suma es: {suma}");
            break;
        case "2":
            Console.WriteLine("Ingrese el primer número: ");
            num1 = calculadora.ObtenerNumero(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = calculadora.ObtenerNumero(Console.ReadLine());
            double resta = calculadora.Restar(num1, num2);
            calculadora.MostrarMensaje($"El resultado de la resta es: {resta}");
            break;
        case "3":
            Console.WriteLine("Ingrese el primer número: ");
            num1 = calculadora.ObtenerNumero(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = calculadora.ObtenerNumero(Console.ReadLine());
            double multiplicacion = calculadora.Multiplicar(num1, num2);
            calculadora.MostrarMensaje($"El resultado de la multiplicacion es: {multiplicacion}");
            break;
        case "4":
            Console.WriteLine("Ingrese el primer número: ");
            num1 = calculadora.ObtenerNumero(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = calculadora.ObtenerNumero(Console.ReadLine());
            double division = calculadora.Dividir(num1, num2);
            calculadora.MostrarMensaje($"El resultado de la división es: {division}");
            break;
        case "M":
            Console.WriteLine("Ingrese el valor que desea guardar en la memoria");
            resultado = Convert.ToDouble(Console.ReadLine());
            calculadora.GuardarEnMemoria(resultado);
            break;
        case "R":
            resultado = calculadora.RecuperarResultado();
            calculadora.MostrarMensaje($"Valor recuperado: {resultado}");
            break;
        case "5":
            salir = true;
            break;
        default:
            calculadora.MostrarMensaje("Opcion inválida");
            break;
    }
}