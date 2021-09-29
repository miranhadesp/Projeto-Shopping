using System;
using System.Collections.Generic;

namespace projeto1
{
    class Produto : IProduto
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
