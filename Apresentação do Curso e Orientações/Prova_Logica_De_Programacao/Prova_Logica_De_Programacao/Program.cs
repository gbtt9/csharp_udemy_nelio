using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Prova_Logica_De_Programacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago*/

            double codigopeca1 = double.Parse(Console.ReadLine());
            double qtdpeca1 = double.Parse(Console.ReadLine());
            double valorpeca1 = double.Parse(Console.ReadLine());

            double codigopeca2 = double.Parse(Console.ReadLine());
            double qtdpeca2 = double.Parse(Console.ReadLine());
            double valorpeca2 = double.Parse(Console.ReadLine());

            double valortotal = (qtdpeca1 * valorpeca1) + (qtdpeca2 * valorpeca2);

            Console.WriteLine(valortotal.ToString("F2"));
        
        }
    }
}
