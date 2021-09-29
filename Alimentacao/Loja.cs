using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto1{

    public class Loja : ILoja{

        private int id;
        public int Id {
            get { return id; } 
            set { id = value; }
        }

        private string nome;
        public string Nome{ 
            get{ return nome; } 
            set{ nome = value; }
        }

        // 1 MENU CAD LOJA

        public void MenuLoja(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas ){

            ListaLoja listaLoja = new ListaLoja();
            int opcao;
            Console.WriteLine("\nEscolha uma opção");
            Console.WriteLine("1 - Adicionar lojas");
            Console.WriteLine("2 - Exibir lojas");
            Console.WriteLine("3 - Remover lojas");
            Console.WriteLine("0 - Voltar ao menu");

            Console.Write("Opção: ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            switch(opcao){
                case 1:
                    listaLoja.MontarLista(fastfood, selfservice, lojas);
                    break;
                case 2:
                    listaLoja.ExibeLista(fastfood, selfservice, lojas);
                    break;
                case 3:
                    listaLoja.RemoverItem(fastfood, selfservice, lojas);
                    break;
                case 0:
                    Inicio inicio = new Inicio();
                    inicio.Select(fastfood, selfservice, lojas);
                    break;
            }
        }
    }
}
