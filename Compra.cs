using System;
using System.Collections.Generic;
using System.Linq;

namespace projeto1
{
    public class Compra
    {
        Inicio inicio = new Inicio();
        Passagem passagem = new Passagem();

        public void RealizarCompra(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens)
        { // Método para realizar compras. Verifica em qual seguimento de loja deseja comprar algum produto.

            Console.Write("\nDigite em qual segmento de lojas deseja comprar produtos (FastFood, SelfService, Loja): ");
            string segmento = Console.ReadLine(); 

            var lojasSegmento = lojas.Where(e => e.Segmento.StartsWith(segmento)).ToList(); //criando uma lista apenas com o segmento digitado pelo usuário, retornando todos os valores cadastrados desse segmento na lista "lojas" 

            if (segmento.ToUpper() == "AEROPORTO") //se digitar aeroporto, cai na parte de passagem
            {
                foreach (ICliente e in clientes)
                {
                    Console.WriteLine($"\nOlá, {e.NomeCliente}. Bem vindo :)");
                }
                passagem.VenderPassagem(lojas, produtos, clientes, passagens);
            }
            else
            {
                Console.WriteLine("Lojas encontradas: ");

                foreach (var e in lojasSegmento) //foreach percorrendo a lista de nomes feita acima
                {
                    Console.WriteLine($"\nNome: {e.NomeLoja}");

                    foreach (IProduto k in produtos) //foreach percorrendo a lista de produtos 
                    {
                        if (e.Id == k.CodLojaCadastrada)
                        {
                            Console.WriteLine($"Produtos dentro de {e.NomeLoja}: {k.Nome} R$: {k.Preco}"); 
                        }
                    }
                }

                Console.Write("\nDigite o produto que deseja comprar: ");
                string nomeProduto = Console.ReadLine();

                var nomeCompra = produtos.Where(e => e.Nome == nomeProduto).ToList(); //lista com nomes 
                
                foreach (var e in nomeCompra)
                {
                    Console.WriteLine($"\nVenda do produto {e.Nome} com valor: R${e.Preco} realizada com sucesso!");
                }

                Console.Write("Deseja realizar outra compra? (S/N)");

                switch (Console.ReadLine().ToUpper())
                { //verificação se o usuário deseja comprar outra coisa
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
    }
}