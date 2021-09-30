using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    class Inicio
    {  
        public void MenuGeral(List<ILoja> lojas, List<ICliente> clientes, List<IPassagem> passagens)
        {

            Loja loja = new Loja();
            Passagem passagem = new Passagem();
            Cliente cliente = new Cliente();

            Console.WriteLine("\nVocê está no menu geral");
            Console.WriteLine("0 - Sair do programa");
            Console.WriteLine("1 - Cadastrar loja");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar cliente");
            Console.WriteLine("4 - Cadastrar passagem");
            Console.WriteLine("5 - Realizar compra");
            Console.WriteLine("6 - Exibir lojas cadastradas");
            Console.Write("Opçao selecionada: ");

            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    loja.CadastrarLoja(lojas, clientes, passagens);
                    break;
                case 2:
                    loja.CadastrarProdutos(lojas, clientes, passagens);
                    break;
                case 3:
                    cliente.CadastrarCliente(lojas, clientes, passagens);
                    break;
                case 4:
                    // Cadastrar Passagem
                     break;
                case 5:
                    //Simular Compra
                        break;
                case 6:
                    //exibir lojas
                    break;
                default:
                    Console.WriteLine("Opção invalida tente novamente seu burrinho");
                    MenuGeral(lojas, clientes, passagens);
                    break;
                }
            }

    }
}

