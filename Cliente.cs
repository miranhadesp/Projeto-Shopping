using System;
using System.Collections.Generic;

namespace projeto1{

    public class Cliente : ICliente{

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

        public ICliente CadastrarCliente(){ // -> Victor Augusto

            Dictionary<int, string> cliente = new Dictionary<int, string>();

            Console.WriteLine("Digite seu nome para cadastro: ");
            string _nome = Console.ReadLine();

            Console.WriteLine("Digite seu cpf: ");
            int _cpf = Convert.ToInt32(Console.ReadLine());
        }


        public double SaldoCarteira(){ // -> Vitor Gabriel

            double carteira = 0;

            Console.WriteLine("Qual o valor existente na carteira? ");

            double.TryParse(Console.ReadLine(), out carteira);
            
            this.Carteira = carteira; 

            return Carteira;
        }

    }   
}