using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

<<<<<<< HEAD
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Dealership MIDIAS 🚗🚗🚗🚗🚗🚗🚗",
        Version = "♾️"
    });
});

=======
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
>>>>>>> 279e1f6b4f994817ff7e64672f5664fb5791418a
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
<<<<<<< HEAD
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.DocumentTitle = "Minha API - Documentação";
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minha API v1");
    });
=======
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
>>>>>>> 279e1f6b4f994817ff7e64672f5664fb5791418a
}

app.Run();