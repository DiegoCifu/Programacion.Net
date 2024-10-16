
using EjemploTiendaProyecto.Models;

namespace EjemploTiendaProyecto.Services;

public class ClienteRepositorioEnMemoria : IClienteRepositorio
{
    private readonly List<Cliente> _clientes;
    public ClienteRepositorioEnMemoria()
    {
        _clientes = new List<Cliente>
        {
            new Cliente { Id = 01, Nombre = "Juan Carlos", Edad = "40", Profesion = "Psicólogo" },
            new Cliente { Id = 02, Nombre = "Manuel Alvarez", Edad = "34", Profesion = "Mecánico" },
            new Cliente { Id = 03, Nombre = "Sergio Garcia", Edad = "20", Profesion = "Estudiante" },
            new Cliente { Id = 04, Nombre = "Belen Salas", Edad = "30", Profesion = "Gerente" },
            new Cliente { Id = 05, Nombre = "Andrea Jaramillo", Edad = "45", Profesion = "Profesora" },
       };
    }

    public IEnumerable<Cliente> ObtenerTodas()
    {
        return _clientes;
    }

    public Cliente ObtenerPorId(int id)
    {
        // Buscar la moneda por su Id
        // Mediante LINQ 
        // LINQ significa Language Integrated Query (Consulta Integrada de Lenguaje)
        return _clientes.FirstOrDefault(m => m.Id == id);
    }
}