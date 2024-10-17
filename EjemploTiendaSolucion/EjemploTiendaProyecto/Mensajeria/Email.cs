namespace EjemploTiendaProyecto.Mensajeria
{
    public class Email : INotificacion
    {
        public string Destinatario { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }

        // Implementación del método Enviar de la interfaz INotificacion
        public string Enviar()
        {
            return $"Enviando correo a {Destinatario} con asunto {Asunto}.";
        }
    }
}
