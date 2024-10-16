namespace EjemploTiendaProyecto.Models
{
    public class HistoricoConversiones
    {
        public int Id { get; set; } 
        public int MonedaOrigenId { get; set; }
        public int MonedaDestinoId { get; set;}
        public decimal TasaConversion { get; set; }
        // cantidad convertida
        public decimal Cantidad { get; set}
        // Resultado de la conversion
        public decimal Resultado { get; set}
        public DateTime Fecha { get; set; }

    }
}
