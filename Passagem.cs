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
            get { return destinoPassagem; }
            set { destinoPassagem = value; }
        }

        Inicio inicio = new Inicio();

        public Passagem()
        { // Construtor que não recebe parâmetros.

        }

        public Passagem(int idPassagem, string nomePassagem, double precoPassagem, string destinoPassagem)
        { // Construtor que recebe três parâmetros e atualiza as variavis da classe
            IdPassagem = idPassagem;
            empresaPassagem = nomePassagem;
            PrecoPassagem = precoPassagem;
            DestinoPassagem = destinoPassagem;
        }

        public void CadastrarPassagem(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens)
        {
            //Metodo para castrar passagens.
            Console.Write("\nDigite o código da passagem: ");
            IdPassagem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome da empresa da passagem: ");
            EmpresaPassagem = Console.ReadLine();

            Console.Write("Digite o preco da passagem : R$ ");
            PrecoPassagem = Double.Parse(Console.ReadLine());

            Console.Write("Digite o destino da passagem : ");
            DestinoPassagem = Console.ReadLine();

            passagens.Add(new Passagem(IdPassagem, EmpresaPassagem, PrecoPassagem, DestinoPassagem)); //adicionando passagem na lista "passagens"

            Console.WriteLine("\nCadastro realizado com sucesso!");

            inicio.MenuGeral(lojas, produtos, clientes, passagens);
        }

        public void ExibirPassagem(List<IPassagem> passagens)
        {
            //Metodo para exibir as passagens que estão disponíveis
            int i = 1;

            Console.WriteLine("\nPassagens cadastradas:");

            foreach (IPassagem e in passagens)
            {
                Console.Write($"\n{i}) Id : {e.IdPassagem}\nNome da empresa: {e.EmpresaPassagem}\nPreço : {e.PrecoPassagem}R$\nDestino: {e.DestinoPassagem}");
                i++; //exibibindo a passagem i cadastrada
            }
        }

        public void VenderPassagem(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens)
        {
            //Metodo de venda de passagem, que eventualmente faz uma verificação do id digitado, com o id da passagem.
            if (passagens.Count == 0)
            {
                Console.WriteLine("\nCadastre uma passagem primeiro!");
                inicio.MenuGeral(lojas, produtos, clientes, passagens);
            }

            bool encontrar = false; //setando uma verificação com bool
            string destino = " ";
            double valor = 0;

            ExibirPassagem(passagens);

            Console.Write("\n\nDigite o Id da passagem desejada: ");
            int idPassagemVenda = Int32.Parse(Console.ReadLine());


            foreach (IPassagem e in passagens)
            {
                if (idPassagemVenda == e.IdPassagem)
                {
                    destino = e.DestinoPassagem; //colocando valor destino em uma variável para exibir sem necessidade de foreach 
                    valor = e.PrecoPassagem; //colocando o valor de preço em uma variavel
                    encontrar = true; //se encontrou alguma passagem com esse id, passou da verificação
                    break;
                }
            }

            if (encontrar)
            {
                Console.Write("Digite a quantidade de bagagem a ser registrada: "); //registro de bagagem
                int qtdBagagem = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"Venda da passagem com destino para {destino} no valor de {valor}R$ realizada com sucesso!"); //exibição de destino 
                Console.WriteLine($"A quantidade de bagagem registrada foi: {qtdBagagem}"); //exibindo bagagens registradas

                inicio.MenuGeral(lojas, produtos, clientes, passagens);
            }
            else
            {
                Console.WriteLine("Id não encontrado, tente novamente.");
                VenderPassagem(lojas, produtos, clientes, passagens);
            }
        }
    }
}