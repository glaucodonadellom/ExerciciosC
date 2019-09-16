/*Faça um programa que leia um vetor de 10 números via teclado. Leia um
número x. Conte os múltiplos de um número inteiro x num vetor e mostreos na tela.*/

using System;

namespace App24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que efetua a entrada de 10 numeros e depois efetua a leitura de mais 1 numero e conta os multiplos ");
            int[] valor = new int[10];
            int[] multiplos = new int[20];
            int num = 0, i = 0,j = 0;
            try
            {
                do
                {
                    Console.WriteLine("Entre com " + (i + 1) + "º numero: ");

                    valor[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("valor digitado é " + valor[i]);
                    i++;

                } while (i < valor.Length);
                Console.WriteLine("Entre com um valor ");
                num = Convert.ToInt32(Console.ReadLine());

                //mostrar os numeros multiplos do num no vetor

                for (i=0; i < valor.Length; i++)
                {
                    if (valor[i] % num == 0)
                    {
                        multiplos[j]= valor[i];
                        j++;
                    }
                }
                Console.WriteLine("os numeros multiplos são \n");
                for (i = 0; i < j; i++)
                {
                    Console.Write(multiplos[i]+"\t" );
                }
                Console.WriteLine("\n");


                /*
                for (i = 0; i < valor.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("vetor1 :" + comp[j]);
                        Console.WriteLine("vetor2 :" + valor[i]);
                        comp[j] = valor[i];
                        j++;

                    }
                    else
                    {
                        soma = 0;
                        for (k = 0; k < j; k++)
                        {
                            if (valor[i] == comp[k])
                            {
                                soma++;
                            }
                        }
                        if (soma < 1)
                        {
                            comp[j] = valor[i];
                            j++;
                        }
                    }
                    
                }
                Console.WriteLine("Vetor sem igualdades: ");
                for (i = 0; i < j; i++)
                {
                    Console.Write(comp[i] + "\t");

                }
                */
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
