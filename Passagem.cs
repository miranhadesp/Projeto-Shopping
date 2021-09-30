using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    public class Passagem : IPassagem
    {
        private int idPassagem;
        public int IdPassagem
        {
            get { return idPassagem; }
            set { idPassagem = value; }
        }

        private string empresaPassagem;
        public string EmpresaPassagem
        {
            get { return empresaPassagem; }
            set { empresaPassagem = value; }
        }

        private double precoPassagem;
        public double PrecoPassagem
        {
            get { return precoPassagem; }
            set { precoPassagem = value; }
        }
        
        private string destinoPassagem;
        public string DestinoPassagem
        {
            get {return destinoPassagem;}
            set {destinoPassagem = value; } 
        }

        Inicio inicio = new Inicio();

        public Passagem()//Construtor vazio para futura instancia no program
        {

        }

        public Passagem(int idPassagem, string nomePassagem, double precoPassagem, string destinoPassagem)
        { //Construtores recebendo os 4 parametros, para poder adicionar mais de 1 valor na lista.
            IdPassagem = idPassagem;
            empresaPassagem = nomePassagem;
            PrecoPassagem = precoPassagem;
            DestinoPassagem = destinoPassagem;
        }
        
        public void CadastrarPassagem(List<ILoja> lojas, List<ICliente> clientes, List<IPassagem> passagens)
        { //Metodo para cadastrar as passagens.

            Console.Write("\nDigite o nome da passagem: ");
            empresaPassagem = Console.ReadLine();

            Console.Write("Digite o preco da passagem : R$ ");
            precoPassagem = Double.Parse(Console.ReadLine());

            Console.Write("Digite o destino da passagem : ");
            destinoPassagem = Console.ReadLine();

            passagens.Add(new Passagem(IdPassagem, empresaPassagem, precoPassagem, destinoPassagem));

            inicio.MenuGeral(lojas, clientes, passagens);
        }

        public void ExibirPassagem(List<ILoja> lojas, List<ICliente> clientes, List<IPassagem> passagens)
        { //Metodo para exibir as passagens que estão disponíveis 
            Console.WriteLine("Passagens Disponíveis encontradas :");

            foreach (IPassagem e in passagens)
            {
                Console.Write($"Id : {e.IdPassagem}, Nome : {e.EmpresaPassagem}, Preço : R${e.PrecoPassagem}, Destino: {e.DestinoPassagem}, ");
            }
        }

        public void VenderPassagem(List<ILoja> lojas, List<ICliente> clientes, List<IPassagem> passagens)
        { //Metodo de venda de passagem, que eventualmente faz uma verificação do id digitado, com o id da passagem.
            
            Cliente nomePassageiro = new Cliente();

            Console.WriteLine($"Olá {nomePassageiro.NomeCliente}");
            Console.WriteLine("Digite o Id da passagem desejada : ");
            int idPassagemVenda = Int32.Parse(Console.ReadLine());

            foreach (IPassagem e in passagens)
            {
                if (idPassagemVenda == e.IdPassagem){
                    
                    Console.Write("Digite a quantidade de bagagem a ser registrada: ");
                    int qtdBagagem = Int32.Parse(Console.ReadLine());
                    
                    Console.WriteLine($"Venda da passagem com destino para {e.DestinoPassagem} realizada com sucesso!");
                    Console.WriteLine($"A quantidade de bagagem registrada foi: {qtdBagagem}");
                }
            }

            Console.WriteLine("Id não encontrado, tente novamente.");
            VenderPassagem(lojas, clientes, passagens);
        }
        
    }
}