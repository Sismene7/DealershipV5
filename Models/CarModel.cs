using Vehicle.Models;

namespace Car.Models;


public class CarModel : VehicleModel
{
    public CarModel(
        int id, 
        string nome, 
        string marca, 
        int ano, 
        int potencia, 
        float km, 
        string tipo, 
        float valor, 
        string cor, 
        int numeroDePortas, 
        TipoCombustivel combustivel, 
        TipoTransmissao transmissao
    )
        // Chamada à classe base (VehicleModel)
        : base(id, nome, marca, ano, potencia, km, tipo, valor, cor, combustivel, transmissao)
    {
        NumeroDePortas = numeroDePortas; 
    }
    
    // Propriedades específicas de CarModel
    public int NumeroDePortas { get; set; }
}