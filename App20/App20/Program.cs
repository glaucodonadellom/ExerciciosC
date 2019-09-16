/*Faça um programa que leia um vetor de 8 posições e, em seguida, leia
também dois valores X e Y quaisquer correspondentes a duas posições
no vetor. Ao final seu programa deverá escrever a soma dos valores
encontrados nas respectivas posições X e Y.*/

using System;

namespace App20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que efetua a entrada de 8 numeros e depois soma 2 posições escolhida pelo usuario");
            int[] valor = new int[8];
            int valor1 = 0, valor2 = 0, i = 0, valid = 0,soma=0;
            try
            {
                do
                {
                    Console.WriteLine("Entre com " + (i+1) + " numero: ");

                    valor[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("valor digitado é " + valor[i]);

                    i++;
                    
                } while (i < valor.Length);
                for (i = 1; i < 3; i++)
                {

                    Console.WriteLine("entre com um valor de 1 a 8");
                    Console.WriteLine("Entre com a posição " + (i) + "º");
                    valid = Convert.ToInt32(Console.ReadLine());
                    if (valid <0 || valid > 8)
                    {
                        Console.WriteLine("Valor digitado é invalido!");
                        i--;
                    }
                    else
                    {
                        switch (i)
                        {
                            case 1:
                                valor1 = valid;
                                break;
                            case 2:
                                valor2 = valid;
                                break;
                        }
                    }                
                }
                soma = valor[valor1-1] + valor[valor2-1];
                Console.WriteLine("A soma das posiçoes"+ (valor1) + " e " + (valor2) + " é: " + soma);

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
