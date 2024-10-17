using EjemploTiendaProyecto.Resultados;
using Microsoft.AspNetCore.Mvc;

namespace EjemploTiendaProyecto.Controllers
{
    public class OperacionesController : Controller
    {
        // Resultado de una operación que devuelve un entero
        public IActionResult ResultadoEntero()
        {
            var resultado = new ResultadoOperacionEntero();
            resultado.Resultado = 10;
            return View(resultado);
        }

        // Resultado de una operación que devuelve un decimal
        public IActionResult ResultadoDecimal()
        {
            var resultado = new ResultadoOperacionDecimal();
            resultado.Resultado = 15.75M;
            return View(resultado);
        }

        // Resultado de una operación que devuelve un string
        public IActionResult ResultadoString()
        {
            var resultado = new ResultadoOperacionString();
            resultado.Resultado = "Éxito";
            return View(resultado);
        }

    }
}
