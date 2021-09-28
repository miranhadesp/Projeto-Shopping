using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto1{

    class Program{

        static void Main(string[] args){

            Dictionary <int, string> fastfood = new Dictionary <int, string>();
            Dictionary <int, string> selfservice = new Dictionary <int, string>();  
            Dictionary <int, string> lojas = new Dictionary <int, string>();   
            Inicio inicio = new Inicio();
            inicio.Select(fastfood, selfservice, lojas);
        }
    }
}
