using Vehicle.Models;

namespace Vehicle.Routes;

public static class VehicleRoute
{
    public static void VehicleRoutes(this WebApplication app)
    {
        app.MapGet(pattern:"Vehicle", () => new VehicleModel(
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
        ));

    }
}