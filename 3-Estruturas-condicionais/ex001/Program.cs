using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX001_extruturas_condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie um Progroma em C# em que receba três números do usuário, informe na tela qual o menor 
             * deles ou exiba se eles são iguais.
             */

            int num01, num02, num03;

            Console.WriteLine("Digite um 1º número:");
            num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um 2º número:");
            num02 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um 3º número:");
            num03 = int.Parse(Console.ReadLine());

            if (num01 < num02 & num01 < num03)
            {
                Console.WriteLine("O primeiro é menor: " + num01);
            }
            else if (num02 < num03)
            {
                Console.WriteLine("O segundo é menor: " + num02);
            }
            else if (num03 < num01)
            {
                Console.WriteLine("O terceiro é menor: " + num03);
            }
            else if (num01 == num02 & num01 == num03 & num02 == num03)
            {
                Console.WriteLine("Todos são iguais: " );
            } else
            {
                Console.WriteLine("Erro:");
            }
        }
    }
}
