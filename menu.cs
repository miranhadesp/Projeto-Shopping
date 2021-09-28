using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testess
{
    class Inicio{
        public void Select(Dictionary <int, string> fastfood , Dictionary <int, string> selfservice){
            int n;
            Console.WriteLine("1 - FastFood");
            Console.WriteLine("2 - selfservice");
            Console.Write("n: ");
            Int32.TryParse(Console.ReadLine(), out n);

            switch(n){
                case 1:
                    FastFood fast = new FastFood();
                    fast.Menu1(fastfood, selfservice);
                    break;
                case 2:
                    SelfService self = new SelfService();
                    self.Menu2(selfservice, fastfood);
                    break;
                    

            }
        }
    }
}
