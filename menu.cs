using System;
using System.Collections.Generic;

namespace projeto1{

    public class Menu{

         public static void Inicio(){       //-> Victor Augusto

            Console.WriteLine("\n1 - Cadastrar");
            Console.WriteLine("2 - Remover");
            Console.WriteLine("3 - Simular compra");
            Console.WriteLine("0 - Sair do programa");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if(!(opcao == 1 || opcao == 2 || opcao == 3)){
                Console.WriteLine("Opção inválida, tente novamente");
                Inicio();
            } 

            else{
                string op = Convert.ToString(opcao);

                Segmento(op);
            }
        }
            
        public static void Segmento(string controle){

            Console.WriteLine("\n1 - FastFood");
            Console.WriteLine("2 - SelfService");
            Console.WriteLine("3 - Loja");
            Console.WriteLine("0 - Voltar ao menu");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if(!(opcao == 1 || opcao == 2 || opcao == 3)){
                Console.WriteLine("Opção inválida, tente novamente");

                Segmento(controle);
            } 

            else{
                string op = Convert.ToString(opcao);

                string str = controle + op;

                Controle.Switchs(str);
            } 
        } 
    }
}