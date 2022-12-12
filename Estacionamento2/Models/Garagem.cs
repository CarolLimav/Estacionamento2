using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento2.Models
{
    internal class Garagem
    {
        private decimal PrecoFixo { get; } = 9;
        private decimal PrecoPorHora { get; } = 12;
        private List<Carro> Carros  = new List<Carro>();

        public Garagem()
        {
            
        }

        public void AdicionarVeiculo()
        {
            //armazenando a placa
            Console.WriteLine("Digite a placa do carro:");
           string  PlacaCarro = Console.ReadLine();
            Console.WriteLine("qual o modelo do carro?");
            string ModeloCarro= Console.ReadLine();
            Console.WriteLine("Qual a cor do carro:");
            string CorCarro = Console.ReadLine();


            Carro novoCarro = new Carro(CorCarro,PlacaCarro,ModeloCarro);
            Carros.Add(novoCarro);
            Console.WriteLine("o carro sera adicionado!");

        }
        
        public void RemoverVeiculo()
        {
        //pedindo a placa p/remover
            Console.WriteLine("qual a placa do carro que deseja remover?");
            string PlacaCarro= Console.ReadLine();  
          //procurar o carro com a placa digitada
          foreach(var carro in Carros)
            {
                if(carro.Placa== PlacaCarro)
                {
                    Carros.Remove(carro);
                    break;
               
                }
            }
            Console.WriteLine("O carro foi removido com sucesso!");
        }
        // listagem de veiculos 
        
        public void ListarVeiculo()
        {
            foreach(var carro in Carros)
            {
                Console.WriteLine("Placa:"+carro.Placa);
                Console.WriteLine("Modelo:"+carro.Modelo);
                Console.WriteLine("Cor:"+carro.Cor);
            }
        }
    }
}
