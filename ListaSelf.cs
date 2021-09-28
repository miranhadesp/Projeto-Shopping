using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1{

    public class ListaSelf{

            public void MontarLista(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas){

            SelfService self = new SelfService();

            int chaveRes;
            string valorRes;

            Console.Write("ID do selfservice: ");
            Int32.TryParse(Console.ReadLine(), out chaveRes);

            Console.Write("Nome do selfservice: ");
            valorRes = Console.ReadLine();

            selfservice.Add(chaveRes, valorRes);
            self.MenuSelfService(fastfood, selfservice, lojas);
        }

        public void  RemoverItem(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas){

            SelfService self = new SelfService();

            int id;

            Console.Write("Digite o ID do selfservice: ");
            Int32.TryParse(Console.ReadLine(), out id);

            foreach(KeyValuePair <int, string> v in selfservice){
                if(id == v.Key){
                    selfservice.Remove(id);
                }
            }

            self.MenuSelfService(fastfood, selfservice, lojas);
        }

        public void ExibeLista(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas){ 

            SelfService self = new SelfService();

            foreach(KeyValuePair <int, string> v in selfservice){
                Console.WriteLine($"ID do selfservice: {v.Key}, nome do selfservice: {v.Value}");
            }

            self.MenuSelfService(fastfood, selfservice, lojas);
        }
    }

}
