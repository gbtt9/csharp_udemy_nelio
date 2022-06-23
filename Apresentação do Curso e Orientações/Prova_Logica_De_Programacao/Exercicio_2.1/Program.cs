using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            int qtd;

            Console.WriteLine("Digite o código do produto");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto");
            qtd = int.Parse(Console.ReadLine());



            if (codigo == 1)
            {
                double preco = 4.0 * qtd;
                Console.WriteLine("Total: " + preco);
            }
            else if(codigo == 2)
            {
                double preco = 4.50 * qtd;
                Console.WriteLine("Total: " + preco.ToString("F2"));
            }
            else if(codigo == 3)
            {
                double preco = 5.0 * qtd;
                Console.WriteLine("Total: " + preco);
            } 
            else if(codigo == 4)
            {
                double preco = 2.0 * qtd;
                Console.WriteLine("Total: " + preco);
            }
            else if(codigo == 5)
            {
                double preco = 1.50 * qtd;
                Console.WriteLine("Total: " + preco.ToString("f2"));
            }
        }
    }
}
