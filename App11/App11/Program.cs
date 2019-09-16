/*Faça um programa que apresente um menu de opções para o cálculo das
seguintes operações entre dois números:
• adição (opção 1)
• subtração (opção 2)
• multiplicação (opção 3)
• divisão (opção 4).
• saída (opção 5)
O programa deve possibilitar ao usuário a escolha da operação desejada,
a exibição do resultado e a volta ao menu de opções. O programa só
termina quando for escolhida a opção de saída (opção 5)
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, x = 0; 
            double valor1, valor2;

            while( x < 1)
            {   

                Console.WriteLine("Escolha a Operação de deseja fazer:" +
                                "\n 1 = adição " +
                                "\n 2 = subtração" +
                                "\n 3 = multiplicação" +
                                "\n 4 = divisão" +
                                "\n 5 = sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 5) { break; }
                Console.WriteLine("Digite o Primeiro Valor:");
                valor1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o Segundo Valor:");
                valor2 = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("A soma tem como resultado: " + (valor1 + valor2));
                        break;
                    case 2:
                        Console.WriteLine("A subtração tem como resultado: " + (valor1 - valor2));
                        break;
                    case 3:
                        Console.WriteLine("A multiplicação tem como resultado: " + (valor1 * valor2));
                        break;
                    case 4:
                        Console.WriteLine("A divisão tem como resultado: " + (valor1 / valor2));
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            
                

        }


    }
}
