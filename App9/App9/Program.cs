/*Faça um programa que calcule a diferença entre a soma dos quadrados dos primeiros
100 numeros naturais e o quadrado da soma.
Ex: A soma dos quadrados dos dez primeiros numeros naturais é:
	1^2+2^2+...+10^2=385
O quadrado da soma dos dez primeiros numeros naturais é :
	(1+2+....+10)^2=552=3025
A diferença entre a soma dos quadrados dos dez primeiros numeros naturais e o quadrado da soma é
	3025-385 =2640
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    class Program
    {
        static void Main(string[] args)
        {
            double somaQuad = 0, quaSoma = 0;

            for(double x = 1; x <= 100; x++)
            {
                somaQuad += Math.Pow(x, 2);
            }
            for (double x = 1; x <= 100; x++)
            {
                quaSoma += x;
            }

            Console.WriteLine("Soma dos quadrados: " + somaQuad);
            Console.WriteLine("Quadrado da soma: " + quaSoma);
            Console.WriteLine("Resultado da diferença: " + ((Math.Pow(quaSoma, 2) - somaQuad)));

            Console.ReadKey();
        }
    }
}
