/*Faça um programa que some os números impares contidos em um
intervalo definido pelo usuário. O usuário define o valor inicial do intervalo
e o valor final deste intervalo e o programa deve somar todos os números
ímpares contidos neste intervalo. Caso o usuário digite um intervalo
inválido (começando por um valor maior que o valor final) deve ser escrito
uma mensagem de erro na tela, “Intervalo de valores invalido” e o
programa termina.
Exemplo de tela de saída:
Digite o valor inicial e valor final: 5 10
Soma dos ´ımpares neste intervalo: 21
*/

using System;

namespace App8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que soma o intervalo de valores impares digitado pelo usuario");
            int valor1, valor2, soma = 0;
            try
            {
                Console.WriteLine("Entre com um valor inteiro:");
                valor1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entre com outro valor inteiro:");
                valor2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Intervalo entre " + valor1 + " e " + valor2 +" :");
                if( valor1 > valor2)
                {
                    Console.WriteLine("Intervalo de valores invalido!");
                }else
                for (int i = valor1; i <=valor2; i++){
                    if(i%2!= 0){
                        soma += i;
                    }
                    
                }
                Console.WriteLine("\nA soma dos impares neste intervalo " + soma);
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
