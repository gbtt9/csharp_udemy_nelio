using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios_Propostos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercicio 01
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int total = a + b;

            Console.WriteLine("Soma = " +total);
            */

            /*Exercicio 02
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine());

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
            */


            /*Exercicio 03
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);
            Console.WriteLine("Diferenca = " +diferenca);
            */

            /*Exericio 04
            int nmr = int.Parse(Console.ReadLine());
            int nmrhoras = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salario = nmrhoras * valor;

            Console.WriteLine("NUMBER = " + nmr);
            Console.WriteLine("SALARY = " + salario.ToString("F2"));
            */

            /*Exercicio 05
            int codigo1 = int.Parse(Console.ReadLine());
            int qtdpeca1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vlruni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int codigo2 = int.Parse(Console.ReadLine());
            int qtdpeca2 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double vlruni2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total1 = qtdpeca1 * vlruni;
            double total2 = qtdpeca2 * vlruni2;

            Console.WriteLine("Valor a pagar: " + (total1 + total2).ToString("F2"));
            */
        }
    }
}
