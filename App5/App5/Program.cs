/*Escreva um programa que, dado o valor da venda, imprima a comissão
que deverá ser paga ao vendedor. Para calcular a comissão, considere a
tabela abaixo
Venda Mensal			Comissão
>=R$1000.000,00			R$700,00+16%dasvendas
<R$1000.000,00 && >=R$80.000,00	R$650,00+14%dasvendas
<R$80.000,00 && >=R$60.000,00	R$600,00+14%dasvendas
<R$60.000,00 && >=R$40.000,00	R$550,00+14%dasvendas
<R$40.000,00 && >=R$20.000,00	R$500,00+14%dasvendas
<R$20.000,00			R$400,00+14%dasvendas

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_da_venda = 0, valor_comissao = 0;
            //Nome do programa
            Console.WriteLine("Calculadora de comissões.\n\n");

            //Recebe o valor vendido e atribui valor a variavel (valor_da_venda)
            Console.WriteLine("Digite o valor da venda:");
            valor_da_venda = Convert.ToDouble(Console.ReadLine());



            //Bloco de verificação do valor da venda, e calculo de valor de comissao 
            if (valor_da_venda >= (1 * (Math.Pow(10, 5)))) 
            {
                valor_comissao = 700 + (valor_da_venda * 0.16);
            }
            else
            {
                if (valor_da_venda >= (8 * (Math.Pow(10, 4))))
                {
                    valor_comissao = 650 + (valor_da_venda * 0.14);
                }
                else
                {
                    if (valor_da_venda >= (6 * (Math.Pow(10, 4))))
                    {
                        valor_comissao = 600 + (valor_da_venda * 0.14);
                    }
                    else
                    {
                        if (valor_da_venda >= (4 * (Math.Pow(10, 4))))
                        {
                            valor_comissao = 550 + (valor_da_venda * 0.14);
                        }
                        else
                        {
                            if (valor_da_venda >= (2 * (Math.Pow(10, 4))))
                            {
                                valor_comissao = 500 + (valor_da_venda * 0.14);
                            }
                            else
                            {
                                if (valor_da_venda < (2 * (Math.Pow(10, 4))))
                                {
                                    valor_comissao = 400 + (valor_da_venda * 0.14);
                                }
                            }
                        }
                    }
                }
            }
            
            
            
            
            
            

            
            //Imprime resultado da comissão
            Console.WriteLine("\nO vendedor ira receber de comissão: \nR$" + valor_comissao);



            Console.ReadKey();
        }
    }
}
