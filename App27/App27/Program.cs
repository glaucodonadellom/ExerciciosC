/*Leia 10 números inteiros, via teclado, e armazene em um vetor. Em
seguida escreva os elementos que são primos e suas respectivas
posições no vetor
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int vetor_possiao = 0;

            for (int x=0;x<10;x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + "º numero:");
                vetor[x] = Convert.ToInt32(Console.ReadLine());
            }
            for (int x = 0; x < 10; x++)
            {
                vetor_possiao++;
                int validaPrimo = 0;
                for (int i = 1; i <= vetor[x]; i++)
                {
                    
                    if ((vetor[x] % i) == 0)
                    {
                        validaPrimo++;
                    }
                    if (validaPrimo > 2)
                    {
                        break;
                    }
                    if (validaPrimo == 2 && vetor[x] == i)
                    {
                        Console.WriteLine("O Numero " + vetor[x]+" é primo e esta na " + vetor_possiao + "ª possição.");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
