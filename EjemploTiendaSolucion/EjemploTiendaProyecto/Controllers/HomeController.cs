using EjemploTiendaProyecto.Models;
using EjemploTiendaProyecto.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploTiendaProyecto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailService _emailService;

        public HomeController(ILogger<HomeController> logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Message = "�Gracias por tu inter�s en nuestra tienda!";
            ViewBag.Fecha = DateTime.Now;
            ViewBag.Email = "pedidos@mail.com";

            return View();
        }

        public IActionResult QuienesSomos()
        {
            ViewBag.Message = "Quienes somos. Conoce nuestra tienda";
          

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
