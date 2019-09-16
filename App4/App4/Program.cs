/*Faça um programa que leia três números inteiros positivos e efetue o
cálculo de uma das seguintes medias de acordo com um valor numérico
digitado pelo usuário

A)Geometrica 
B)Pondera  
C)Harmonica  
D)Aritimetica
*/ 

using System;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa apresentando a media de acordo com 3 valores de entrada.");
            int valor, i = 1;
            double geometrica, ponderada, harmonica, aritimetica, x = 0, y = 0, z = 0;
            try
            {
                do
                {
                    Console.WriteLine("Entre com o " + i + "° numero positivo maior que 0");
                    valor = Convert.ToInt32(Console.ReadLine());

                    if (valor <= 0)
                    {
                        Console.WriteLine("Valor digitado é invalido!");
                        i--;
                    }
                    else
                    {
                        switch (i)
                        {
                            case 1:
                                x = valor;
                                break;
                            case 2:
                                y = valor;
                                break;
                            case 3:
                                z = valor;
                                break;

                        }
                    }
                    i++;

                } while (i != 4);
                Console.WriteLine("X: " + x);
                Console.WriteLine("Y: " + y);
                Console.WriteLine("Z: " + z);
                geometrica = Math.Pow((x * y * z), (1.0 / 3.0));
                Console.WriteLine("Media Geométrica: " + geometrica);
                ponderada = (x + (2 * y) + (3 * z)) / 6;
                Console.WriteLine("Media Ponderada: " + ponderada);
                harmonica = 1 / ((1 / x) + (1 / y) + (1 / z));
                Console.WriteLine("Media Harmônica: " + harmonica);
                aritimetica = (x + y + z) / 3;
                Console.WriteLine("Media Aritimética: " + aritimetica);


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
