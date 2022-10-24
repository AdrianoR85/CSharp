// See https://aka.ms/new-console-template for more information
using System;

namespace CSharp {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Projeto 2 - Criando Variáveis");

            string nome;
            int idade;
            double peso;

            nome = "Adriano";
            idade = 35;
            peso = 65.30;

            Console.WriteLine("My name is " + nome);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Seu peso é: " + peso);
        }
    }

}