using EjemploTiendaProyecto.Resultados;
using Microsoft.AspNetCore.Mvc;

namespace EjemploTiendaProyecto.Controllers
{
    public class OperacionesTiposController : Controller
    {
        // Resultado de una operación que devuelve un entero y un mensaje string
        public IActionResult ResultadoEntero()
        {
            var resultado = new ResultadoOperacionTipos<int, string>(10, "Operación con enteros exitosa.");
            return View(resultado);
        }

        // Resultado de una operación que devuelve un decimal y un mensaje string
        public IActionResult ResultadoDecimal()
        {
            var resultado = new ResultadoOperacionTipos<decimal, string>(15.75M, "Operación con decimales exitosa.");
            return View(resultado);
        }

        // Resultado de una operación que devuelve un string y un mensaje booleano
        public IActionResult ResultadoString()
        {
            var resultado = new ResultadoOperacionTipos<string, bool>("Éxito", true);
            return View(resultado);
        }
        // Resultado de una operación que devuelve un tipo complejo con un mensaje complejo
        public IActionResult ResultadoComplejo()
        {
            var resultado = new ResultadoOperacionTipos<int, DetalleMensaje>(
                200,
                new DetalleMensaje(1, "El proceso fue completado con éxito.")
            );
            return View(resultado);
        }
    }
}