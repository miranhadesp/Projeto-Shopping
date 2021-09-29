using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1{

    class Passageiro : Cliente{

        public void RegistrarBagagem(int cpf, string nome, double carteira){

            Console.WriteLine($"\nSeu Nome: {nome}");
            Console.WriteLine($"Seu CPF: {cpf}");
            Console.WriteLine($"Seu Saldo: {carteira}");

            Console.Write("\nDigite a quantidade de bagagem a ser registrada: ");
            int qtdBagagem = Convert.ToInt32(Console.ReadLine());


            ChecarCPF(nome, cpf);
        } 

        public void ChecarCPF(string nome, int cpf){

            Console.Write("\nConfirme seu CPF para finalizar o registro: ");
            int _cpf = Convert.ToInt32(Console.ReadLine());

            if(cpf == _cpf){
                Console.Write($"\nRegistro realizado com sucesso, obrigado {nome}. Boa viagem :)");
            }
            else{
                Console.Write("\nCPF inválido, tente novamente.");
                ChecarCPF(nome, cpf);
            }
        } 
    }
}