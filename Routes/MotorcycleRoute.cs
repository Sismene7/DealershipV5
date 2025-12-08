using Dealership.Data;
using Motorcycle.Models;

namespace Motorcycle.Routes;

public static class MotorcycleRoute
{
    public static void MotorcycleRoutes(this WebApplication app)
    {
        var route = app.MapGroup(prefix: "Motorcycle");

        route.MapPost(pattern: "",
        async (MotorcycleContext context, MotorcycleRequest req) =>
        {
    var Motorcycle = new MotorcycleModel(
            req.id,
            req.nome,
            req.marca,
            req.ano,
            req.potencia,
            req.km,
            req.tipo,
            req.valor,
            req.cor,
            req.cilindradas,
            req.cilindros,
            req.torque,
            req.partidaEletrica,
            req.abs);
            await context.AddAsync(Motorcycle);
            await context.SaveChangesAsync();
        });

    }
}