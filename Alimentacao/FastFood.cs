using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto1{

    public class FastFood : IAlimentacao{ // -> Rodrigo e Diogo

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

        private string produto;
        public string Produto{
            get{ return produto; } 
            set{ produto = value; }
        }

        private double preco;
        public double Preco{
            get{ return preco; } 
            set{ preco = value; }
        }
       
        // 1 MENU CAD LOJA

        public void MenuFastFood(Dictionary <int, string> fastfood , Dictionary <int, string> selfservice,  Dictionary <int, string> lojas){
           
            ListaFast listaFast = new ListaFast();

            int opcao;

            Console.WriteLine("\nEscolha uma opção");
            Console.WriteLine("1 - Adicionar fastfood"); //Alterei texto (erro de português) - Thais
            Console.WriteLine("2 - Exibir fastfoods");
            Console.WriteLine("3 - Remover restaurante");
            Console.WriteLine("0 - Voltar ao menu");


            Console.Write("Opção: ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            switch(opcao){
                case 1:
                    listaFast.MontarLista(fastfood, selfservice, lojas);
                    break;

                case 2:
                    listaFast.ExibeLista(fastfood, selfservice, lojas);
                    break;
                    
                case 3:
                    listaFast.RemoverItem(fastfood, selfservice, lojas);
                    break;
                    
                case 0:
                    Inicio inicio = new Inicio();
                    inicio.Select(fastfood, selfservice, lojas);
                    break;
            }
         }

 

        // 2 CADASTRA PROD

        // Verificar quais os itens tem no carrinho
        void Carrinho(){
            Console.WriteLine($"O(s) item(ns) 'x','y','z' estão no carinho");
        }

        // 3 Simular venda de mercadoria
        void Vender(){
            //PrepararPedido();
            Console.WriteLine($"Venda do 'Produto' foi realizada com sucesso");
        }
         // Realizar processo de preparar pedido Fast Food
         /*public virtual void PrepararPedido(){
             Console.WriteLine("Separando pedido");
             Console.WriteLine("Aquecendo a gordura");
             Console.WriteLine("Adicionando mais caloria")*/


             /* var preparo = "Seu Pedido está sendo preparado";
                var fim = "Pedido finalizado, por favor retire no balcão";   */
    }
}
