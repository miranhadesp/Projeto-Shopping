using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto1{

    class Program{

        static void Main(string[] args){

            Inicio inicio = new Inicio();

            List<ILoja> lojas = new List<ILoja>();//lista para lojas e produtos
            List<ICliente> clientes = new List<ICliente>(); //lista para cliente.
            List<IPassagem> passagens = new List<IPassagem>();//lista para as passagens
            List<IProduto> produtos = new List<IProduto>();//lista para os produtos

            // -----------------------------------------------------------------------
            lojas.Add(new Loja(1,"Subway", "FastFood")); // Adiciona itens a lista Loja de ILoja
            lojas.Add(new Loja(2,"McDonald's", "FastFood")); // Adiciona itens a lista Loja de ILoja
            lojas.Add(new Loja(3,"Starbucks", "FastFood")); // Adiciona itens a lista Loja de ILoja
            lojas.Add(new Loja(4,"Quentinha do Kilo", "SelfService")); // Adiciona itens a lista Loja de ILoja
            lojas.Add(new Loja(5,"Dona Nicole", "SelfService")); // Adiciona itens a lista Loja de ILoja
            lojas.Add(new Loja(6,"Comedere", "SelfService")); // Adiciona itens a lista Loja de ILoja
            lojas.Add(new Loja(7,"Renner", "Loja")); // Adiciona itens a lista Loja de ILoja
            lojas.Add(new Loja(8,"Elmo", "Loja")); // Adiciona itens a lista Loja de ILoja
            lojas.Add(new Loja(9,"Cineart", "Loja")); // Adiciona itens a lista Loja de ILoja
            // -----------------------------------------------------------------------

            Console.WriteLine("Bem vindo(a) ao Shopping Catarina.");
            
            inicio.MenuGeral(lojas, produtos, clientes, passagens); 
        }
    }
}
