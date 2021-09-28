using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1{

    public class ListaFast{

        public void MontarLista(Dictionary <int, string> fastfood , Dictionary <int, string> selfservice,  Dictionary <int, string> lojas){

            FastFood fast = new FastFood();
            int chaveRes;
            string valorRes;

            Console.Write("ID do restaurante: ");
            Int32.TryParse(Console.ReadLine(), out chaveRes);

            Console.Write("Nome do restaurante: ");
            valorRes = Console.ReadLine();

            fastfood.Add(chaveRes, valorRes);
            fast.MenuFastFood(fastfood, selfservice, lojas);
        }

        public void  RemoverItem(Dictionary <int, string> fastfood , Dictionary <int, string> selfservice,  Dictionary <int, string> lojas){

            FastFood fast = new FastFood();
            int id;
            Console.Write("Digite o ID do restaurante: ");
            Int32.TryParse(Console.ReadLine(), out id);

            foreach(KeyValuePair <int, string> v in fastfood){
                if(id == v.Key){
                    fastfood.Remove(id);
                }
            }
            
            fast.MenuFastFood(fastfood, selfservice, lojas);
        }
        
        public void ExibeLista(Dictionary <int, string> fastfood , Dictionary <int, string> selfservice,  Dictionary <int, string> lojas){

            FastFood fast = new FastFood(); 
                  
            foreach(KeyValuePair <int, string> v in fastfood){
                Console.WriteLine($"ID do restaurante: {v.Key}, nome do restaurante: {v.Value}");
            }

            fast.MenuFastFood(fastfood, selfservice, lojas);
        }
    }
}
