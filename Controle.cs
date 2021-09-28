using System;
using System.Collections.Generic;


namespace projeto1{

    public class Controle{

        public static void Switchs(string str){ // -> Victor Augusto

            FastFood fastfood = new FastFood();
            SelfService selfservice = new SelfService();
            Loja loja = new Loja();

            int valor = Convert.ToInt32(str);

            switch (valor){
                
                case 11:
                    fastfood.CadastrarFastFood();
                    //Cadastrar FastFood
                    break;

                case 12:
                    selfservice.CadastrarSelfService();
                    //Cadastrar SelfService
                    break;

                case 13:
                    loja.CadastrarLoja();
                    //Cadastrar Loja
                    break;

                case 21:
                    //Remover FastFood
                    break;
                
                case 22:
                    //Remover SelfService
                    break;

                case 23:
                    //Remover Loja
                    break;
                
                case 31:
                    //Compra no FastFood
                    break;
                
                case 32:
                    //Compra no SelfService
                    break;

                case 33:
                    //Compra na Loja
                    break;

                default:
                    break;
            }
        }
    }
}