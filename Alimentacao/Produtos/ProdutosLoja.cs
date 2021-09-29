using System;
using System.Collections.Generic;

namespace projeto1
{
    class _Loja
    {
        string nome;
        double preco;

        List<IProduto> produtosLoja;
        public _Loja(List<IProduto> _produtos)
        {
            produtosLoja = _produtos;
        }
        public void CadastrarProdutoLoja()
        {
            string nomeProduto = "";
            double preco = 0;

            do
            {
                Console.Write("Nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.Write("Preço do produto: ");
                double.TryParse(Console.ReadLine(), out preco);

                produtosLoja.Add(new Produto(nomeProduto, preco));

                CadastrarOuRemoverMaisProdutos("cadastrar");

            } while (int.Parse(Console.ReadLine()) == 1);
        }
        public void ListarProdutosCadastrados()
        {
            Console.WriteLine("Esses são os produtos cadastrados: ");
            foreach (Produto _produto in produtosLoja)
            {
                Console.WriteLine($"Produto: {_produto.Nome} - Preco: {_produto.Preco}");
            }
        }
        public void RemoverProdutoLoja()
        {
            string nomeProduto;
            do
            {
                Console.Write("Digite o nome do produto que deseja remover: ");
                nomeProduto = Console.ReadLine();

                int indexProduto = produtosLoja.FindIndex(produto => produto.Nome == nomeProduto);

                if(indexProduto == -1)
                {
                   Console.WriteLine("Produto não encontrado, tente novamente");
                    CadastrarOuRemoverMaisProdutos("remover");
                }
                else
                {
                    produtosLoja.RemoveAt(indexProduto);
                    Console.WriteLine($"Foi removido o produto {nomeProduto} com sucesso");
                }
                CadastrarOuRemoverMaisProdutos("remover");


            } while (int.Parse(Console.ReadLine()) == 1);
        }

        void CadastrarOuRemoverMaisProdutos(string cadastrarRemover)
        {
            ListarProdutosCadastrados();

            Console.WriteLine($"Deseja {cadastrarRemover} mais algum produto?");
            Console.WriteLine("0 - Não");
            Console.WriteLine("1 - Sim");
        }


    }
}
