using System;
using System.Collections.Generic;

namespace projeto1
{
    public class Produto : IProduto
    {
        public string Nome { get; set; }

        public double Preco { get; private set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
