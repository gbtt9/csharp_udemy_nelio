using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 3.14159;

            Console.WriteLine("Escreva o valor do raio");
            double raio = double.Parse(Console.ReadLine());

            double area = r*(raio * raio);

            Console.WriteLine(area.ToString("F4"));
        }
    }
}
