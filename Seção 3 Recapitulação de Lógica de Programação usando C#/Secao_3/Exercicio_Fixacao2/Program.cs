using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Fixacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            

            Console.WriteLine("Quantos quartos tem sua casa?");
            int qtdquartos = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre seu último nome, idade e altura(mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine(nome);
            Console.WriteLine(qtdquartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
        }
    }
}
