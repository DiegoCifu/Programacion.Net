namespace EjemploTiendaProyecto.Mensajeria
{

    // Clase genérica que solo acepta tipos que implementen INotificacion
    public class NotificacionHandler<T> where T : INotificacion
    {
        // Método genérico para procesar una notificación
        public string ProcesarNotificacion(T notificacion)
        {
            // Aquí llamamos al método Enviar de la interfaz INotificacion
            return notificacion.Enviar();
        }
    }
}
