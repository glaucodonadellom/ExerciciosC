/*Faça um programa que leia dois vetores de 10 elementos, via teclado.
Crie um vetor que seja a intersecção entre os 2 vetores anteriores, ou
seja, que contém apenas os números que estão em ambos os vetores.
Não deve conter números repetidos.
*/

using System;

namespace App28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que efetua a entrada de 2 vetores de 10 posiçoes e depois mostra a intersecção\n dos numeros eliminando as entradas repetidas\n");
            int[] valor = new int[10];
            int[] valor2 = new int[10];
            int[] comp = new int[10];
            int[] comp2 = new int[10];
            int[] inter = new int[20];
            int j = 0, i = 0, k = 0, soma = 0, vet1=0, vet2=0;
            try
            {
                do
                {
                    if (i < valor.Length && j==0)
                    {
                        Console.WriteLine("Entre com " + (i + 1) + "º numero do " + (j + 1) + " Vetor");
                        valor[i] = Convert.ToInt32(Console.ReadLine());
                        i++;
                    }else if(j==0)
                    {
                        i = 0;
                        j++;
                        
                    }
                    if(i<valor2.Length && j == 1)
                    {
                        Console.WriteLine("Entre com " + (i + 1) + "º numero do " + (j + 1) + " Vetor");
                        valor2[i] = Convert.ToInt32(Console.ReadLine());
                        i++;
                    }else if (j == 1)
                    {
                        j++;
                    }
                } while (j!=2);
                j = 0;
                for (i = 0; i < valor.Length; i++)
                {
                    if (i == 0)
                    {
                        //Console.WriteLine("vetor1 :" + comp[j]);
                        //Console.WriteLine("vetor2 :" + valor[i]);
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
                    vet1 = j;
                }
                j = 0;
                for (i = 0; i < valor2.Length; i++)
                {
                    if (i == 0)
                    {
                        //Console.WriteLine("vetor1 :" + comp2[j]);
                        //Console.WriteLine("vetor2 :" + valor2[i]);
                        comp2[j] = valor2[i];
                        j++;

                    }
                    else
                    {
                        soma = 0;
                        for (k = 0; k < j; k++)
                        {
                            if (valor2[i] == comp2[k])
                            {
                                soma++;
                            }
                        }
                        if (soma < 1)
                        {
                            comp2[j] = valor2[i];
                            j++;
                        }
                    }
                    vet2 = j;
                }
                Console.WriteLine("Vetor1 sem igualdades: ");
                for (i = 0; i < vet1; i++)
                {
                    Console.Write(comp[i] + "\t");
                }
                Console.WriteLine("\nVetor2 sem igualdades: ");
                for (i = 0; i < vet2; i++)
                {
                    Console.Write(comp2[i] + "\t");
                }
                Console.WriteLine("\nIntersecção dos vetores é: ");
                k = 0;
                for (i = 0; i < comp.Length; i++)
                    {
                    for (j = 0; j < comp2.Length; j++)
                    {
                        if (comp[i] == comp2[j])
                        {
                            inter[k] = comp[i];
                            k++;
                        }
                    }
                }
                for (i = 0; i < k; i++)
                {
                    Console.Write(inter[i] + "\t");
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
