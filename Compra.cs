    using System;
using System.Collections.Generic;
using System.Linq;

namespace projeto1
{
    public class Compra
    {
        Inicio inicio = new Inicio();
        Passagem passagem = new Passagem();

        public void RealizarCompra(
            List<ILoja> lojas,
            List<IProduto> produtos,
            List<ICliente> clientes,
            List<IPassagem> passagens
        )
        {
            Console.Write("\nDigite em qual segmento de lojas deseja comprar produtos: ");
            string segmento = Console.ReadLine(); //-> gancho para ligar em lojas
            
            var lojasSegmento = lojas.Where(e => e.Segmento.StartsWith(segmento)).ToList();

            if(segmento.ToUpper() == "AEROPORTO"){
                    foreach (ICliente e in clientes)
                    {
                        Console.WriteLine($"\nOlá, {e.NomeCliente}. Bem vindo :)");
                    }
                    passagem.VenderPassagem(lojas, produtos, clientes, passagens);
            }
            else{
                Console.WriteLine("Lojas encontradas: ");

                foreach(var e in lojasSegmento){
                    Console.WriteLine($"\nNome: {e.NomeLoja}");

                    foreach(IProduto k in produtos){
                        if(e.Id == k.CodLojaCadastrada){
                            Console.WriteLine($"Produtos dentro de {e.NomeLoja}: {k.Nome} R$: {k.Preco}");
                        }
                    }
                }

                Console.Write("\nDigite o produto que deseja comprar: ");
                string nomeProduto = Console.ReadLine();

                var nomeCompra = produtos.Where(e => e.Nome == nomeProduto).ToList();

                foreach (var e in nomeCompra){ 
                    Console.WriteLine($"\nVenda do produto {e.Nome} com valor: R${e.Preco} realizada com sucesso!");
                }

                Console.Write("Deseja realizar outra compra? (S/N)"); 

                switch(Console.ReadLine().ToUpper()){ //-> loop sem loop

                case "S":
                    RealizarCompra(lojas, produtos, clientes, passagens);
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
            //Código salvo em produto == Código da Loja
    }
}


//produtos.Where(e => e.CodLojaCadastrada.StartsWith(k.Id)).ToList();