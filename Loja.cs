using System;
using System.Collections.Generic;

namespace projeto1{

    public class Loja : ILoja{

       
        // 1 MENU CAD LOJA

        public void CadastrarLoja(){
            int n;
            int id;
            string valorRes;

            Console.Write("Número de lojas cadastradas: ");
            Int32.TryParse(Console.ReadLine(), out n);

            for(int i = 0; i<n; i++){
                Console.Write("ID da loja: ");
                Int32.TryParse(Console.ReadLine(), out id);

                Console.Write("Nome da loja: ");
                valorRes = Console.ReadLine();
                
                loja.Add(chaveRes, id);
            }
            sistema.//(lojas);
        }

        public void RemoverLoja(Dictionary <int, string> loja){
            Menu menu = new Menu();
            int id;
            Console.Write("Digite o IP do loja: ");
            Int32.TryParse(Console.ReadLine(), out id);
            
            foreach(KeyValuePair <int, string> v in loja){
                if(id == v.Key){
                    loja.Remove(id);
                }
            }
            Menu.Inicio(loja);
        }

        // 2 CADASTRA PROD
        

        // 3 Simular compra
 
        }
    }
}