using System;


namespace projeto1{

    interface ILoja{

        int Id {get;}
        
        string Nome{ get; set;}

        string Produto {get; set;}

        double Preco {get; set;}
        

        void Vender();

        void Carrinho();
    }
}
