using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto1{
 
    public class SelfService : IAlimentacao{ // -> Rodrigo e Diogo
        
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
        
        public void MenuSelfService(Dictionary <int, string> fastfood, Dictionary <int, string> selfservice, Dictionary <int, string> lojas){

            ListaSelf listaSelf = new ListaSelf();
            int opcao;
            Console.WriteLine("\nEscolha uma opção");
            Console.WriteLine("1 - Criar loja");
            Console.WriteLine("2 - Exibir lojas");
            Console.WriteLine("3 - Remover lojas");
            Console.WriteLine("4 - Voltar ao menu");

            Console.Write("Opção: ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            switch(opcao){
                case 1:
                    listaSelf.MontarLista(fastfood, selfservice, lojas);
                    break;
                case 2:
                    listaSelf.ExibeLista(fastfood, selfservice, lojas);
                    break;
                case 3:
                    listaSelf.RemoverItem(fastfood, selfservice, lojas);
                    break;
                case 4:
                    Inicio inicio = new Inicio();
                    inicio.Select(fastfood, selfservice, lojas);
                    break;
            }

        }
        // Verificar quais os itens tem no carrinho
        public void Carrinho(){
            Console.WriteLine($"O(s) item(ns) 'x','y','z' estão no carrinho");
        }

            // Simular venda de mercadoria
        public void Vender(){
            Console.WriteLine($"Venda do 'Produto' foi realizada com sucesso");
        }
    }
}

