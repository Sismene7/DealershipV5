using Vehicle.Models;

namespace Car.Models;
public record CarRequest(
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
    
);
 