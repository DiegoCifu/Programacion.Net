namespace EjemploTiendaProyecto.Services
{
    public class RealEmailService : IEmailService
    {
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            // Aquí podrías implementar el envío real utilizando SMTP u otro servicio de correo
            Console.WriteLine($"Enviando correo real a: {to}, Asunto: {subject}, Cuerpo: {body}");
            await Task.CompletedTask;  // Simulación de un servicio real
        }
    }
}
