namespace Estacionamento2.Models
{
    public class Carro
    {
        public string Cor { get; set; }
        public string Placa { get; set; }

        public string Modelo {get;set; }

        public Carro(string Cor, string Placa, string Modelo) 
        { 
            this.Cor = Cor;
            this.Placa = Placa;
            this.Modelo = Modelo;
        
        }

        public Carro() { }
    }
}