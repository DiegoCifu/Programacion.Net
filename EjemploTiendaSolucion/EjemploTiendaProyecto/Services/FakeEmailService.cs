namespace EjemploTiendaProyecto.Services
{
    public class FakeEmailService : IEmailService
    {

        public Task SendEmailAsync(string to, string subject, string body)
        {
            Console.WriteLine($"Simulando envío de correo a: {to}, Asunto: {subject}, Cuerpo: {body}");
            return Task.CompletedTask;
        }
    }
}
