using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1{

    class Inicio{
        public void Select(Dictionary <int, string> fastfood , Dictionary <int, string> selfservice,  Dictionary <int, string> lojas){
            int opcao;

            Console.WriteLine("\nEscolha o segmento desejado");
            Console.WriteLine("1 - FastFood");
            Console.WriteLine("2 - Selfservice");
            Console.WriteLine("3 - Lojas");
            Console.WriteLine("4 - Aeroporto");
            Console.WriteLine("0 - Sair do programa");
            Int32.TryParse(Console.ReadLine(), out opcao);

            switch(opcao){
                case 1:
                    FastFood fast = new FastFood();
                    fast.MenuFastFood(fastfood, selfservice, lojas);
                    break;
                case 2:
                    SelfService self = new SelfService();
                    self.MenuSelfService(fastfood, selfservice, lojas);
                    break;
                case 3:
                    Loja loja = new Loja();
                    loja.MenuLoja(fastfood, selfservice, lojas);
                    break;
                case 4:
                    Passagem passagem = new Passagem();
                    passagem.CadastrarEmpresa();
                    passagem.ExibirEmpresas();
                    // passagem.RemoverEmpresa();
                    passagem.VenderPassagem();
                    break;
                case 0:
                    Console.WriteLine("Obrigado pela visita, volte sempre! :)");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
