/*Três amigos jogaram na loteria. Caso eles ganhem, o prêmio deve ser
repartido proporcionalmente ao valor que cada deu para a realização da
aposta. Faça um programa que leia quanto cada apostador investiu, o
valor do prêmio, e imprima quanto cada um ganharia do prêmio com base
no valor investido.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            double premio = 0, aposta_amigo1 = 0, aposta_amigo2 = 0, aposta_amigo3 = 0;
            //titulo do programa
            Console.WriteLine("Calculadora de premio da loteria, de acordo com valor de aposta de amigos. \n\n");

            //Recebe e atribui valor a variavel (premio)
            Console.WriteLine("Digite o valor do premio:");
            premio = Convert.ToDouble(Console.ReadLine());


            //Recebe e atribui valores as variaveis (aposta_amigo(1,2 e 3))
            Console.WriteLine("\n\nDigite o valor apostado pelo amigo numero 1:");
            aposta_amigo1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\nDigite o valor apostado pelo amigo numero 2:");
            aposta_amigo2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\nDigite o valor apostado pelo amigo numero 3:");
            aposta_amigo3 = Convert.ToDouble(Console.ReadLine());

            //Limpa a tela
            Console.Clear();
            //Calcula a porcentagem do premio que cada amigo deve receber e a mostra na tela
            Console.WriteLine("\nO primeiro amigo deve receber: \nR$" + (premio * (0.01 * ((aposta_amigo1 * 100) / (aposta_amigo1 + aposta_amigo2 + aposta_amigo3)))));

            Console.WriteLine("\nO segundo amigo deve receber: \nR$" + (premio * (0.01 * ((aposta_amigo2 * 100) / (aposta_amigo1 + aposta_amigo2 + aposta_amigo3)))));

            Console.WriteLine("\nO terceiro amigo deve receber: \nR$" + (premio * (0.01 * ((aposta_amigo3 * 100) / (aposta_amigo1 + aposta_amigo2 + aposta_amigo3)))));


            Console.ReadKey();
        }
    }
}                 
                  