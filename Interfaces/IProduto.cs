using System;

namespace projeto1{

    public interface IProduto : ILoja{

        string Produto {get; set;}

        double Preco {get; set;} 
    }
}