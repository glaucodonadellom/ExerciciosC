/*Leia dois vetores de inteiros x e y, cada um com 5 elementos
(assuma que o usuário não informa elementos repetidos).
Calcule e mostre os vetores resultantes em cada caso abaixo:
• Soma entre x e y: soma de cada elemento de x com o elemento da
mesma posição em y.
• Produto entre x e y: multiplicação de cada elemento de x com o elemento
da mesma posição em y.
• Diferença entre x e y: todos os elementos de x que não existam em y.
• Intersecção entre x e y: apenas os elementos que aparecem nos dois
vetores.
• União entre x e y: todos os elementos de x e todos os elementos de y
que não estão em x.
*/


using System;

namespace App30
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Programa que efetua a entrada de 2 vetores de 5 posiçoes e depois mostra:\nA soma entre as mesmas posições do vetor 1 e 2;\n" +
                "A multiplicação entre as mesmas posições do vetor 1 e 2;\nA diferença entre o vetor 1 e 2;\nA intersecção entre os vetores 1 e 2;\nA união dos vetors 1 e 2.\n");
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] comp = new int[5];
            int[] comp2 = new int[5];
            int[] inter = new int[10];
            int[] somav = new int[5];
            int[] produto = new int[5];
            int[] diferenca = new int[5];
            int[] uniao = new int[10];
            int j = 0, i = 0, k, h = 0, soma, vet1 = 0, vet2 = 0, valid;
            try
            {
                do
                {
                    if (i < vetor1.Length && j == 0)
                    {
                        Console.WriteLine("Entre com " + (i + 1) + "º numero do " + (j + 1) + " Vetor");
                        vetor1[i] = Convert.ToInt32(Console.ReadLine());
                        i++;
                    }
                    else if (j == 0)
                    {
                        i = 0;
                        j++;

                    }
                    if (i < vetor2.Length && j == 1)
                    {
                        Console.WriteLine("Entre com " + (i + 1) + "º numero do " + (j + 1) + " Vetor");
                        vetor2[i] = Convert.ToInt32(Console.ReadLine());
                        i++;
                    }
                    else if (j == 1)
                    {
                        j++;
                    }
                } while (j != 2);
                //remoção de numero repetidos
                j = 0;
                for (i = 0; i < vetor1.Length; i++)
                {
                    if (i == 0)
                    {
                        comp[j] = vetor1[i];
                        j++;

                    }
                    else
                    {
                        soma = 0;
                        for (k = 0; k < j; k++)
                        {
                            if (vetor1[i] == comp[k])
                            {
                                soma++;
                            }
                        }
                        if (soma < 1)
                        {
                            comp[j] = vetor1[i];
                            j++;
                        }
                    }
                    vet1 = j;
                }
                j = 0;
                for (i = 0; i < vetor2.Length; i++)
                {
                    if (i == 0)
                    {
                        comp2[j] = vetor2[i];
                        j++;
                    }
                    else
                    {
                        soma = 0;
                        for (k = 0; k < j; k++)
                        {
                            if (vetor2[i] == comp2[k])
                            {
                                soma++;
                            }
                        }
                        if (soma < 1)
                        {
                            comp2[j] = vetor2[i];
                            j++;
                        }
                    }
                    vet2 = j;
                }
                //Mostra os vetores
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
                //Magica !!! 
                k = 0;
                for (i = 0; i < comp.Length; i++)
                {
                    valid = 0;
                    for (j = 0; j < comp2.Length; j++)
                    {
                        somav[i] = vetor1[i] + vetor2[i];
                        produto[i] = vetor1[i] * vetor2[i];
                      
                        if (comp[i] == comp2[j])
                        {
                            inter[k] = comp[i];
                            k++;
                            valid++;
                        }
                       
                    }
                    uniao[i] = comp[i];
                    uniao[i+5] = comp2[i];
                    if (valid == 0)
                    {
                        diferenca[h] = comp[i];
                        h++;

                    }
                }
                //Soma
                Console.WriteLine("\nSoma dos vetores é: ");

                for (i = 0; i < 5; i++)
                {
                    Console.Write(somav[i] + "\t");
                }

                //Produto
                Console.WriteLine("\nProduto dos vetores é: ");

                for (i = 0; i < 5; i++)
                {
                    Console.Write(produto[i] + "\t");
                }

                //Diferença
                Console.WriteLine("\nDiferença do vetor 1 para o vetor 2  é: ");

                for (i = 0; i < h; i++)
                {
                    Console.Write(diferenca[i] + "\t");
                }

                //intersecção
                Console.WriteLine("\nIntersecção dos vetores é: ");
                
                for (i = 0; i < k; i++)
                {
                    Console.Write(inter[i] + "\t");
                }
                //Uniao
                Console.WriteLine("\nUnião dos vetores é: ");

                for (i = 0; i < 10; i++)
                {
                    Console.Write(uniao[i] + "\t");
                }
                Console.WriteLine("\n");
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
