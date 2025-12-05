namespace Vehicle.Models;

public class VehicleModel
{
    public VehicleModel(int id, string nome, string marca, int ano, int potencia, float km, string tipo, float valor, string cor, bool cambio )
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
        Cambio = cambio;
    }
        public int Id {get; set;}
        public  string Nome {get; set; } 
        public  string Marca {get; set;}
        public int Ano {get; set;}
        public int Potencia {get; set;}
        public float Km {get; set;}
        public string Tipo {get; set;}
        public float Valor {get; set;}
        public string Cor {get; set;}
        public bool Cambio {get; set;}
        

}