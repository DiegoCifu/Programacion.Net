using EjemploTiendaProyecto.Services;

var builder = WebApplication.CreateBuilder(args);

#region Servicios
//      =========

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configurar servicios dependiendo del entorno
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddScoped<IEmailService, FakeEmailService>();
}
else
{
    builder.Services.AddScoped<IEmailService, RealEmailService>();
}

#endregion

var app = builder.Build();

#region Middleware
//      ==========

// Añadir el middleware personalizado al pipeline
app.UseMiddleware<KestrelMiddleware>();

// Agregar nuestro middleware personalizado al pipeline
app.UseMiddleware<RequestTimingMiddleware>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

#endregion

app.Run();
