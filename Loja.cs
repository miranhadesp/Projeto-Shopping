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

            NomeLoja = nomeLoja;
            Id = id;
            Segmento = segmento;
        }

        public void CadastrarLoja(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens){
            

            Console.Write("\nDigite o código da sua loja: ");
            Id = Convert.ToInt32(Console.ReadLine());

            foreach (ILoja e in lojas){
                if(Id == e.Id){
                    Console.WriteLine("Loja já cadastrada, tente novamente!");
                    CadastrarLoja(lojas, produtos, clientes, passagens);
                }
            }

            Console.Write("Digite o segmento que quer cadastrar (FastFood, SelfService, Loja): ");
            Segmento = Console.ReadLine();
            
            Console.Write("Digite o nome da loja: ");
            NomeLoja = Console.ReadLine();

            lojas.Add(new Loja(Id, NomeLoja, Segmento));

            Console.WriteLine("\nCadastro realizado com sucesso!");

            inicio.MenuGeral(lojas, produtos, clientes, passagens);
        }

        public void ExibirLojas(List<ILoja> lojas){

            Console.Write("\nLojas encontradas: ");

            foreach(ILoja e in lojas){
                Console.WriteLine($"\nCódigo da loja: {e.Id}");
                Console.WriteLine($"Segmento: {e.Segmento}");
                Console.WriteLine($"Nome: {e.NomeLoja}");
            }
        }
    }
}






