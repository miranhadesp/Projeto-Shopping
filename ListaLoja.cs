using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1{

    public class ListaLoja{

        public void MontarLista(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas){

            Loja loja = new Loja();
            int chaveRes;
            string valorRes;

            Console.Write("ID da loja: ");
            Int32.TryParse(Console.ReadLine(), out chaveRes);

            Console.Write("Nome da loja: ");
            valorRes = Console.ReadLine();

            lojas.Add(chaveRes, valorRes);
            loja.MenuLoja(fastfood, selfservice, lojas);
        }

        public void  RemoverItem(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas){

            Loja loja = new Loja();
            int id;

            Console.Write("Digite o ID da loja: ");
            Int32.TryParse(Console.ReadLine(), out id);

            foreach(KeyValuePair <int, string> v in lojas){
                if(id == v.Key){
                    fastfood.Remove(id);
                }
            }
            loja.MenuLoja(fastfood, selfservice, lojas);
        }
        
        public void ExibeLista(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas){  

            Loja loja = new Loja();   

            foreach(KeyValuePair <int, string> v in lojas){
                Console.WriteLine($"ID da loja: {v.Key}, nome da loja: {v.Value}");
            }

            loja.MenuLoja(fastfood, selfservice, lojas);
        }
    
    }
}
