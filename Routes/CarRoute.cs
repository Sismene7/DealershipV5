using Dealership.Data;
using Car.Models;
using Vehicle.Models;

namespace Car.Routes;

public static class CarRoute
{
    public static void CarRoutes(this WebApplication app)
    {
        var route = app.MapGroup(prefix:"Car");

        route.MapPost(pattern:"",
        async (CarContext context, CarRequest req) =>
        {
    var car = new CarModel(
            req.id,
            req.nome,
            req.marca,
            req.ano,
            req.potencia,
            req.km,
            req.tipo,
            req.valor,
            req.cor,
            req.numeroDePortas,
            (TipoCombustivel)req.combustivel,
            (TipoTransmissao)req.transmissao);
            await context.AddAsync(car);
            await context.SaveChangesAsync();
        } );

    }
}
