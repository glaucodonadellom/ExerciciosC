/*.Faça um programa que leia dois vetores de 10 posições, via teclado, e
calcule outro vetor contendo, nas posições pares os valores do primeiro e
nas posições impares os valores do segundo.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[10];

            for (int x=0; x <10;x++)
            {
                Console.WriteLine("Digite o valor da "+(x+1)+"ª possicao do vetor 1:");
                vetor1[x]=Convert.ToInt32(Console.ReadLine());
            }
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Digite o valor da " + (x + 1) + "ª possicao do vetor 2:");
                vetor2[x] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("Resultado final do vetor 3:");
            for (int x = 0; x < 10; x++)
            {
                if ((x % 2) == 0)
                {
                    vetor3[x] = vetor1[x];
                    Console.WriteLine(vetor3[x]);
                }
                else
                {
                    vetor3[x] = vetor2[x];
                    Console.WriteLine(vetor3[x]);
                }
            }
            Console.ReadKey();
        }
    }
}
