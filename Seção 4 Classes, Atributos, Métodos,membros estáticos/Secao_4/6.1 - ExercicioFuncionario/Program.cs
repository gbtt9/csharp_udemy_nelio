using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _6._1___ExercicioFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var func = new Funcionario();
            
            Console.Write("Nome:");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto:");
            func.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Imposto:");
            func.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            //func com valor de salario sem aumento
            Console.WriteLine(func);

            Console.Write("Digite a porcentagem para aumentar o salário:");
            func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            //Func com valor de salário aumentado

            Console.WriteLine(func);     
        }
    }
}
