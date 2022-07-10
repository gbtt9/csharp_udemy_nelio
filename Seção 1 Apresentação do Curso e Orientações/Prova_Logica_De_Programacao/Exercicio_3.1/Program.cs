using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double senha = 2002;

            Console.WriteLine("Digite a senha");
            senha = double.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Digite a senha");
                senha = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");
            
        }
    }
}
