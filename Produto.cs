using System;
using System.Collections.Generic;

namespace projeto1
{
    public class Produto : IProduto
    {
        private string nome;
        public string Nome{
            get{ return nome; }
            set{ nome = value; }
        }

        private double preco;
        public double Preco{
            get{ return preco; }
            set{ preco = value; }
        }

        Inicio inicio = new Inicio();

        public Produto(){

        }

        public Produto(string nome, double preco){

            Nome = nome;
            Preco = preco;
        }

        public void CadastrarProdutos(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens){

            Console.Write("\nDigite o código da loja que você quer cadastrar um produto: ");
            int id = Convert.ToInt32(Console.ReadLine()); //-> gancho para ligar em lojas

            foreach(ILoja e in lojas){
                if(id == e.Id){
                    Console.Write("\nQual produto deseja cadastrar? ");
                    Nome = Console.ReadLine();

                    Console.Write("Digite o valor desse produto: ");
                    Preco = Convert.ToDouble(Console.ReadLine());

                    produtos.Add(new Produto(Nome, Preco)); //-> uso de uma nova lista produto
                } 
                else{
                    Console.WriteLine("\nLoja não encontrada, tente novamente.");
                    CadastrarProdutos(lojas, produtos, clientes, passagens);
                }
            }

            Console.Write("Deseja cadastrar outro produto? (S/N)"); 

            switch (Console.ReadLine().ToUpper()){ //-> loop sem loop

                case "S":
                    CadastrarProdutos(lojas, produtos, clientes, passagens);
                    break;

                case "N":
                    inicio.MenuGeral(lojas, produtos, clientes, passagens);
                    break;
            
                default:
                    Console.WriteLine("\nOpção inválida, voltando ao menu...");
                    inicio.MenuGeral(lojas, produtos, clientes, passagens);
                    break;
            }
        }
    }
}
