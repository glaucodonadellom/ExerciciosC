/*Faça um programa para ler a nota da prova de 15 alunos e armazene num
vetor, calcule e imprima a média geral.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas= new double[15];
            double total=0;

            for (int contador=1;contador<=notas.Length;contador++)
            {
                Console.WriteLine("Digite a nota do aluno " + contador + ":");
                total += Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n\nA média da turma é " + Math.Round((total / notas.Length), 3));
            Console.ReadKey();
        }
    }
}
