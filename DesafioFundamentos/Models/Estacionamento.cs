using Microsoft.Win32.SafeHandles;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //Valor obtido através do console foi armazenado na variável placaVeiculo
            string placaVeiculo;
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placaVeiculo = Console.ReadLine();
            //Adicionando na lista "veiculos" o valor armazenado na variável "placaVeiculo"
            veiculos.Add(placaVeiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            //variável placa declarada para armazenar o valor
            string placa = Console.ReadLine();
    

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                //declarada a variável "horas" e convertido o valor adicionado no console para int
                int horas = Convert.ToInt32(Console.ReadLine());
            
                
                decimal valorTotal = 0;
                //calculo realizado para obter o valor total a ser pago
                valorTotal = precoInicial + precoPorHora * horas;
                
                
                //Aqui conferiu o valor adicionado na variável "placa" e através do metodo "Remove" removeu aquele valor armazenado na lista
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                //laço criado para mostrar os valores armazenados na lista
                foreach (string valor in veiculos)
                {
                    Console.WriteLine(valor);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
