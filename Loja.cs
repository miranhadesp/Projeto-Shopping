using System;
using System.Collections.Generic;

namespace projeto1
{
    public class Loja : ILoja
    {
        private int id;
        public int Id{
            get{ return id; }
            set{ id = value; }
        }

        private string nomeLoja;
        public string NomeLoja{
            get{ return nomeLoja; }
            set{ nomeLoja = value; }
        }

        private string segmento;
        public string Segmento{
            get{ return segmento; }
            set{ segmento = value; }
        }

        private string nomeProduto;
        public string NomeProduto{
            get{ return nomeProduto; }
            set{ nomeProduto = value; }
        }

        private double precoProduto;
        public double PrecoProduto{
            get{ return precoProduto; }
            set{ precoProduto = value; }
        }

       Inicio inicio = new Inicio();

        public Loja(){

        }

        public Loja(int id, string nomeLoja, string segmento){


        }
       public Loja(int id, string nomeLoja, string segmento, string nomeProduto, double precoProduto){

           Id = id;
           NomeLoja = nomeLoja;
           Segmento = segmento;
           NomeProduto = nomeProduto;
           PrecoProduto = precoProduto;
       }

        public void CadastrarLoja(List<ILoja> lojas, List<ICliente> clientes, List<IPassagem> passagens){

            Console.Write("\nDigite o código da sua loja: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segmento que quer cadastrar (FastFood, SelfService, Loja): ");
            Segmento = Console.ReadLine();

            foreach (ILoja e in lojas){
                if(Segmento == e.Segmento){
                    if(Id == e.Id){
                        Console.WriteLine("Loja já cadastrada, tente novamente!");
                        CadastrarLoja(lojas, clientes, passagens);
                    }
                }
            }
            
            Console.Write("Digite o nome da loja: ");
            NomeLoja = Console.ReadLine();
            
            Console.Write("Digite o produto dessa loja: ");
            NomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            PrecoProduto = Convert.ToDouble(Console.ReadLine());

            lojas.Add(new Loja(Id, NomeLoja, Segmento));

            Console.WriteLine("Cadastro realizado com sucesso!");

            inicio.MenuGeral(lojas, clientes,passagens);
        }

        public void CadastrarProdutos(List<ILoja> lojas, List<ICliente> clientes, List<IPassagem> passagens){

            Console.Write("Digite a loja que você quer cadastrar um produto: ");
            string nome = Console.ReadLine();

            foreach(ILoja e in lojas){
                if(nome == e.NomeLoja){
                    Console.Write("Qual produto deseja cadastrar? ");
                    NomeProduto = Console.ReadLine();

                    Console.Write("Digite o valor desse produto: ");
                    PrecoProduto = Convert.ToDouble(Console.ReadLine());

                    lojas.Add(new Loja(Id, NomeLoja, Segmento, nomeProduto, PrecoProduto));
                } 

            Console.Write("Deseja cadastrar outro produto na loja? (S/N)");
            }

            inicio.MenuGeral(lojas, clientes, passagens);
        }
    }
}






