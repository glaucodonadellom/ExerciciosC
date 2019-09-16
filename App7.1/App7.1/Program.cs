/*Em Matemática, o número harmônico designado por H(n) define-se como
sendo a soma da série harmônica:
H(n)=1+1/2+1/3+1/4+....+1/n
Faça um programa que leia um valor n inteiro e positivo e apresente o
valor de H(n).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, h=0;
            //inicio do programa
            Console.WriteLine("Em Matemática, o número harmônico designado por H(n) define-se como sendo a soma da série harmônica:\n\n");

            //recebe valor de N
            Console.WriteLine("Digite o valor de N");
            n = Convert.ToDouble(Console.ReadLine());

            //faz o calculo pra saber valor de H
            for (double x = 1; x <= n; x++)
            {
                if (x == 1)
                {
                    h = 1;
                }
                else
                {
                    h += (1 / x);
                }



            }
            //imprime o valor de H
            Console.WriteLine("\n\nO valor de H é " + Math.Round(h, 3) );

            Console.ReadKey();
        }
    }
}
