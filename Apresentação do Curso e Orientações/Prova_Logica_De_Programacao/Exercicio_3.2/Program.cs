using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nmr;
            int contadorin = 0;
            int contadorout = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os números: ");
                nmr = int.Parse(Console.ReadLine());

                if (nmr > 10 && nmr < 20)
                {
                    contadorin = contadorin + 1;
                }
                else
                {
                    contadorout = contadorout + 1;  
                }  
            }
            Console.WriteLine(contadorin);
            Console.WriteLine(contadorout);
        }
    }
}
