using Dealership.Data;
using Microsoft.OpenApi;
using Car.Routes;
using Motorcycle.Routes;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<CarContext>(options =>
    options.UseSqlite("Data Source=dealership.db"));

builder.Services.AddDbContext<MotorcycleContext>(options =>
    options.UseSqlite("Data Source=dealership.db"));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Dealership MIDIAS 🚗🚗🚗🚗🚗🚗🚗",
        Version = "♾️"
    });
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.DocumentTitle = "Concessionária Estagiários Mídia";
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minha API v1");
    });
}
app.CarRoutes();
app.MotorcycleRoutes();

app.Run();