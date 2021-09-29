using System;
using System.Collections.Generic;

namespace projeto1
{
    class MenuAeroporto
    {
        public void MenuDoAeroporto(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas, List<IPassagem> passagens)
        {

            Inicio menu = new Inicio();
            Passagem passagem = new Passagem();

            Console.WriteLine("\n Escolha uma opção ");
            Console.WriteLine("1 - Cadastrar Empresa");
            Console.WriteLine("2 - Exibir Empresa");
            Console.WriteLine("3 - Remover Empresa");
            Console.WriteLine("4 - Vender passagem");
            Console.WriteLine("0 - Voltar ao menu inicial");
            Console.Write("Opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            // List<IPassagem> passagens = new List<IPassagem>();

            switch (opcao)
            {
                case 1:
                    passagem.CadastrarEmpresa(fastfood, selfservice, lojas, passagens);
                    break;
                case 2:
                    passagem.ExibirEmpresas(passagens);
                    MenuDoAeroporto(fastfood, selfservice, lojas, passagens);
                    break;
                case 3:
                    passagem.RemoverEmpresa(passagens);
                    break;
                case 4:
                    passagem.VenderPassagem(passagens);
                    break;
                case 0:
                    menu.Select(fastfood, selfservice, lojas, passagens);
                    break;
                default:
                    Console.WriteLine("Saindo do programa.");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
