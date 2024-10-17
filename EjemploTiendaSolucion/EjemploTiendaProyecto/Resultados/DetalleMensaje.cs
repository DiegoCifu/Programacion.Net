namespace EjemploTiendaProyecto.Resultados
{
    public class DetalleMensaje
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public DetalleMensaje(int codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }
    }
}
