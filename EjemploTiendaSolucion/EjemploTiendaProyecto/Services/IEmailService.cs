namespace EjemploTiendaProyecto.Services
{
    public interface IEmailService
    {
        /*
         •  public interface IEmailService: Declara una interfaz pública llamada IEmailService. 
                En C#, una interfaz es un contrato que define un conjunto de métodos 
                que una clase debe implementar.
         •  Task SendEmailAsync(string to, string subject, string body): Define un método asíncrono 
                llamado SendEmailAsync que toma tres parámetros:
                •  to: Una cadena que representa la dirección de correo electrónico del destinatario.
                •  subject: Una cadena que representa el asunto del correo electrónico.
                •  body: Una cadena que representa el cuerpo del correo electrónico.
         •  Task: El tipo de retorno Task indica que el método es asíncrono 
                  y puede ejecutarse de manera no bloqueante.
         
         */
        Task SendEmailAsync(string to, string subject, string body);
    }
}
