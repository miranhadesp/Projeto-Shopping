using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto1{

    public class Cliente : ICliente{

        List<ICliente> cliente = new List<ICliente>();

        private double carteira;
        public double Carteira {
            get {return carteira;}
            set {carteira = value;}
        }

        private string nome;
        public string Nome{
            get{ return nome; }
            set{ nome = value; }
        }
        
        private int cpf;
        public int Cpf{
            get{ return cpf; }
            set{ cpf = value; }
        }

        public Cliente(){

        }

        private Cliente(int cpf, string nome, double carteira){

            Cpf = cpf;
            Nome = nome;
            Carteira = carteira;
        }

        public void CadastrarCliente(){ // -> Victor Augusto

            double carteira = 0;

            Console.Write("\nDigite seu nome para cadastro: ");
            Nome = Console.ReadLine();

            Console.Write("Digite seu cpf: ");
            Cpf = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o valor existente na carteira? ");
            double.TryParse(Console.ReadLine(), out carteira);
            Carteira = carteira;

            cliente.Add(new Cliente(Cpf, Nome, Carteira));

            foreach (ICliente e in cliente){
                
                Console.WriteLine($"\nCPF: {e.Cpf}");
                Console.WriteLine($"Nome: {e.Nome}");
                Console.WriteLine($"Disponível na carteira: {e.Carteira}R$");
            }
        }
    }   
}