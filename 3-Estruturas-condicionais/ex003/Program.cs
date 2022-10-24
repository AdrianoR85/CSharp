using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Guilherme é chefe de TI de sua empresa e precisa que você ajude-o a criar um programa
             * que receba os chamados dos usuários classificando e exibindo na tela o seu nível de urgência, sendo:
             * 0-3 - baixo
             * 4-6 - médio
             * 7-9 - alto
             * acima de 9 - grave
             */

            int nivel;

            Console.WriteLine("Descreva sua solivitação");
            Console.ReadLine();
            Console.WriteLine("Em uma escala de 0 a 10 informe o nível da urgência:");
            nivel = int.Parse(Console.ReadLine()) ;

            if (nivel >= 0 & nivel <= 3)
            {
                Console.WriteLine("Solicitação recebida.nível: BAIXO");
            } else if (nivel >= 4 & nivel <= 6)
            {
                Console.WriteLine("Solicitação recebida. nível: MÉDIO");
            } else if (nivel >= 7 & nivel <= 9)
            {
                Console.WriteLine("Solicitação recebida. nível: ALTO");
            } else
            {
                Console.WriteLine("Solicitação recebida. nível: GRAVE");
            }
        }
    }
}
