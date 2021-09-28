using System;
using System.Collections.Generic;

namespace projeto1{
 
    public class SelfService : IAlimentacao{ // -> Rodrigo e Diogo
        
        int Id {get;}
        
        string Nome{ get; set;}

        string Produto {get; set;}

        double Preco {get; set;}
        
        public void CadastrarSelfService(){
            int n;
            int id;
            string valorRes;

            Console.Write("Número de SelfServices cadastradas: ");
            Int32.TryParse(Console.ReadLine(), out n);

            for(int i = 0; i<n; i++){
                Console.Write("ID do SelfService: ");
                Int32.TryParse(Console.ReadLine(), out id);

                Console.Write("Nome do SelfService: ");
                valorRes = Console.ReadLine();
                
                loja.Add(chaveRes, id);
            }

            Menu.Inicio();
        }

        public void RemoverSelfService(Dictionary <int, string> selfservice){
            Menu menu = new Menu();
            int id;
            Console.Write("Digite o IP do selfservice: ");
            Int32.TryParse(Console.ReadLine(), out id);
            foreach(KeyValuePair <int, string> v in selfservice){
                if(id == v.Key){
                    selfservice.Remove(id);
                }
            }
            Menu.Inicio(selfservice);
        }
        
         // Verificar quais os itens tem no carrinho
        void Carrinho(){
            Console.WriteLine($"O(s) item(ns) 'x','y','z' estão no carrinho")
        }

        // Simular venda de mercadoria
         void Vender(){
            Console.WriteLine($"Venda do 'Produto' foi realizada com sucesso");
    }