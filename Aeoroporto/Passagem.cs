using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto1{

    public class Passagem : IPassagem //IPassagem.VenderPassagem?(Thais) - Erro de implementação
    {

        private int id;
        public int Id{
            get{ return id; }
            set{ id = value; }
        }

        private string classeAeronave;
        public string ClasseAeronave
        {
            get { return classeAeronave; }
            set { classeAeronave = value; }
        }
        
        private string nomeEmpresa;
        public string NomeEmpresa{
            get{ return nomeEmpresa; }
            set{ nomeEmpresa = value; }
        }

        private double precoPassagem;
        public double PrecoPassagem{
            get{ return precoPassagem; }
            set{ precoPassagem = value; }
        }

        private string destino;
        public string Destino{
            get{ return destino; }
            set{ destino = value; }
        }

        //Criando uma lista do tipo Interface Ipassagem
        List<IPassagem> passagens = new List<IPassagem>();


        //Criando um construtor 
        private Passagem(
            string nomeEmpresa,
            double precoPassagem,
            string destino
        )
        {
            NomeEmpresa = nomeEmpresa;
            PrecoPassagem = precoPassagem;
            Destino = destino;
        }

        //Construtor Vazio para poder instanciar na program
        public Passagem()
        {
        }


        public void CadastrarEmpresa()
        {

            //Recebe uma variavel do tipo inteiro.
            int numeroDeEmpresas;

            //Imprime no console quantas empresas de passagens serão cadastradas.
            Console.WriteLine("Digite o numero de empresas que deseja cadastrar: ");

            //Lê e atribui para a variavel numeroDeEmpresas
            numeroDeEmpresas = Int32.Parse(Console.ReadLine());

            /*Cria um for onde i começa com um e Verifica, se o i for menor que o numerodeempresas
            para cadastrar, ele continua no looping, senão cai fora*/
            for (int i = 1; i <= numeroDeEmpresas; i++)
            {
                //Imprime no console a mensagem abaixo:
                Console.WriteLine($"Digite o nome da {i}° empresa de passagens que deseja cadastrar :");

                //Lê o nome da empresa.
                nomeEmpresa = Console.ReadLine();

                //Imprime no console a mensagem abaixo:
                Console.WriteLine("Digite o preço da passagem: ");

                //Lê o valor da passagem
                precoPassagem = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual será o destino da viagem: ");

                destino = Console.ReadLine();

                //Adiciona na Lista Os valores abaixo.
                passagens.Add(new Passagem(NomeEmpresa,PrecoPassagem,Destino));
            }

        }
        //Metódo para poder exibir as empresas.
        public void ExibirEmpresas()
        {
            //Percorremos na Interface IPassagem com a variavel e na lista passagens.
            foreach (IPassagem e in passagens)
            {
                Console.WriteLine($"Empresas cadastradas: {e.NomeEmpresa}");
            }
        }

        //Metodo para removerEmpresa
        public void RemoverEmpresa()
        {
            
            Console.WriteLine("Digite o nome da empresa que deseja remover : ");
            string nomeEmpresaRemove = Console.ReadLine();

            /*Criamos uma variavel para atribuir o index da empresa, 
            e fazemos a seguinte verificação, procure em passagens, onde o nome da empresa,
            seja o mesmo que o nome digitado para remover e passe para a variavel o valor do index*/
            int indexEmpresa = passagens.FindIndex(passagens =>passagens.NomeEmpresa == nomeEmpresaRemove);

            /*Se o index da empresa for igual a menos 1, a empresa não existe
            e chamamos novamente RemoverEmpresa()*/
            if (indexEmpresa == -1)
            {
                Console.WriteLine("Empresa não encontrada em nosso sistema, tente novamente.");
                RemoverEmpresa();
            }

            /*Se não, chamamos a função removeAt, que pede um valor inteiro como parametro no caso o index.*/
            else
            {
                passagens.RemoveAt (indexEmpresa);
                Console.WriteLine($"A empresa {NomeEmpresa} foi removida com sucesso!");
            }
        }

        //Metódo para vender a passagem.
        public void VenderPassagem()
        {
            
            Console.WriteLine("Passagens Disponíveis: ");

            foreach (IPassagem e in passagens)
            {
                Console.WriteLine($"{e.Id} -> {e.Destino} : {e.PrecoPassagem}");
            }

            
            //Criamos uma nova instancia de Cliente.
            Cliente saldoCliente = new Cliente();

            //Chamamos a função de saldo da carteira, que esta na class cliente
            saldoCliente.CadastrarCliente();

            /*Criamos uma nova variavel do saldo do cliente, que atribui o valor que esta na carteira
            - o preco da passagem. */
            double novoSaldo = saldoCliente.Carteira - precoPassagem;

            /*Se o saldo da carteira for maior ou igual o preço da passagem a compra é debitada
            e passamos o novo saldo pro usuario*/
            if (saldoCliente.Carteira >= precoPassagem)
            {
                Console.WriteLine("Compra Realizada com sucesso!");
                Console.Write($"Seu novo saldo é {novoSaldo.ToString("F2")}");
            }

            //Se não, pedimos para ele ir buscar mais dinheiro em casa.
            else
            {
                Console.WriteLine("Vá para casa conseguir mais dinheiro.");
                Environment.Exit(0);
            }
        }

        // public void EscolherClasse()
        // {
        //     string[] tipo = new string["Pobre", "Média", "Rica"];

        //     // Console.WriteLine("Digite ")            
     
    }
}