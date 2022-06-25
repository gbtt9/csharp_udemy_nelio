using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;

            int n4 = 10 / 8;

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; //elevação

            double x1 = (-b + Math.Sqrt(delta)) / 2.0 * a; //raiz quadrada
            
            
            Console.WriteLine(n4);
            
            
        }
    }
}
