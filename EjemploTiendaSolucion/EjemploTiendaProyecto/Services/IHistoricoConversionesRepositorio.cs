namespace EjemploTiendaProyecto.Services
{
    // Interfaz para el repositorio de historico de conversiones
    public interface IHistoricoConversionesRepositorio
    {
        IEnumerable<HistoricoConversiones> ObtenerTodos();
        HistoricoConversiones ObtenerPorId(int id);
        void Agregar(HistoricoConversiones historicoConversiones);
        void Actualizar(HistoricoConversiones historicoConversiones);
        void Eliminar(int id);
    }
}
