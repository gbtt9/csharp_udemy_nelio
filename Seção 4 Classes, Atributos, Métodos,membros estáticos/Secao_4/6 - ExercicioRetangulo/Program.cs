using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___ExercicioRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo");
            ret.largura = double.Parse(Console.ReadLine());
            ret.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + ret.Area());

            Console.WriteLine("Area = " + ret.Perimetro());

            Console.WriteLine("Area = " + ret.Diagonal());

        }
    }
}
