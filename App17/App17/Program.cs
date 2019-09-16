/*Faça um programa que conte quantos números primos existem entre a e
b, onde a e b são números informados pelo usuário.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Digite o valor do Primeiro numero:");
            numero1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do Segundo numero:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            int primos=0, validaPrimo = 0;
            
            for(int y = numero1; y <= numero2; y++)
            {
                validaPrimo = 0;
                for (int i = 1; i <= y; i++)
                {
                    if ((y % i) == 0)
                    {
                        validaPrimo++;
                    }
                    if (validaPrimo > 2)
                    {
                        break;
                    }
                    if (validaPrimo == 2 && y == i)
                    {
                        primos++;
                        break;
                    }
                }

            }
            Console.WriteLine("Ha " + primos + " primos entre os numeros " + numero1 + " e o nuemro " + numero2);


            
            Console.ReadKey();
        }
    }
}
