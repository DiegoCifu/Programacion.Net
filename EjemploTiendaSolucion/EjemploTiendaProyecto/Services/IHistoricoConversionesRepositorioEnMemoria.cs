namespace EjemploTiendaProyecto.Services;

public class HistoricoConversionesRepositorioEnMemoria : IHistoricoConversionesRepositorio
{
    // Instancia estática única del repositorio
    private static HistoricoConversionesRepositorioEnMemoria _instancia;

    // Método para obtener la instancia única
    public static HistoricoConversionesRepositorioEnMemoria Instancia
    {
        get
        {
            if (_instancia == null)
            {
                _instancia = new HistoricoConversionesRepositorioEnMemoria();
            }
            return _instancia;
        }
    }

    // Lista para almacenar los registros de conversiones
    private List<HistoricoConversiones> _historicoConversiones;

    public List<HistoricoConversiones> HistoricoConversiones
    {
        get { return _historicoConversiones; }
        set { _historicoConversiones = value; }
    }

    public HistoricoConversionesRepositorioEnMemoria()
    {
        _historicoConversiones = new List<HistoricoConversiones>();

        // Agregar datos de prueba al repositorio
        _historicoConversiones.AddRange(new List<HistoricoConversiones>
        {
            new HistoricoConversiones
            {
                Id = 1,
                MonedaOrigenId = 1, // Ejemplo de ID de Moneda Origen
                MonedaDestinoId = 2, // Ejemplo de ID de Moneda Destino
                TasaConversion = 0.84m, // Ejemplo de tasa de conversión de USD a EUR
                Cantidad = 100m,
                Resultado = 84m, // Cantidad * TasaConversion
                Fecha = DateTime.Now.AddDays(-10) // Hace 10 días
            },
            new HistoricoConversiones
            {
                Id = 2,
                MonedaOrigenId = 2, // Ejemplo de EUR
                MonedaDestinoId = 1, // Ejemplo de USD
                TasaConversion = 1.19m, // Ejemplo de tasa de conversión de EUR a USD
                Cantidad = 50m,
                Resultado = 59.5m, // Cantidad * TasaConversion
                Fecha = DateTime.Now.AddDays(-5) // Hace 5 días
            },
            new HistoricoConversiones
            {
                Id = 3,
                MonedaOrigenId = 3, // Ejemplo de ID de Moneda GBP
                MonedaDestinoId = 1, // Ejemplo de USD
                TasaConversion = 1.35m, // Ejemplo de tasa de conversión de GBP a USD
                Cantidad = 75m,
                Resultado = 101.25m, // Cantidad * TasaConversion
                Fecha = DateTime.Now.AddDays(-2) // Hace 2 días
            }
        });
    }

    public IEnumerable<HistoricoConversiones> ObtenerTodos()
    {
        return _historicoConversiones;
    }



    public void Actualizar(HistoricoConversiones historicoConversiones)
    {
        var existente = ObtenerPorId(historicoConversiones.Id);
        if (existente != null)
        {
            existente.MonedaOrigenId = historicoConversiones.MonedaOrigenId;
            existente.MonedaDestinoId = historicoConversiones.MonedaDestinoId;
            existente.TasaConversion = historicoConversiones.TasaConversion;
            existente.Cantidad = historicoConversiones.Cantidad;
            existente.Resultado = historicoConversiones.Resultado;
            existente.Fecha = historicoConversiones.Fecha;
        }
    }

    public void Agregar(HistoricoConversiones historicoConversiones)
    {
        historicoConversiones.Id = _historicoConversiones.Count > 0 ? _historicoConversiones.Max(h => h.Id) + 1 : 1;
        _historicoConversiones.Add(historicoConversiones);
    }

    public void Eliminar(int id)
    {
        var historico = ObtenerPorId(id);
        if (historico != null)
        {
            _historicoConversiones.Remove(historico);
        }
    }

    public HistoricoConversiones ObtenerPorId(int id)
    {
        return _historicoConversiones.FirstOrDefault(h => h.Id == id);
    }


}
