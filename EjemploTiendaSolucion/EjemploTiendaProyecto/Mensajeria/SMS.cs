namespace EjemploTiendaProyecto.Mensajeria
{
    public class SMS : INotificacion
    {
        public string NumeroTelefono { get; set; }
        public string Mensaje { get; set; }

        // Implementación del método Enviar de la interfaz INotificacion
        public string Enviar()
        {
            return $"Enviando SMS al número {NumeroTelefono} con el mensaje: {Mensaje}.";
        }
    }
}
