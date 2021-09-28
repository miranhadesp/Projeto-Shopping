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
           public void Menu1(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice ){

            Lista1 lista1 = new Lista1();
            int opcao;
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Adcionar fastfood");
            Console.WriteLine("2 - exibir fastfoods");
            Console.WriteLine("3 - remover restaurante");
            Console.WriteLine("4 - voltar ao menu");


            Console.Write("Opção: ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            switch(opcao){
                case 1:
                    lista1.MontarLista(fastfood, selfservice);
                    break;
                case 2:
                    lista1.ExibeLista(fastfood, selfservice);
                    break;
                case 3:
                    lista1.RemoverItem(fastfood, selfservice);
                    break;
                case 4:
                    Inicio inicio = new Inicio();
                    inicio.Select(fastfood, selfservice);
                    break;

            }
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
