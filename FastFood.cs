using System;
using System.Collections.Generic;

namespace projeto1{

    public class FastFood : IAlimentacao{ // -> Rodrigo e Diogo

        int Id {get; set;}
        
        string NomeFastFood{ get; set;}

        string ProdutoFastFood{get; set;}

        double PrecoFastFood{get; set;}
       
        // 1 MENU CAD LOJA

        public void CadastrarFastFood(){
            int n;
            int id;
            string nomeFastFood;


            Console.Write("Número de FastFoods cadastradas: ");
            Int32.TryParse(Console.ReadLine(), out nomeFastFood);


            for(int i = 0; i<n; i++){
                Console.Write("ID do FastFood: ");
                Int32.TryParse(Console.ReadLine(), out id);

                this.Id = id;

                Console.Write("Nome do FastFood: ");
                nomeFastFood = Console.ReadLine();
                
                this.NomeFastFood = nomeFastFood;

                loja.Add(nomeFastFood, id);
            }
            Menu.Inicio();//(lojas);
        }

        public void RemoverFastFood(Dictionary <int, string> fastfood){
            Menu menu = new Menu();
            int id;
            Console.Write("Digite o IP do fastfood: ");
            Int32.TryParse(Console.ReadLine(), out id);
            
            foreach(KeyValuePair <int, string> v in fastfood){
                if(id == v.Key){
                    fastfood.Remove(id);
                }
            }
            Menu.Inicio(fastfood);
        }

        // 2 CADASTRA PROD

        // Verificar quais os itens tem no carrinho
        void Carrinho(){
            Console.WriteLine($"O(s) item(ns) 'x','y','z' estão no carinho")
        }

        // 3 Simular venda de mercadoria
         void Vender(){
            Console.WriteLine($"Venda do 'Produto' foi realizada com sucesso");
         }
        }
    }
}