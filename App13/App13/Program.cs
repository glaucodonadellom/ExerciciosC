/*.O funcionário chamado Carlos tem um colega chamado João que recebe
um salário que equivale a um terço do seu salário. Carlos gosta de fazer
aplicações na caderneta de poupança e vai aplicar seu salário
integralmente nela, pois está rendendo 2% ao mês.
João aplicará seu salário integralmente no fundo de renda fixa, que está
rendendo 5% ao mês. Construa um programa que deverá calcular e
mostrar a quantidade de meses necessários para que o valor pertencente
a João iguale ou ultrapasse o valor pertencente a Carlos. Teste com
outros valores para as taxas (mais dois valores).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13
{
    class Program
    {
        static void Main(string[] args)
        {
            // carlos 1/1 = tudo na puoupança = rende 2% 
            //     joao 1/3 = renda fixa = rende 5%
            int  loop=0;
            double  iC = 0.02,  iJ = 0.05 ;

            while (loop < 1)
            {
                int meses = 0;
                double mC = 1, cC = 0, nC = 0, mJ = 0, cJ = 0, nJ = 0;

                Console.WriteLine("Qual o salario do carlos?");
                cC = Convert.ToDouble(Console.ReadLine());
                cJ = cC / 3;

                // m = c.(1+i)^n

                while (mC > mJ)
                {
                    meses++;
                    mC = cC * Math.Pow((1 + iC), meses);
                    Console.WriteLine("carlos " + mC);
                    mJ = cJ * Math.Pow((1 + iJ), meses);
                    Console.WriteLine("joao " + mC);
                }

                Console.WriteLine("\n\nMeses necessario para que os redimentos de Joao ultrapassem o de Carlos: " + meses);


                Console.ReadKey();

                Console.Clear();

                //Questiona sobre troca de valores de juros, se deseja ou nao auteralos, se a resposta for nao, finaliza o programa
                Console.WriteLine("Deseja alterar os valores dos juros? (0 = não | 1 = sim)");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Console.WriteLine("Digite o juros para aplicação de Carlos:");
                    iC = (Convert.ToDouble(Console.ReadLine()))/100;
                    Console.WriteLine("Digite o juros para aplicação de João:");
                    iJ = (Convert.ToDouble(Console.ReadLine())) / 100;
                }
                else {break; }
            }






            
        }
    }
}
