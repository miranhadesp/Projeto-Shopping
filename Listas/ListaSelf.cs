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

            foreach (KeyValuePair<int, string> e in selfservice){
                if(e.Key == chaveRes){
                    Console.WriteLine("\nLoja já cadastrada!");
                    MontarLista(fastfood, selfservice, lojas);
                }
            }

            Console.Write("Nome do selfservice: ");
            valorRes = Console.ReadLine();

            selfservice.Add(chaveRes, valorRes);

            Console.WriteLine("\nCadastro realizado com sucesso!\n");

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
                    Console.WriteLine("\nRemoção realizada com sucesso!");
                }
                else{
                    Console.WriteLine("ID não encontrado, tente novamente.");
                    RemoverItem(fastfood, selfservice, lojas);
                }
            }

            self.MenuSelfService(fastfood, selfservice, lojas);
        }

        public void ExibeLista(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas){ 

            SelfService self = new SelfService();

            Console.WriteLine("\n"); 

            foreach(KeyValuePair <int, string> v in selfservice){
                Console.WriteLine($"ID do selfservice: {v.Key}, nome do selfservice: {v.Value}");
            }

            self.MenuSelfService(fastfood, selfservice, lojas);
        }
    }

}
