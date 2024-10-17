using EjemploTiendaProyecto.Mensajeria;
using Microsoft.AspNetCore.Mvc;

namespace EjemploTiendaProyecto.Controllers
{
    public class NotificacionesController : Controller
    {
        // Acción que procesa una notificación de correo electrónico
        public IActionResult ProcesarEmail()
        {
            var email = new Email
            {
                Destinatario = "usuario@ejemplo.com",
                Asunto = "Bienvenida",
                Cuerpo = "Gracias por unirte a nuestro servicio."
            };

            var manejadorEmail = new NotificacionHandler<Email>();
            var resultado = manejadorEmail.ProcesarNotificacion(email);

            return View("MostrarResultado", resultado);
        }

        // Acción que procesa una notificación de SMS
        public IActionResult ProcesarSMS()
        {
            var sms = new SMS
            {
                NumeroTelefono = "123456789",
                Mensaje = "Tu código de verificación es 1234."
            };

            var manejadorSMS = new NotificacionHandler<SMS>();
            var resultado = manejadorSMS.ProcesarNotificacion(sms);

            return View("MostrarResultado", resultado);
        }


        // Acción que procesa una notificación push
        public IActionResult ProcesarPushNotification()
        {
            var push = new PushNotification
            {
                DispositivoId = "ABC123",
                Titulo = "Notificación de Bienvenida",
                Mensaje = "Gracias por instalar nuestra aplicación móvil."
            };

            var manejadorPush = new NotificacionHandler<PushNotification>();
            var resultado = manejadorPush.ProcesarNotificacion(push);

            return View("MostrarResultado", resultado);
        }
    }
}

