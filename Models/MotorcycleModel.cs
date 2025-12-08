namespace Motorcycle.Models;

public class MotorcycleModel
{
    public MotorcycleModel(
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
        bool abs)
    {
        Id = id;
        Nome = nome;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
        Km = km;
        Tipo = tipo;
        Valor = valor;
        Cor = cor;
        Cilindradas = cilindradas;
        Cilindros = cilindros;
        Torque = torque;
        PartidaEletrica = partidaEletrica;
        Abs = abs;
    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }
    public int Potencia { get; set; }
    public float Km { get; set; }
    public string Tipo { get; set; }
    public float Valor { get; set; }
    public string Cor { get; set; }
    public int Cilindradas { get; set; }
    public int Cilindros { get; set; }
    public double Torque { get; set; }
    public bool PartidaEletrica { get; set; }
    public bool Abs { get; set; }


}