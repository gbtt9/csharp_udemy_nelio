using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _3_Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa(); 
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome:");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade:");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome:");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Idade:");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Pessoa mais velha " + pessoa1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha " + pessoa2.nome);
            }
            */

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome:");
            f1.nome = Console.ReadLine();
            Console.Write("Salário:");
            f1.salario = double.Parse(Console.ReadLine());


            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome:");
            f2.nome = Console.ReadLine();
            Console.Write("Salário:");
            f2.salario = double.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
