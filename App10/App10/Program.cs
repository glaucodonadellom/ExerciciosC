/*Escreva um programa que verifique quais números entre 1000 e 9999
(inclusive) possuem a propriedade seguinte: a soma dos dois dígitos de
mais baixa ordem com os dois dígitos de mais alta ordem elevada ao
quadrado e igual ao próprio número.
Por exemplo, para o inteiro 3025, temos que:
30 + 25 = 55
552 = 3025
*/

using System;

namespace App10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que verifica se a soma dos dois dígitos de mais baixa ordem com os dois dígitos de mais alta ordem elevada ao quadrado é igual ao próprio número");
            Console.WriteLine("O intervalo entre os numeros é 1000 e 9999:");
            int valor, digito1, digito2;
            double potencia, soma;
            try
            {
                for (valor = 1000; valor <= 9999; valor++)
                {
                    soma = 0;
                    digito1 = valor / 100;
                    digito2 = valor % 100;
                    soma = digito1 + digito2;
                    potencia = Math.Pow(soma, 2);
                    if (potencia == valor)
                    {
                        Console.WriteLine("O valor " + valor + " é igual a sua soma elevada ao quadrado");
                    }
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
