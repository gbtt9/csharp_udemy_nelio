using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Saida_De_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35785;
            string nome = "Maria";

            Console.WriteLine("Bom dia!"); //quebra de linha
            Console.Write("Boa tarde!");
            
            Console.WriteLine(genero);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
           
            //PlaceHolder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reias", nome,idade,saldo);
            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual {saldo:F2}");
            //Concatenação 
            Console.WriteLine(nome + "tem" + idade + "anos e tem saldo igual" + saldo.ToString("F2",CultureInfo.InvariantCulture) + "reais");;



        }
    }
}
