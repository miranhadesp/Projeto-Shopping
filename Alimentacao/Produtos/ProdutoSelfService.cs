using System;
using System.Collections.Generic;

namespace projeto1 // adaptação para o codigo do projeto.
{
    class SelfServiceAddRem //Rodrigo - cadastrar ou remover produtos de selfservice
    {
        string nome;
        double preco; 

        List<IProduto> produtosSelf;
        public SelfServiceAddRem(List<IProduto> _produtos) // adicionar ou remover
        {
            produtosSelf = _produtos;
        }
        public void CadastrarSelfService() // cadastrar produto
        {
            string idProduto = "";
            double preco = 0;

            do
            {
                Console.Write("Digite um codigo ou decrição de produto para inserir no cardapio de selfservice: "); //Pode ser apenas um numero, ou descricao como Rodizio de Churrasco
                idProduto = Console.ReadLine();

                Console.Write("Digite o preço do quilo para essa opção de serf service: "); // valor do quilo da comida.
                double.TryParse(Console.ReadLine(), out preco);

                produtosSelf.Add(new Produto(idProduto, preco));

                CadastrarOuRemoverMaisProdutos("cadastrar");

            } while (int.Parse(Console.ReadLine()) == 1);
        }
        public void ListarProdutosCadastradosSelf()
        {
            Console.WriteLine("Esses são os produtos cadastrados: ");
            foreach (Produto _produto in produtosSelf)
            {
                Console.WriteLine($"Produto: {_produto.Nome} - Preco: {_produto.Preco} R$ o quilo. ");
            }
        }
        public void RemoverProdutoSelfService()
        {
            string nomeProduto;
            do
            {
                Console.Write("Digite um codigo ou decrição de produto para remove-lo: ");
                nomeProduto = Console.ReadLine();

                int indexProduto = produtosSelf.FindIndex(produto => produto.Nome == nomeProduto);

                if (indexProduto == -1)
                {
                    Console.WriteLine("Produto não encontrado, tente novamente");
                    RemoverProdutoSelfService();
                }
                else
                {
                    produtosSelf.RemoveAt(indexProduto);
                    Console.WriteLine($"Foi removido o produto {nomeProduto} com sucesso");
                }

                CadastrarOuRemoverMaisProdutos("remover");


            } while (int.Parse(Console.ReadLine()) == 1);
        }
        void CadastrarOuRemoverMaisProdutos(string cadastrarRemover)
        {
            ListarProdutosCadastradosSelf();

            Console.WriteLine($"Deseja {cadastrarRemover} mais algum Self Service?");
            Console.WriteLine("0 - Não");
            Console.WriteLine("1 - Sim");
        }
    }
}