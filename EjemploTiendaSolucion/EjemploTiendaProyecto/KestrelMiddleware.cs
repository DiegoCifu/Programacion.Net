namespace EjemploTiendaProyecto
{
    public class KestrelMiddleware
    {
        private readonly RequestDelegate _next;

        public KestrelMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Añadir una cabecera que indique que el servidor es Kestrel
            context.Response.OnStarting(() =>
            {
                context.Response.Headers.Add("X-Server", "Kestrel");
                return Task.CompletedTask;
            });

            // Llamar al siguiente middleware en el pipeline
            await _next(context);
        }
    }
}
