using Microsoft.AspNetCore.Mvc;

namespace EjemploTiendaProyecto.Controllers
{
    public class ArrayController : Controller
    {
        private int[] numeros = new int[5];

        public ArrayController()
        {
            // Usar inicializadores de colección para llenar el array
            numeros = new int[] { 10, 20, 30, 40, 50 };
        }

        // Realizar una iteración por los elementos del array
        // GET: /Array/IterarElementos
        [HttpGet]
        public IActionResult IterarElementos()
        {
            return View(numeros);
        }

        // Usar métodos de array (Ejemplo: Reverse)
        [HttpGet]
        public IActionResult InvertirArray()
        {
            Array.Reverse(numeros);
            return View(numeros);
        }

        // Obtener un elemento del array
        // GET: /Array/ObtenerElemento?indice=3
        [HttpGet]
        public IActionResult ObtenerElemento(int indice)
        {
            if (indice < 0 || indice >= numeros.Length)
                return View("Error", "Índice fuera de rango");

            return View(numeros[indice]);
        }

        // FAQ
        [HttpGet]
        public IActionResult FAQ()
        {
            return View();
        }
    }
}
