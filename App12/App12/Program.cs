/*Faça um programa que some os termos de valor par da sequência de
Fibonacci, cujos valores não ultrapassem quatro milhões.
*/

using System;

namespace App12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa soma os numeros pares da sequencia de Fibonacci");
            int soma = 1, digito1 = 1, digito2 = 1, i, valor=0;
            
            try
            {
                for (i = 1; soma < 4000000; i++)
                {

                    digito1 = soma;
                    soma = digito1 + digito2;
                    digito2 = digito1;
                    if (soma % 2 == 0)
                    {
                        valor += soma;
                    }
                }
                Console.WriteLine("A soma dos numeros pares termo é: " + valor);

            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado não é valido");

            }
            finally
            {
                Console.WriteLine("pressione qualquer tecla para sair");
                Console.ReadKey();
            }
        }
    }
}
