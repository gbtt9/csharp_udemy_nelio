using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _6._2___ExercicioAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno alun = new Aluno(); 

            Console.Write("Nome do Aluno: ");
            alun.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            alun.Nota1 = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            alun.Nota2 = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            alun.Nota3 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            alun.NotaFinal();

        }
    }
}
