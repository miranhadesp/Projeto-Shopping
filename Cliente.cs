using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto1{

    public class Cliente : ICliente{

        private int id;
        public int Id{
            get{ return id; }
            set{ id = value; }
        }
        
        private string nomeCliente;
        public string NomeCliente{
            get{ return nomeCliente; }
            set{ nomeCliente = value; }
        }

        private int cpf;
        public int Cpf{
            get{ return cpf; }
            set{ cpf = value; }
        }

        Compra compra = new Compra();
        Inicio inicio = new Inicio();

        public Cliente(){ //Construtor para o caso de sem parâmetros

        }
        public Cliente(int id, string nome, int cpf){ //Construtor com dois parâmetros
            
            Id = id;
            NomeCliente = nome;
            Cpf = cpf;
        }

        public void CadastrarCliente(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens){ //cadastro cliente puxando lista cliente

            Console.Write("\nDigite seu nome: ");
            NomeCliente = Console.ReadLine();

            Console.Write("Digite seu CPF: ");
            Cpf = Convert.ToInt32(Console.ReadLine());

            clientes.Add(new Cliente(1, NomeCliente, Cpf));

            foreach (ICliente e in clientes)
            {
                Console.WriteLine(e.Id);
            }

            Console.WriteLine("\nCadastro realizado com sucesso!"); 

            inicio.MenuGeral(lojas, produtos, clientes, passagens);
        }
    }   
}