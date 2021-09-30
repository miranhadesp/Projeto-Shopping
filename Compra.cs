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
            Console.Write("\nDigite o em qual segmento de lojas deseja comprar produtos: ");
            string segmento = Console.ReadLine(); //-> gancho para ligar em lojas
            
            var lojasSegmento = lojas.Where(e => e.Segmento.StartsWith(segmento)).ToList();

            if(segmento.ToUpper() == "AEROPORTO"){
                //passagem.VenderPassagem(lojas, produtos, clientes, passagens);
                inicio.MenuGeral(lojas, produtos, clientes, passagens);
            }
            else{
                Console.WriteLine("Lojas encontradas: ");

                foreach(var e in lojasSegmento){
                        Console.WriteLine($"\nNome: {e.NomeLoja}");

                        foreach(IProduto k in produtos){
                            if(e.Id == k.CodLojaCadastrada){
                                Console.WriteLine($"Produtos dentro de {e.NomeLoja}: {k.Nome} {k.Preco}R$");
                            }
                        }
                }
            }
            //Código salvo em produto == Código da Loja
        }
    }
}

//produtos.Where(e => e.CodLojaCadastrada.StartsWith(k.Id)).ToList();