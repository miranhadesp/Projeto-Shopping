using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    public class Passagem: IPassagem //IPassagem.VenderPassagem?(Thais) - Erro de implementação
    {
        public int I = 1;

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private string classeAeronave;
        public string ClasseAeronave
        {
            get
            {
                return classeAeronave;
            }
            set
            {
                classeAeronave = value;
            }
        }

        private string nomeEmpresa;
        public string NomeEmpresa
        {
            get
            {
                return nomeEmpresa;
            }
            set
            {
                nomeEmpresa = value;
            }
        }

        private double precoPassagem;
        public double PrecoPassagem
        {
            get
            {
                return precoPassagem;
            }
            set
            {
                precoPassagem = value;
            }
        }

        private string destino;
        public string Destino
        {
            get
            {
                return destino;
            }
            set
            {
                destino = value;
            }
        }

        //Criando um construtor

        public Passagem(
            int id,
            string nomeEmpresa,
            double precoPassagem,
            string destino
        )
        {
            Id = id;
            NomeEmpresa = nomeEmpresa;
            PrecoPassagem = precoPassagem;
            Destino = destino;
        }

        //Construtor Vazio para poder instanciar na program
        public Passagem()
        {
        }

        MenuAeroporto menu = new MenuAeroporto();

        public void ExibirCarteira(List<IPassagem> passagens)
        {
            Cliente saldoCliente = new Cliente();
            Console.WriteLine($"\nValor existente na carteira : {saldoCliente.Carteira}");
        }

        public void CadastrarEmpresa(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas, List<IPassagem> passagens)
        {
            bool novamente;

            Console.Write($"\nDigite o nome da {Id + 1}° empresa de passagens que deseja cadastrar:");
            nomeEmpresa = Console.ReadLine(); //Lê nome da empresa

            foreach(IPassagem e in passagens){

                if(nomeEmpresa == e.NomeEmpresa){

                    Console.Write("Empresa já cadastrada, tente novamente.");
                    CadastrarEmpresa(fastfood, selfservice, lojas, passagens);
                }
            }

            //Imprime no console a mensagem abaixo:
            Console.Write("Digite o preço da passagem: ");
            precoPassagem = double.Parse(Console.ReadLine()); //Lê o valor da passagem

            Console.Write("Qual será o destino da viagem? ");
            destino = Console.ReadLine();

            Id++;
                
            //Adiciona na Lista Os valores abaixo.
            passagens.Add(new Passagem(Id, NomeEmpresa, PrecoPassagem, Destino));

            Console.Write("\nAdicionar outra empresa? (S/N) ");
            string simOuNao = Console.ReadLine().ToUpper();

            switch (simOuNao)
            {
                case "S":
                    CadastrarEmpresa(fastfood, selfservice, lojas, passagens);
                    break;

                case "N":
                    menu.MenuDoAeroporto(fastfood, selfservice, lojas, passagens);
                    break;
                    
                default:
                    Console.Write("Opção inválida, digite um valor válido!");
                    CadastrarEmpresa(fastfood, selfservice, lojas, passagens);
                    break;
            }  
        }

        //Metódo para poder exibir as empresas.
        public void ExibirEmpresas(List<IPassagem> passagens)
        {
            Console.WriteLine("\nEmpresas cadastradas: ");
            //Percorremos na Interface IPassagem com a variavel e na lista passagens.
            foreach (IPassagem e in passagens)
            {
                Console.WriteLine(e.NomeEmpresa);
            }
        }

        //Metodo para removerEmpresa
        public void RemoverEmpresa(List<IPassagem> passagens)
        {
            Console.Write("\nDigite o nome da empresa que deseja remover : ");
            string nomeEmpresaRemove = Console.ReadLine();

            /*Criamos uma variavel para atribuir o index da empresa, 
            e fazemos a seguinte verificação, procure em passagens, onde o nome da empresa,
            seja o mesmo que o nome digitado para remover e passe para a variavel o valor do index*/
            int indexEmpresa = passagens.FindIndex(passagens => passagens.NomeEmpresa == nomeEmpresaRemove);

            /*Se o index da empresa for igual a menos 1, a empresa não existe
            e chamamos novamente RemoverEmpresa()*/
            if (indexEmpresa == -1)
            {
                Console.WriteLine("Empresa não encontrada em nosso sistema, tente novamente.");
                RemoverEmpresa(passagens);
            }
            else
            /*Se não, chamamos a função removeAt, que pede um valor inteiro como parametro no caso o index.*/
            {
                passagens.RemoveAt (indexEmpresa);
                Console.WriteLine($"A empresa {nomeEmpresaRemove} foi removida com sucesso!");
            }
        }

        // public boll verifiy(){

        //     //verifica se há um cadastro

        //     //

        //     //se n -> Cadastrar cliente() -> return false

        //     //se sim -> VenderPassagem()
        // }

        //Metódo para vender a passagem.
        public void VenderPassagem(List<IPassagem> passagens)
        {
            //Instanciamos a Classe cliente e atribuimos a variavel passageiro.
            Cliente passageiro = new Cliente();

            //Pedimos para o usuario fazer um cadastro
            Console.WriteLine("Para podermos vender a passagem primeiro necessitamos do seu cadastro: ");
            passageiro.CadastrarCliente(); //Chamamos o metódo de cadastro.
            
            //Exibimos as passagens disponíveis
            Console.WriteLine("Passagens Disponíveis: ");

            //Percorremos na interface IPassagem com a variavel e, em passagens
            foreach (IPassagem e in passagens)
            {
                //Exibimos o Id da passagens encontradas em passagen,destino e o preco.
                Console.WriteLine($"Id: {e.Id}\nDestino - > {e.Destino}\nPreço -> R${e.PrecoPassagem}");

                //Pedimos para o usuario digitar o Id da passagem que deseja comprar.
                Console.WriteLine("Digite o Id da passagem desejada: ");
                int idPassagem = Convert.ToInt32(Console.ReadLine()); //Lemos o id e armazenamos em idPassagem.

                //Criamos uma variavel de saldo atual que recebe o valor da carteira.
                double saldoAtual = passageiro.Carteira;

                //Criamos uma variavel para armazenar o novo saldo, que subtrai o saldo atual do preco.
                double novoSaldo = saldoAtual - precoPassagem;

                //Verificamos se o id da passagem é igual a algum id existendo em IPassagem
                if (idPassagem == e.Id)
                {
                    Console.WriteLine($"\nA Passagem escolhida foi: \nId: {e.Id}\nDestino - > {e.Destino}\nPreço -> R${e.PrecoPassagem}");
                }
                //Verificamos se o Id da passagem é diferente de algum id existente na IPassagem
                else if (idPassagem != e.Id)
                {
                    Console.Write("Passagem não encontrada");
                    Environment.Exit(0);  // -> verificação em classe separada para puxar
                }

                //Verificamos se o saldo atual é maior ou igual o preço da passagem, para podermos comprar.
                if (saldoAtual >= precoPassagem)
                {
                    Console.WriteLine("Compra Realizada com Sucesso!");
                    Console.WriteLine($"Seu novo saldo é: {novoSaldo.ToString("F2")}R$\n");
                }

                //Se não for maior ou igual, o usuario não tem saldo para comprar a passagem.
                else if (saldoAtual < precoPassagem)
                {
                    Console.WriteLine("Saldo Insuficiente, Saque mais dinheiro por favor!");
                    Environment.Exit(0); // -> verificar em classe 
                }

                /*Enquanto o novo saldo for maior ou igual ao valor da passagem, perguntamos se deseja
                comprar outra passagem.*/
                while (novoSaldo >= precoPassagem)
                {
                    Console.WriteLine("Comprar outra passagem? (SIM OU NAO)");
                    string decisao = Console.ReadLine().ToUpper();

                    switch (decisao)
                    {
                        case "SIM":
                            VenderPassagem(passagens);
                            break;
                        case "NAO":
                            Console.WriteLine("Agradecemos a preferência!");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Saindo do programa...");
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}

/*

Console.WriteLine("\nEscolha sua opção: ")
                Console.WriteLine("Para Classe Econômica digite 1");
                Console.WriteLine("Para Classe Executiva digite 2");
                Console.WriteLine("Para Primeira Classe digite 3 ");
                Console.Write("Opção: ");
                int classeViagem = Convert.ToInt32(Console.ReadLine());
                if (classeViagem == 1)
                {
                    Console.WriteLine("Você escolheu a Classe Econômica.");
                }
                else if (classeViagem == 2)
                {
                    Console.WriteLine("Você escolheu a Classe Executiva.");
                }
                else if (classeViagem == 3)
                {
                    Console
                        .WriteLine("Você escolheu viajar de Primeira Classe.");
                    Console
                        .WriteLine("Receberá champagne e chocolates durante a viagem.");
                }

*/
