// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace projeto1{

//     public class Aeoroporto{ // -> Rodrigo e Diogo
       
//         public void MenuAeroporto(){

//             int opcao;

//             Console.WriteLine("\nEscolha uma opção");
//             Console.WriteLine("1 - Cadastrar empresa");
//             Console.WriteLine("2 - Exibit empresa");
//             Console.WriteLine("3 - Remover empresa");
//             Console.WriteLine("4 - Comprar passagem");
//             Console.WriteLine("0 - Retornar ao menu inicial");


//             Console.Write("Opção: ");
//             Int32.TryParse(Console.ReadLine(), out opcao);

//             switch(opcao){
//                 case 1:
//                     ListaAeroporto menuLista = new ListaAeroporto();
//                     menuLista.CadastrarEmpresa();
//                     break;

//                 case 2:
//                     ListaAeroporto menuLista = new ListaAeroporto();
//                     menuLista.ExibirEmpresa();
//                     break;
                    
//                 case 3:
//                     ListaAeroporto menuLista = new ListaAeroporto();
//                     menuLista.RemoverEmpresa();
//                     break;

//                 case 4:
//                     ListaAeroporto menuLista = new ListaAeroporto();
//                     menuLista.VenderPassagem();
//                     break;
                    
//                 case 0:
//                     Inicio inicio = new Inicio();
//                     inicio.Select();
//                     break;
//             }
//          }
//     }
// }