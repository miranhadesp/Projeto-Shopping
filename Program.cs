using System;

namespace projeto1{

    class Program{

        static void Main(string[] args){

            Dictionary <int, string> fastfood = new Dictionary <int, string>();
            Dictionary <int, string> selfservice = new Dictionary <int, string>();  
            Inicio inicio = new Inicio();
            inicio.Select(fastfood, selfservice);
    }
}
