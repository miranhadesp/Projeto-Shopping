using System;
using System.Collections.Generic;

namespace projeto1
{
    class FastFoodCadRem
    {
        string nome;
        double preco;

        List<IProduto> produtosFast;
        public FastFoodCadRem(List<IProduto> _produtos)
        {
            produtosFast = _produtos;
        }
        public void CadastrarProdutoFast()
        {
            string nomeProduto = "";
            double preco = 0;

            do
            {
                Console.Write("Nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.Write("Preço do produto: ");
                double.TryParse(Console.ReadLine(), out preco);

                produtosFast.Add(new Produto(nomeProduto, preco));

                CadastrarOuRemoverMaisProdutosFast("cadastrar");

            } while (int.Parse(Console.ReadLine()) == 1);
        }
        public void ListarProdutosCadastradosFast()
        {
            Console.WriteLine("Esses são os produtos cadastrados: ");
            foreach (Produto _produto in produtosFast)
            {
                Console.WriteLine($"Produto: {_produto.Nome} - Preco: {_produto.Preco}");
            }
        }
        public void RemoverProdutoFast()
        {
            string nomeProduto;
            do
            {
                Console.Write("Digite o nome do produto que deseja remover: ");
                nomeProduto = Console.ReadLine();

                int indexProduto = produtosFast.FindIndex(produto => produto.Nome == nomeProduto);

                if(indexProduto == -1)
                {
                   Console.WriteLine("Produto não encontrado, tente novamente");
                    CadastrarOuRemoverMaisProdutosFast("remover");
                }
                else
                {
                    produtosFast.RemoveAt(indexProduto);
                    Console.WriteLine($"Foi removido o produto {nomeProduto} com sucesso");
                }

                CadastrarOuRemoverMaisProdutosFast("remover");


            } while (int.Parse(Console.ReadLine()) == 1);
        }

        void CadastrarOuRemoverMaisProdutosFast(string cadastrarRemover)
        {
            ListarProdutosCadastradosFast();

            Console.WriteLine($"Deseja {cadastrarRemover} mais algum produto?");
            Console.WriteLine("0 - Não");
            Console.WriteLine("1 - Sim");
        }
    }
}
