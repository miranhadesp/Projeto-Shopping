using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto1
{

    public class Cliente : ICliente
    {

        private int id;
        public int Id
        { // Acesso e modificação da variável id.
            get { return id; }
            set { id = value; }
        }

        private string nomeCliente;
        public string NomeCliente
        { // Acesso e modificação da variável nomeCliente.
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        private int cpf;
        public int Cpf
        { // Acesso e modificação da variável cpf.
            get { return cpf; }
            set { cpf = value; }
        }

        Compra compra = new Compra();
        Inicio inicio = new Inicio();

        public Cliente()
        { //Construtor para o caso de sem parâmetros.

        }
        public Cliente(int id, string nome, int cpf)
        { //Construtor com três parâmetros.

            Id = id;
            NomeCliente = nome;
            Cpf = cpf;
        }

        public void CadastrarCliente(List<ILoja> lojas, List<IProduto> produtos, List<ICliente> clientes, List<IPassagem> passagens)
        { // Método para realizar cadastro cliente.

            Console.Write("\nDigite seu nome: ");
            NomeCliente = Console.ReadLine();

            Console.Write("Digite seu CPF: ");
            Cpf = Convert.ToInt32(Console.ReadLine());

            clientes.Add(new Cliente(1, NomeCliente, Cpf)); // Adiciona cliente na lista de clientes.

            Console.WriteLine("\nCadastro realizado com sucesso!");

            compra.RealizarCompra(lojas, produtos, clientes, passagens);
        }
    }
}