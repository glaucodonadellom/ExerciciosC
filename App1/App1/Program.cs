/*Um sistema de equações lineares do tipo:
 | Ax+By = C
 | Dx+Ey = F
pode ser resolvido por meio das equações abaixo:
x = CE-BF/AE-BD 
e
y = AF-CD/AE-BD

Elabore um algoritmo que leia os coeficientes A, B, C, D, E e F e que calcule
e mostre os valores de x e y
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, x = 0, y = 0;


            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de E: ");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de F: ");
            f = Convert.ToDouble(Console.ReadLine());

            x = ((c * e) - (b * f)) / ((a * e) - (b * d));

            y = ((a * f) - (c * d)) / ((a * e) - (b * d));

            Console.WriteLine("x = " + x + "     y = " + y);
            Console.ReadKey();






            /*
            Boolean loop = false;
            
           
            while(!loop){
                Random rnd = new Random();
                int a = rnd.Next(1, 10000), b = rnd.Next(1, 10000), 
                    c = rnd.Next(1, 10000), d = rnd.Next(1, 10000),
                    e = rnd.Next(1, 10000), f = rnd.Next(1, 10000),
                    x = rnd.Next(1, 10000), y = rnd.Next(1, 10000);
                
                if ( (a * x) + (b * y) == c){
                    if ((d * x)+(e * y)==f)
                    {
                        if (x == ((c * e) - (b - f)) / ((a * e) - (b * d)) && y == ((a*f)-(c*d))/((a*e)-(b*d)))
                        {
                            Console.WriteLine("x = " + x + "    y = " + y);
                            Console.WriteLine("\n" + a + " " + b + " " + c + " " + d + " " + f);
                            Console.ReadKey();
                            Console.ReadKey();
                            Console.ReadKey();
                            loop = true;
                        }
                    }
                } 
            }*/
        }
    }
}
