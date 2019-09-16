/*Faça um programa que some quantos números primos existem entre a e
b, onde a e b são números informados pelo usuário.*/

using System;

namespace App18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que soma quantos numeros primos existe entre X e Y");
            int valor = 0, valor1 = 0, valor2 = 0, validaPrimo = 0, i = 1,primos=0,cont=0;
            try
            {
                do
                {
                    Console.WriteLine("Entre com "+i+" numero positivo : ");
                    
                    valor = Convert.ToInt32(Console.ReadLine());

                    if (valor <= 0)
                    {
                        Console.WriteLine("Valor digitado é invalido!");
                    }
                    else {
                        switch (i)
                        {
                            case 1:
                                valor1 = valor;
                                break;
                            case 2:
                                if (valor < valor1)
                                {
                                    valor2 = valor1;
                                    valor1 = valor;
                                }
                                else
                                {
                                    valor2 = valor;
                                }
                                break;
                        }
                        i++; }

                } while (i < 3);

                for (int y = valor1; y <= valor2; y++)
                {
                    validaPrimo = 0;
                    for (i = 1; i <= y; i++)
                    {
                        if ((y % i) == 0)
                        {
                            validaPrimo++;
                        }
                        if (validaPrimo > 2)
                        {
                            break;
                        }
                        if (validaPrimo == 2 && y == i)
                        {
                            primos++;
                            cont += i;
                            Console.WriteLine("Nº primo " + i);
                            break;
                        }
                    }

                }
                Console.WriteLine("A soma dos numeros primos entre " + valor1+ " e "+valor2+" é: "+cont);

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
