using System;
using System.Collections.Generic;

namespace projeto1
{
    public class Produto : IProduto
    {

        private int codLojaCadastrada;
        public int CodLojaCadastrada{
            get{ return codLojaCadastrada; }
            set{ codLojaCadastrada = value; } 
        }
        
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

        public Produto(string nome, int codloja, double preco){

            Nome = nome;
            CodLojaCadastrada = codloja;
            Preco = preco;
        }

        public void CadastrarProdutos(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens){

            bool encontrou = false;
            int valorIgual = 0;

            Console.Write("\nDigite o código da loja que você quer cadastrar um produto: ");
            CodLojaCadastrada = Convert.ToInt32(Console.ReadLine()); //-> gancho para ligar em lojas

            foreach(ILoja e in lojas){
                if(CodLojaCadastrada == e.Id){
                    encontrou = true;
                    valorIgual = e.Id;
                    break;
                } 
            }

            if(encontrou){
                Console.Write("\nQual produto deseja cadastrar? ");
                Nome = Console.ReadLine();

                Console.Write("Digite o valor desse produto: ");
                Preco = Convert.ToDouble(Console.ReadLine());

                produtos.Add(new Produto(Nome, CodLojaCadastrada, Preco)); //-> uso de uma nova lista produto
            }
            else{
                Console.Write("\nLoja não encontrada, tente novamente.");
                CadastrarProdutos(lojas, produtos, clientes, passagens);
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
