/*Escreva um programa que leia um número inteiro positivo n e em seguida
imprima n linhas do chamado Triangulo de Floyd.
Para n = 6, temos
01
02 03
04 05 06 
07 08 09 10
11 12 13 14 15
16 17 18 19 20 21
*/

using System;

namespace App14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que mostra o Triangulo de Floyd");
            int valor = 0,cont,i,j,k ;
            try
            {
                do
                {
                    Console.WriteLine("Entre com um numero positivo : ");
                    
                    valor = Convert.ToInt32(Console.ReadLine());

                    if (valor <=0 )
                    {
                        Console.WriteLine("Valor digitado é invalido!");
                    }
                } while (valor<=0);
                j = valor * (valor + 1) / 2;
                cont = 1;
                Console.WriteLine("valor :"+j);
                for(i=1;i<= valor; i++){
                    for(k=1; k<i; k++){
                        Console.Write(cont++ +"\t");
                    }Console.WriteLine(cont++ + "\n");
                }
                            


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
