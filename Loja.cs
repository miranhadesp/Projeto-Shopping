using System;
using System.Collections.Generic;

namespace projeto1
{
    public class Loja : ILoja
    {
        private int id;
        public int Id
        { // Acesso e modificação da variável id.
            get { return id; }
            set { id = value; }
        }

        private string nomeLoja;
        public string NomeLoja
        { // Acesso e modificação da variável nomeLoja.
            get { return nomeLoja; }
            set { nomeLoja = value; }
        }

        private string segmento;
        public string Segmento
        { // Acesso e modificação da variável segmento.
            get { return segmento; }
            set { segmento = value; }
        }

        private string nomeProduto;
        public string NomeProduto
        { // Acesso e modificação da variável nomeProduto.
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        private double precoProduto;
        public double PrecoProduto
        { // Acesso e modificação da variável precoProduto.
            get { return precoProduto; }
            set { precoProduto = value; }
        }

        Inicio inicio = new Inicio(); // instância de Inicio.
        Produto produto = new Produto(); // instância de Produto.

        public Loja()
        {  // Construtor que não recebe nenhum parâmetro 

        }

        public Loja(int id, string nomeLoja, string segmento)
        { // Construtor que recebe três parâmetros. 

            NomeLoja = nomeLoja;
            Id = id;
            Segmento = segmento;
        }

        public void CadastrarLoja(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens)
        {
            // Método para realiza cadastro de lojas.
            Console.Write("\nDigite o código da loja que quer cadastrar: ");
            Id = Convert.ToInt32(Console.ReadLine());

            // Busca se já existe alguma loja com o Id digitado.
            // Se o Id existir volta para o método CadastrarLoja.
            foreach (ILoja e in lojas)
            {
                if (Id == e.Id)
                {
                    Console.WriteLine("Loja já cadastrada, tente novamente!");
                    CadastrarLoja(lojas, produtos, clientes, passagens);
                }
            }
                
            bool controle = false;
            do{
                Console.Write("Digite o segmento que quer cadastrar (FastFood, SelfService, Loja): ");
                Segmento = Console.ReadLine().ToUpper();

                if(segmento == "FASTFOOD" || segmento == "SELFSERVICE" || segmento == "LOJA"){

                    Console.Write("Digite o nome da loja: ");
                    NomeLoja = Console.ReadLine();

                    lojas.Add(new Loja(Id, NomeLoja, Segmento)); // Adiciona loja na lista de lojas.

                    Console.WriteLine("\nCadastro realizado com sucesso!");

                    produto.CadastrarProdutos(lojas, produtos, clientes, passagens); // Chama o método cadastrar produto.
                    controle = true;
                }
                else
                {
                Console.WriteLine("Segmento inexistente, digite um dos segmentos existentes");
                }
            }while (!controle);
        }

        public void ExibirLojas(List<ILoja> lojas, List<IProduto> produtos)
        { //Método para exibir todas as lojas cadastradas.

            Console.Write("\nLojas encontradas: \n");

            foreach (ILoja e in lojas) //percorrendo lista de lojas cadastradas
            {
                Console.WriteLine($"\nNome: {e.NomeLoja}");

                foreach (IProduto k in produtos) //percorrendo lista de produtos cadastrados
                {
                    if (e.Id == k.CodLojaCadastrada)
                    {
                        Console.WriteLine($"Produtos dentro de {e.NomeLoja}: {k.Nome} {k.Preco}R$"); //exibindo valores encontrados
                    }
                }
            }
        }
    }
}
