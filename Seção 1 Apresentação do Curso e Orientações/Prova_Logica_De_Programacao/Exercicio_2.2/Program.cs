using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o coeficiencete A");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o coeficiencete B");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o coeficiencete C");
            double c = double.Parse(Console.ReadLine());

            if (a != 0)
            {
                double delta = (b * b) - 4 * (a * c);

                if (delta >= 0)
                {
                    double x1 = (-b + Math.Floor(Math.Sqrt(delta))) / 2 * a ;
                    double x2 = (-b - Math.Floor(Math.Sqrt(delta))) / 2 * a;

                    Console.WriteLine("X1" + x1);
                    Console.WriteLine("X2" + x2);
                }
                else
                {
                    Console.WriteLine("Impossível Calcular");
                }
            }
            else
            {
                Console.WriteLine("Impossível Calcular");
            }
        }
    }
}
