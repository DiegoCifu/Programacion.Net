using System.Runtime.Intrinsics.X86;

namespace EjemploTiendaProyecto.Resultados
{
    /// <summary>
    /// Clase que representa el resultado de una operación.
    /// </summary>
    /// <typeparam name="T">Tipo del resultado de la operación.</typeparam>
    public class ResultadoOperacion<T>
    {
        /// <summary>
        /// Obtiene o establece el resultado de la operación.
        /// </summary>
        public T Resultado { get; set; }
    }

}
