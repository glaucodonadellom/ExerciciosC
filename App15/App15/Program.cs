/*Faça um programa que receba um número inteiro maior do que 1, e
verifique se o número fornecido e primo ou não.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, validaPrimo=0;

            Console.WriteLine("Digite um numero para saber se é ou nao um numero primo: ");
            numero = Convert.ToInt32(Console.ReadLine());

          
            for(int i=1; i <= numero; i++)
            {
                if ((numero % i) == 0)
                {
                    validaPrimo++;
                }
                if (validaPrimo > 2)
                {
                    Console.WriteLine("O numero " + numero + " não é um numero primo!");
                    break;
                }
                if(validaPrimo==2 && numero == i)
                {
                    Console.WriteLine("O numero " + numero + " é um numero primo! Parabéns!");
                    break;
                }
            }
            Console.ReadKey();
            
        }
    }
}
