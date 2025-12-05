using Dealership.Data;
using Vehicle.Models;

namespace Vehicle.Routes;

public static class VehicleRoute
{
    public static void VehicleRoutes(this WebApplication app)
    {
        var route = app.MapGroup(prefix:"Vehicle");

        route.MapPost(pattern:"",
        async(VehicleRequest req, VehicleContext context) =>
        {
            var vehicle = new VehicleModel(
            req.id,
            req.nome,
            req.marca,
            req.ano,
            req.potencia,
            req.km,
            req.tipo,
            req.valor,
            req.cor,
            req.cambio );
            await context.AddAsync(vehicle);
            await context.SaveChangesAsync();
        } );

    }
}
/*
            id : 1,
            nome : "Siena",
            marca : "Fiat",
            ano : 2014,
            potencia : 112,
            km : 9000.860f,
            tipo : "Sedan",
            valor : 67000.890f,
            cor : "Preto",
            cambio : false
*/