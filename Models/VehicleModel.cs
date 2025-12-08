namespace Vehicle.Models;
public abstract class VehicleModel
{
    public VehicleModel
    (
        int id, 
        string nome, 
        string marca, 
        int ano, 
        int potencia, 
        float km, 
        string tipo, 
        float valor, 
        string cor, 
        TipoCombustivel combustivel,
        TipoTransmissao transmissao
    ) 
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
        Combustivel = combustivel;
        Transmissao = transmissao;
    }
//Tipocombustivel = TipoCombustivel; 
//public TipoCombustivel Tipocombustivel { get; set; }
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }
    public int Potencia { get; set; }
    public float Km { get; set; }
    public string Tipo { get; set; }
    public float Valor { get; set; }
    public string Cor { get; set; }
    public TipoCombustivel Combustivel { get; set; }
    public TipoTransmissao  Transmissao { get; set; }
}
public enum TipoCombustivel
{
    Gasolina,
    Diesel,
    Etanol,
    Flex,
    Eletrico,
    Hibrido
}
public enum TipoTransmissao
{
    Manual,
    Automatico,
    SemiAutomatico,
    DuplaEmbreagem

}