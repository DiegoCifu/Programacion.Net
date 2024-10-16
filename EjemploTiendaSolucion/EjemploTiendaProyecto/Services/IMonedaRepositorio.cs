using EjemploTiendaProyecto.Models;

namespace EjemploTiendaProyecto.Services;

public interface IMonedaRepositorio
{
    IEnumerable<Moneda> ObtenerTodas();
    Moneda ObtenerPorId(int id);
}
