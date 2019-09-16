/*Leia um vetor com 20 números inteiros, via teclado. Escreva os elementos
do vetor eliminando elementos repetidos.
*/

using System;

namespace App22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que efetua a entrada de 20 numeros e depois mostra os numeros eliminando as entradas repetidas");
            int[] valor = new int[20];
            int[] comp = new int[20];
            int j = 0, i = 0,k=0, valid = 0, soma = 0;
            try
            {
                do
                {
                    Console.WriteLine("Entre com " + (i + 1) + "º numero: ");

                    valor[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("valor digitado é " + valor[i]);
                    i++;

                } while (i < valor.Length);
                for (i = 0; i < valor.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("vetor1 :" + comp[j] );
                        Console.WriteLine("vetor2 :" + valor[i]);
                        comp[j] = valor[i];
                        j++;
                       
                    } else{
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
                    Console.Write(comp[i]+"\t");
                    
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
