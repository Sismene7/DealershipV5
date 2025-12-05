namespace Vehicle.Models;

public record VehicleRequest(
    int id,
    string nome,
    string marca, 
    int ano, 
    int potencia, 
    float km, 
    string tipo, 
    float valor, 
    string cor, 
    bool cambio 
    );
