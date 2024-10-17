using EjemploTiendaProyecto.Resultados;
using Microsoft.AspNetCore.Mvc;

namespace EjemploTiendaProyecto.Controllers
{
    public class OperacionesGenericoController : Controller
    {
        // Resultado de una operación que devuelve un entero
        public IActionResult ResultadoEntero()
        {
            var resultado = new ResultadoOperacion<int>();
            resultado.Resultado = 10;
            return View(resultado);
        }

        // Resultado de una operación que devuelve un decimal
        public IActionResult ResultadoDecimal()
        {
            var resultado = new ResultadoOperacion<decimal>();
            resultado.Resultado = 15.75M;
            return View(resultado);
        }

        // Resultado de una operación que devuelve un string
        public IActionResult ResultadoString()
        {
            var resultado = new ResultadoOperacion<string>();
            resultado.Resultado = "Exito";
            return View(resultado);
        }

        // Resultado de una operación que devuelve un string
        public IActionResult ResultadoTipoComplejo()
        {
            var resultado = new ResultadoOperacion<TipoComplejo>();
            resultado.Resultado = new TipoComplejo { Id = 1, Nombre = "Tipo Complejo" };
            return View(resultado);
        }
    }
}
