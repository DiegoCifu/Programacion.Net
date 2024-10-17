namespace EjemploTiendaProyecto.Resultados
{
    /// <summary>
    /// Clase que representa el resultado de una operación con dos tipos.
    /// </summary>
    /// <typeparam name="TResultado">Tipo del resultado de la operación.</typeparam>
    /// <typeparam name="TMensaje">Tipo del mensaje de la operación.</typeparam>
    public class ResultadoOperacionTipos<TResultado, TMensaje>
    {
        /// <summary>
        /// Obtiene o establece el resultado de la operación.
        /// </summary>
        public TResultado Resultado { get; set; }

        /// <summary>
        /// Obtiene o establece el mensaje de la operación.
        /// </summary>
        public TMensaje Mensaje { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ResultadoOperacionTipos{T, V}"/>.
        /// </summary>
        public ResultadoOperacionTipos()
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ResultadoOperacionTipos{T, V}"/> 
        /// con los parámetros especificados.
        /// 
        /// this() - Esta parte del constructor llama al constructor sin parámetros 
        /// de la misma clase (ResultadoOperacionTipos).
        /// -Es una forma de reutilizar la lógica del constructor sin parámetros 
        /// antes de ejecutar el código específico del constructor con parámetros.
        /// -En este caso, el constructor sin parámetros no hace nada especial, 
        /// pero esta llamada asegura que cualquier inicialización definida 
        /// en el constructor sin parámetros se ejecute.
        /// 
        /// </summary>
        /// <param name="resultado">El resultado de la operación.</param>
        /// <param name="mensaje">El mensaje de la operación.</param>
        public ResultadoOperacionTipos(TResultado resultado, TMensaje mensaje) : this()
        {
            Resultado = resultado;
            Mensaje = mensaje;
        }
    }

}
