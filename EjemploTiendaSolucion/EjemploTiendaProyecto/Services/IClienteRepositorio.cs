using EjemploTiendaProyecto.Models;

namespace EjemploTiendaProyecto.Services
{
    public interface IClienteRepositorio
    {
        IEnumerable<Cliente> ObtenerTodas();
        Cliente ObtenerPorId(int id);
    }
}
