using System;
using System.Collections.Generic;

namespace projeto1
{
    class Cadastro
    {
        public void Select()
        {
            Console.WriteLine("\nEscolha sua opção: ");
            Console.WriteLine("1 - Cadastrar loja");
            Console.WriteLine("2 - Cadastrar passagem");
            Console.WriteLine("3 - Cadastrar cliente");
            Console.WriteLine("4 - Simular compra");
            Console.WriteLine("0 - sari do programa");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    // 1 - Cadastrar loja
                    break;
                case 2:
                    // 2 - Cadastrar passagem
                    break;
                case 3:
                    // 3 - Cadastrar cliente
                    break;
                    case 4:
                    // 4 - Simular compra
                    break;
                default:
                    Console
                        .WriteLine("Opção invalida tente novamente seu burrinho");
                    break;
            }
        }
    }
}
