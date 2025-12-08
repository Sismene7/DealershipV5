namespace Motorcycle.Models;

public record MotorcycleRequest(
    int id,
    string nome,
    string marca,
    int ano,
    int potencia,
    float km,
    string tipo,
    float valor,
    string cor,
    int cilindradas,
    int cilindros,
    double torque,
    bool partidaEletrica,
    bool abs
    );
