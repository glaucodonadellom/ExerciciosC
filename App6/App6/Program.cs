/*Escreva um programa que leia um número inteiro e calcule a soma de
todos os divisores desse número, com exceção dele próprio.
Ex: a soma dos divisores do número 66 é
1 + 2 + 3 + 6 + 11 + 22 + 33 = 78
*/

using System;

namespace App6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que mostra a soma dos divisores do numero digitado");
            int valor,soma=0 ;
            try
            {
                Console.WriteLine("Entre com um inteiro:");
                valor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("valor digitado:  " + valor);
                Console.WriteLine("os divisores são: " );
                for (int i = 1; i < valor; i++){
                    //Console.WriteLine("divisao: "+valor % i +" Valor i: " +i);

                    if (valor % i == 0) { 
                        Console.Write(i +"; ");
                        soma += i;
                    }
                }                 
                Console.WriteLine("\nA soma dos diviores é " + soma);
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
