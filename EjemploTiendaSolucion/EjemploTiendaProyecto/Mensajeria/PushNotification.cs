namespace EjemploTiendaProyecto.Mensajeria
{
    public class PushNotification : INotificacion
    {
        public string DispositivoId { get; set; }
        public string Titulo { get; set; }
        public string Mensaje { get; set; }

        // Implementación del método Enviar de la interfaz INotificacion
        public string Enviar()
        {
            return $"Enviando notificación push al dispositivo {DispositivoId}. Título: {Titulo}, Mensaje: {Mensaje}.";
        }
    }
}
