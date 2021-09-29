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

            foreach (KeyValuePair<int, string> e in lojas){
                if(e.Key == chaveRes){
                    Console.WriteLine("\nLoja já cadastrada!");
                    MontarLista(fastfood, selfservice, lojas);
                }
            }

            Console.Write("Nome da loja: ");
            valorRes = Console.ReadLine();

            lojas.Add(chaveRes, valorRes);

            Console.WriteLine("\nCadastro realizado com sucesso!\n");

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
                    Console.WriteLine("\nRemoção realizada com sucesso!");
                }
                else{
                    Console.WriteLine("ID não encontrado, tente novamente.");
                    RemoverItem(fastfood, selfservice, lojas);
                }
            }
            loja.MenuLoja(fastfood, selfservice, lojas);
        }
        
        public void ExibeLista(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas){  

            Loja loja = new Loja();  

            Console.WriteLine("\n"); 

            foreach(KeyValuePair <int, string> v in lojas){
                Console.WriteLine($"ID da loja: {v.Key}, nome da loja: {v.Value}");
            }

            loja.MenuLoja(fastfood, selfservice, lojas);
        }
    
    }
}
