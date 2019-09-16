/*Faça um programa que leia dois vetores de 10 elementos.Crie um vetor
que seja a união entre os 2 vetores anteriores, ou seja, que contém os
números dos dois vetores.Não deve conter números repetidos
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];

            int[] vetor3 = new int[20];
            for (int x = 0; x < 10; x++)
            {
                vetor3[x] = 0;
            }




            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Digite o valor da " + (x + 1) + "ª possicao do vetor 1:");
                vetor1[x] = Convert.ToInt32(Console.ReadLine());
            }
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Digite o valor da " + (x + 1) + "ª possicao do vetor 2:");
                vetor2[x] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            for (int x = 0; x < 10; x++)
            {
                vetor3[x] = vetor1[x];
            }
            for (int x = 10; x < 20; x++)
            {
                vetor3[x] = vetor2[x-10];
            }


            Console.WriteLine("Resultado final do vetor 3:");
            for (int x = 0; x < 20; x++)
            {
                int validador_numero_repetido = 0;
                for (int y = 0; y< vetor3.Length;y++)
                {
                    validador_numero_repetido++;
                    if (vetor3[x] == vetor3[y] && y != x && y > x)
                    {   
                        //Console.WriteLine(vetor3[x]+"  O Número se repete!");
                        break;
                    }
                    if (validador_numero_repetido==20)
                    {
                        Console.WriteLine(vetor3[x]);
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
