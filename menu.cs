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
            Compra compra = new Compra();

            // Menu onde o usuário decide o que fazer
            Console.WriteLine("\nSelecione a opção desejada");
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
                    Console.WriteLine("Obrigado pela visita, volte sempre :)");
                    Environment.Exit(0); // Encerra o programa.
                    break;

                case 1:
                    loja.CadastrarLoja(lojas, produtos, clientes, passagens); //-> Cadastros de lojas passando todas as listas do programa como parâmetro para poder voltar ao menu após definição
                    break;

                case 2:
                    produto.CadastrarProdutos(lojas, produtos, clientes, passagens); //-> Cadastros de prdutos passando todas as listas do programa como parâmetro para poder voltar ao menu após definição
                    break;

                case 3:
                    passagem.CadastrarPassagem(lojas, produtos, clientes, passagens); //-> Cadastros de passagens passando todas as listas do programa como parâmetro para poder voltar ao menu após definição
                    break;

                case 4:
                    int indexCliente = clientes.FindIndex(e => e.Id == 1);

                    //Verifica se existe clientes cadastrados no sistema. 
                    //Se sim, segue para realizar compra compra. 
                    //Se não, segue para cadastrar cliente.

                    if (indexCliente == -1)
                    {
                        Console.WriteLine("\nPercebemos que você não possui cadastro no nosso sistema.");
                        Console.WriteLine("Siga os passas a seguir para continuar :)");

                        cliente.CadastrarCliente(lojas, produtos, clientes, passagens); //-> Cadastros de clientes passando todas as listas do programa como parâmetro para poder voltar ao menu após definição
                    }
                    else compra.RealizarCompra(lojas, produtos, clientes, passagens);  // Realiza compra passando todas as listas do programa como parâmetro para poder voltar ao menu após definição
                    break;

                case 5:
                    loja.ExibirLojas(lojas, produtos); // Exibe todas as lojas e seus respectivos produtos
                    passagem.ExibirPassagem(passagens); // Exibe todas as lojas e passagens cadastradas.

                    Console.Write("\n");

                    MenuGeral(lojas, produtos, clientes, passagens); // Volta ao menu geral.
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente");
                    MenuGeral(lojas, produtos, clientes, passagens);// Volta ao menu geral.
                    break;
            }
        }

    }
}

