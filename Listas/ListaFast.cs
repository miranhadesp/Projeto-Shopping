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

             foreach (KeyValuePair<int, string> e in fastfood){
                if(chaveRes == e.Key){
                    Console.WriteLine("\nLoja já cadastrada!");
                    MontarLista(fastfood, selfservice, lojas);
                }
            }

            Console.Write("Nome do restaurante: ");
            valorRes = Console.ReadLine();

            fastfood.Add(chaveRes, valorRes);

            Console.WriteLine("\nCadastro realizado com sucesso!");

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
                    Console.WriteLine("\nRemoção realizada com sucesso!");
                }
                else{
                    Console.WriteLine("ID não encontrado, tente novamente.");
                    RemoverItem(fastfood, selfservice, lojas);
                }
            }
            
            fast.MenuFastFood(fastfood, selfservice, lojas);
        }
        
        public void ExibeLista(Dictionary <int, string> fastfood , Dictionary <int, string> selfservice,  Dictionary <int, string> lojas){

            FastFood fast = new FastFood(); 

            Console.WriteLine("\n");
                  
            foreach(KeyValuePair <int, string> v in fastfood){
                Console.WriteLine($"ID do restaurante: {v.Key}, nome do restaurante: {v.Value}");
            }

            fast.MenuFastFood(fastfood, selfservice, lojas);
        }
    }
}
