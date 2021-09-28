using System;
using System.Collections.Generic;

namespace projeto1{
 
    public class SelfService : IAlimentacao{ // -> Rodrigo e Diogo
        
        int Id {get;}
        
        string Nome{ get; set;}

        string Produto {get; set;}

        double Preco {get; set;}
        
        public void CadastrarSelfService(){
           public void Menu2(Dictionary <int, string> selfservice, Dictionary <int, string> fastfood){
            Lista2 lista2 = new Lista2();
            int opcao;
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Criar lista");
            Console.WriteLine("2 - exibir lista");
            Console.WriteLine("3 - remover restaurante");
            Console.WriteLine("4 - sair do sistema");


            Console.Write("Opção: ");
            Int32.TryParse(Console.ReadLine(), out opcao);

            switch(opcao){
                case 1:
                    lista2.MontarLista(selfservice, fastfood);
                    break;
                case 2:
                    lista2.ExibeLista(selfservice, fastfood);
                    break;
                case 3:
                    lista2.RemoverItem(selfservice, fastfood);
                    break;
                case 4:
                    Inicio inicio = new Inicio();
                    inicio.Select(fastfood, selfservice);
                    break;

            }

        }
         // Verificar quais os itens tem no carrinho
        void Carrinho(){
            Console.WriteLine($"O(s) item(ns) 'x','y','z' estão no carrinho")
        }

        // Simular venda de mercadoria
         void Vender(){
            Console.WriteLine($"Venda do 'Produto' foi realizada com sucesso");
    }
