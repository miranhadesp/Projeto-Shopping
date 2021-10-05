using System;
using System.Collections.Generic;

namespace projeto1
{
    public class Produto : IProduto // Produtos está herdando de IProduto
    {

        private int codLojaCadastrada;
        public int CodLojaCadastrada
        { // Acesso e modificação da variável codLojaCadastrada.
            get { return codLojaCadastrada; }
            set { codLojaCadastrada = value; }
        }

        private string nome;
        public string Nome
        { // Acesso e modificação da variável nome.
            get { return nome; }
            set { nome = value; }
        }

        private double preco;
        public double Preco
        { // Acesso e modificação da variável preco.
            get { return preco; }
            set { preco = value; }
        }

        Inicio inicio = new Inicio(); // instância de Inicio.
        // Loja loja; // instância de Loja.

        public Produto()
        { // Construtor que não recebe parâmetros. 
            
        }

        public Produto(string nome, int codloja, double preco)
        { // Construtor que recebe três parâmetros. 
            Nome = nome;
            CodLojaCadastrada = codloja;
            Preco = preco;
        }

        public void CadastrarProdutos(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens)
        { // Método para realiza cadastro de produtos.

            if (lojas.Count == 0)
            {
                Loja loja = new Loja();
                Console.WriteLine("Cadastre uma loja primeiro!");
                loja.CadastrarLoja(lojas, produtos, clientes, passagens);
                // inicio.MenuGeral(lojas, produtos, clientes, passagens);
            }
            else
            {
                bool encontrou = false;
                int valorIgual = 0;

                Console.Write("\nDigite o código da loja que você quer cadastrar um produto: ");
                CodLojaCadastrada = Convert.ToInt32(Console.ReadLine()); 
                
                foreach (ILoja e in lojas) //Percorre por todas as lojas cadastradas.
                {
                    if (CodLojaCadastrada == e.Id)
                    {
                        encontrou = true;
                        valorIgual = e.Id;
                        break;
                    }
                }

                if (encontrou)
                {
                    Console.Write("\nQual produto deseja cadastrar? ");
                    Nome = Console.ReadLine();

                    Console.Write("Digite o valor desse produto: ");
                    Preco = Convert.ToDouble(Console.ReadLine());

                    produtos.Add(new Produto(Nome, CodLojaCadastrada, Preco)); // Adiciona produto na lista de produtos.

                    inicio.MenuGeral(lojas, produtos, clientes, passagens);
                }
                else
                {
                    Console.Write("\nLoja não encontrada, tente novamente.");
                    CadastrarProdutos(lojas, produtos, clientes, passagens);
                }

                Console.Write("Deseja cadastrar outro produto? (S/N)");

                switch (Console.ReadLine().ToUpper())
                { //verificação s eo cliente deseja cadastrar outro produto

                    case "S":
                        CadastrarProdutos(lojas, produtos, clientes, passagens);
                        break;

                    case "N":
                        inicio.MenuGeral(lojas, produtos, clientes, passagens);
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida, voltando ao menu...");
                        inicio.MenuGeral(lojas, produtos, clientes, passagens);
                        break;
                }
            }
        }
    }
}
