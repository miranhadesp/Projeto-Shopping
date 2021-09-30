using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    class Inicio
    {  
        public void MenuGeral(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens)
        {

            Loja loja = new Loja();
            Produto produto = new Produto();
            Passagem passagem = new Passagem();
            Cliente cliente = new Cliente();

            Console.WriteLine("\nSelecione a opção desjeada"); //-> mudança na ordem das opções 
            Console.WriteLine("1 - Cadastrar loja");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar passagem");
            Console.WriteLine("4 - Realizar compra");
            Console.WriteLine("5 - Exibir lojas e passagens cadastradas");
            Console.WriteLine("0 - Sair do programa");
            Console.Write("\nOpçao selecionada: ");

            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    Environment.Exit(0);
                    break;

                case 1:
                    loja.CadastrarLoja(lojas, produtos, clientes, passagens); //-> cadastros passando todas as listas do programa como parâmetro para poder voltar ao menu após definição
                    break;

                case 2:
                    produto.CadastrarProdutos(lojas, produtos, clientes, passagens); //-> cadastros passando todas as listas do programa como parâmetro para poder voltar ao menu após definição
                    break;

                case 3:
                    passagem.CadastrarPassagem(lojas, produtos, clientes, passagens); //-> cadastros passando todas as listas do programa como parâmetro para poder voltar ao menu após definição
                    break;

                case 4:
                    cliente.CadastrarCliente(lojas, produtos, clientes, passagens); //-> cadastros passando todas as listas do programa como parâmetro para poder voltar ao menu após definição
                    break;

                case 5: //-> exibir tudo e chamar o menu direto após
                    loja.ExibirLojas(lojas); 
                    passagem.ExibirPassagem(passagens); 

                    Console.Write("\n");

                    MenuGeral(lojas, produtos, clientes, passagens);
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente seu burrinho");
                    MenuGeral(lojas, produtos, clientes, passagens);
                    break;
                    
                }
            }

    }
}

