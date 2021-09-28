using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1{

    class Inicio{
        public void Select(Dictionary <int, string> fastfood , Dictionary <int, string> selfservice,  Dictionary <int, string> lojas){
            int n;

            Console.WriteLine("\nEscolha o segmento desejado");
            Console.WriteLine("1 - FastFood");
            Console.WriteLine("2 - Selfservice");
            Console.WriteLine("3 - Lojas");
            Int32.TryParse(Console.ReadLine(), out n);

            switch(n){
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

            }
        }
    }
}
