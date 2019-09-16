/*Ler dois conjuntos de números reais, via teclado, armazenando-os em
vetores e calcular o produto escalar entre eles. Os conjuntos têm 5
elementos cada. Imprimir os dois conjuntos e o produto escalar, sendo
que o produto escalar e dado por:
x1*y1 + x2*y2+.....+xN*yN.
*/

using System;

namespace App26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que efetua a entrada de 2 valores e imprime os dois conjuntos e o produto escalar\n");
            Double[] valor = new double[5];
            Double[] valor2 = new double[5];
            Double escalar=0;
            int j = 0, i = 0;
            try
            {
                do
                {
                    if (i < valor.Length && j == 0)
                    {
                        Console.WriteLine("Entre com " + (i + 1) + "º numero do " + (j + 1) + " Vetor");
                        valor[i] = Convert.ToDouble(Console.ReadLine());
                        i++;
                    }
                    else if (j == 0)
                    {
                        i = 0;
                        j++;

                    }
                    if (i < valor2.Length && j == 1)
                    {
                        Console.WriteLine("Entre com " + (i + 1) + "º numero do " + (j + 1) + " Vetor");
                        valor2[i] = Convert.ToDouble(Console.ReadLine());
                        i++;
                    }
                    else if (j == 1)
                    {
                        j++;
                    }
                } while (j != 2);
                for (i = 0; i < valor.Length; i++)
                {
                    escalar += valor[i] * valor2[i];
                }
                Console.Write("\nVetor 1: \n");
                for (i = 0; i < valor.Length; i++)
                {
                    Console.Write(valor[i] + "\t");
                }
                Console.Write("\nVetor 2: \n");
                for (i = 0; i < valor.Length; i++)
                {
                    Console.Write(valor2[i] + "\t");
                }
                Console.Write("\nProduto escalar : \n"+escalar);

            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado não é valido");

            }

            finally
            {
                Console.WriteLine("\npressione qualquer tecla para sair");
                Console.ReadKey();
            }
        }
    }
}
