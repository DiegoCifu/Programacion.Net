using System.Diagnostics;

namespace EjemploTiendaProyecto
{
    public class RequestTimingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            // Llamar al siguiente middleware en el pipeline
            await _next(context);

            stopwatch.Stop();
            var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            // Loguear el tiempo de respuesta en consola
            Console.WriteLine($"Tiempo de procesamiento para la solicitud: {elapsedMilliseconds} ms");
        }
    }
}
