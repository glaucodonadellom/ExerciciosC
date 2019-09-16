/*Faça um programa que leia um número inteiro positivo de três dígitos (de
100 a 999). Gere outro número formado pelos dígitos invertidos do
número lido. Exemplo:
Numero lido = 123
numerogerado =321
*/

using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que inverte os numeros digitados.");
            int valor = 0, unidade, dezena, centena, resultado;
            try
            {
                do
                {
                    Console.WriteLine("Entre com um numero positivo de 3 digitos,");
                    Console.WriteLine("Numero de 100 a 999.");
                    valor = Convert.ToInt32(Console.ReadLine());

                    if (valor < 100 || valor > 999)
                    {
                        Console.WriteLine("Valor digitado é invalido!");
                    }
                } while (valor < 100 || valor > 999);
                unidade = valor / 100;
                dezena = (valor % 100) / 10;
                centena = ((valor % 100) % 10) / 1;
                Console.WriteLine("valor digitado:  " + valor);
                resultado = (centena * 100) + (dezena * 10) + (unidade);
                Console.WriteLine("valor inverso :  " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado não é valido");

            }
            //            Console.WriteLine(unidade);
            //            Console.WriteLine(dezena);
            //            Console.WriteLine(centena);
            finally
            {
                Console.WriteLine("pressione qualquer tecla para sair");
                Console.ReadKey();
            }
        }
    }
}
