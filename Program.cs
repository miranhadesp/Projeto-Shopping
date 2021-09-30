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

            inicio.MenuGeral(lojas, clientes, passagens); 
        }
    }
}
