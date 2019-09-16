/*Escreva um programa que leia um inteiro não negativo n e imprima a
soma dos n primeiros números primos.*/

using System;


namespace App16
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que soma os N numeros primos");
            int valor = 0, cont=0, i,primos=0, validaPrimo =0, k = 0;
            try
            {
                do
                {
                    Console.WriteLine("Entre com um numero positivo : ");

                    valor = Convert.ToInt32(Console.ReadLine());

                    if (valor <= 0)
                    {
                        Console.WriteLine("Valor digitado é invalido!");
                    }
                } while (valor <= 0);

                for (k=0; primos < valor; k++)
                {
                    validaPrimo = 0;
                    for (i = 1; i <= k; i++)
                    {
                        if ((k % i) == 0)
                        {
                            validaPrimo++;
                        }
                        if (validaPrimo > 2)
                        {
                            break;
                        }
                        if (validaPrimo == 2 && k == i)
                        {
                            primos++;
                            cont += i;
                            Console.WriteLine("Nº primo " + i);
                            break;
                        }
                    }

                }
                Console.WriteLine("A soma dos " + valor+" primos é: "+cont);
               
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
