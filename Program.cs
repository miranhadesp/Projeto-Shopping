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

            List<IPassagem> passagens = new List<IPassagem>();

            Inicio inicio = new Inicio();
            inicio.Select(fastfood, selfservice, lojas, passagens);
            
            //Instancia parao menu de cadastro
            //List<IProduto> produtosLoja = new List<IProduto>(); // Cria uma lista de IProduto
            //List<IProduto> produtosFast = new List<IProduto>();
            //Menu menu = new Menu(produtosLoja, produtosFast, saldo);
        }
    }
}
