using System;
using System.Collections.Generic;

namespace Cadastrar_e_remover_produtos_FastFood
{
    class Menu
    {
        public Menu(List<IProduto> produtosFast, List<IProduto> produtosLoja, double saldo)
        {
            _Loja _loja = new _Loja(produtosLoja); // Cria a variavel fastFoodCadRem do tipo FastFoodCadRem e Adiciona a lista produto

            FastFoodCadRem fastFoodCadRem = new FastFoodCadRem(produtosFast);

            menuGeral();

            void menuProdutosLoja()
            {
                Console.WriteLine("Você está no menu de produtos");
                Console.WriteLine("0 - Voltar para o meu geral");
                Console.WriteLine("1 - Listar Produtos Cadastrados");
                Console.WriteLine("2 - Cadastrar Produto Loja");
                Console.WriteLine("3 - Remover Produto Loja");
                Console.WriteLine("4 - Iniciar compra");
                Console.Write("Opçao selecionada: ");

                switch (int.Parse(Console.ReadLine()))
                {       //se valor digitado for 1 entrar em ListarProdutosCadastrados
                        //se valor digitado for 2 entrar em CadastrarProdutoFastFood
                        //se valor digitado for 3 entrar em RemoverProdutoFastFood
                        //se valor digitado for 0 voltar para o meu geral

                    case 0:
                        menuGeral(); // Vai para o meu geral
                        break;
                    case 1:
                        _loja.ListarProdutosCadastrados(); // Chama o método ListarProdutosCadastrados da classe FastFoodCadRem
                        menuProdutosLoja();
                        break;
                    case 2:
                        _loja.CadastrarProdutoLoja(); // Chama o método CadastrarProdutoFastFood da classe FastFoodCadRem
                        menuProdutosLoja();
                        break;
                    case 3:
                        _loja.RemoverProdutoLoja(); // Chama o método RemoverProdutoFastFood da classe FastFoodCadRem
                        menuProdutosLoja();
                        break;
                    case 4:
                        Console.WriteLine("Não tá pronto ainda");
                        break;
                    default:
                        Console.WriteLine("Opção invalida tente novamente seu burrinho");
                        menuProdutosLoja();
                        break;
                }
            }

            void menuProdutosFast()
            {
                Console.WriteLine("Você está no menu de produtos FastFood");
                Console.WriteLine("0 - Voltar para o meu geral");
                Console.WriteLine("1 - Listar Produtos Cadastrados");
                Console.WriteLine("2 - Cadastrar Produto FastFood");
                Console.WriteLine("3 - Remover Produto FastFoods");
                Console.WriteLine("4 - Iniciar compra");
                Console.Write("Opçao selecionada: ");

                switch (int.Parse(Console.ReadLine()))
                {       //se valor digitado for 1 entrar em ListarProdutosCadastrados
                        //se valor digitado for 2 entrar em CadastrarProdutoFastFood
                        //se valor digitado for 3 entrar em RemoverProdutoFastFood
                        //se valor digitado for 0 voltar para o meu geral

                    case 0:
                        menuGeral(); // Vai para o meu geral
                        break;
                    case 1:
                        fastFoodCadRem.ListarProdutosCadastradosFast(); // Chama o método ListarProdutosCadastrados da classe FastFoodCadRem
                        menuProdutosFast();
                        break;
                    case 2:
                        fastFoodCadRem.CadastrarProdutoFast(); // Chama o método CadastrarProdutoFastFood da classe FastFoodCadRem
                        menuProdutosFast();
                        break;
                    case 3:
                        fastFoodCadRem.RemoverProdutoFast(); // Chama o método RemoverProdutoFastFood da classe FastFoodCadRem
                        menuProdutosFast();
                        break;
                    case 4:
                        Console.WriteLine("Não tá pronto ainda");
                        break;
                    default:
                        Console.WriteLine("Opção invalida tente novamente seu burrinho");
                        menuProdutosFast();
                        break;
                }
            }
            void menuGeral()
            {
                Console.WriteLine("Você está no menu e compras");
                Console.WriteLine("0 - Voltar para o cadastro de lojas");
                Console.WriteLine("1 - Menu de produtos fastfood");
                Console.WriteLine("2 - Menu dos preços selfservice");
                Console.WriteLine("3 - Menu dos produtos de loja");
                Console.WriteLine("4 - Iniciar compras!");

                Console.Write("Opçao selecionada: ");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        menuProdutosFast();
                        break;
                    case 2:
                        Console.WriteLine("Não tá pronto ainda meu rei");
                        break;
                    case 3:
                        menuProdutosLoja();
                        break;
                    case 4:
                        Console.WriteLine("Não tá pronto ainda meu rei");
                        break;
                    default:
                        Console.WriteLine("Opção invalida tente novamente seu burrinho");
                        menuGeral();
                        break;
                }

            }
        }
    }
}

