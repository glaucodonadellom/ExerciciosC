/*.Faça um programa que leia vários números, calcule e mostre:
(a) A soma dos números digitados
(b) A quantidade de números digitados
(c) A média dos números digitados
(d) O maior número digitado
(e) O menor número digitado
(f) A média dos números pares
Finalize a entrada de dados caso o usuario informe o valor 0 (zero).*/
 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App19
{
    class Program
    {
        static void Main(string[] args)
        {
            double loop = 0, soma = 0, qtd = 0, qtd_pares=0, maior_digitado=0, menor_digitado=0, numero=0, soma_pares=0;
            double media = 0, media_pares = 0;

            while (loop < 1)
            {
                numero = 0;
                Console.WriteLine("Digite um número:");
                numero = Convert.ToDouble(Console.ReadLine());

                //a)
                soma += numero;
                //b)
                qtd++;
                //d)
                if (maior_digitado < numero)
                {
                    maior_digitado = numero;
                }
                //e)
                if (menor_digitado > numero && numero != 0 || menor_digitado == 0)
                {
                    menor_digitado = numero;
                }
                //f)
                if ((numero%2)==0)
                {
                    soma_pares += numero;
                    qtd_pares++;
                }


                if (numero == 0)
                {
                    qtd_pares--;
                    qtd--;
                    break;
                }
            }
            
            //c)
            media = soma / qtd;
            //f)
            media_pares = soma_pares / qtd_pares;



            Console.Clear();
            //a
            Console.WriteLine("A Soma dos Números digitados:\n" + soma);
            //b
            Console.WriteLine("A quantidade de números digitados:\n" + qtd);
            //c
            Console.WriteLine("a Média dos números digitados:\n" + Math.Round( media, 2));
            //d
            Console.WriteLine("O maior número digitado:\n" + maior_digitado);
            //e
            Console.WriteLine("O menor número digitado:\n" + menor_digitado);
            //f
            Console.WriteLine("A média dos números pares:\n" +Math.Round( media_pares, 2));




            Console.ReadKey();
                
        }
    }
}
