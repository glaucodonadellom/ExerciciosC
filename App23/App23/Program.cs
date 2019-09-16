/*Faça um programa que leia um vetor de 5 posições via teclado para
números reais e, depois, um código inteiro. Se o código for zero, finalize
o programa; se for 1, mostre o vetor na ordem direta; se for 2, mostre o
vetor na ordem inversa. Caso o código for diferente de 1 e 2 ´ escreva
uma mensagem informando que o código é inválido
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App23
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[5];
            int  loop=0;
            for(int x = 0; x < vetor.Length; x++)
            {
                Console.WriteLine("digite o " + ( x + 1) + "º numero:");
                vetor[x] = Convert.ToDouble(Console.ReadLine());
            }

            while (loop < 1)
            {
                
                int codigo = 0;
                Console.WriteLine("\n\nDigite o codigo de função:" +
                    "\n 0 = sair" +
                    "\n 1 = mostra vetor na ordem" +
                    "\n 2 = mostra vetor na ordem inversa");
                codigo = Convert.ToInt32(Console.ReadLine());

                if (codigo == 0)
                {
                    break;
                }

                if (codigo == 1)
                {
                    Console.WriteLine("Mostra vetor na ordem:");
                    for (int y = 0; y < vetor.Length; y++)
                    {
                        Console.WriteLine(vetor[y]);
                    }
                }
                if (codigo == 2)
                {
                    Console.WriteLine("Mostra vetor na ordem inversa: ");
                    for (int y= (vetor.Length-1); y >= 0; y--)
                    {
                        Console.WriteLine(vetor[y]);
                    }
                }
                Console.ReadKey();
                Console.Clear();

            }
            
        }
    }
}
