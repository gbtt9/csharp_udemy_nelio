﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Entrada_De_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string frase = Console.ReadLine();

            Console.WriteLine(frase);

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();
            string[] vet = s.Split(' ');

            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(x);
            Console.WriteLine(y);   
            Console.WriteLine(z);
            */

            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);

            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(ch);

            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]); 
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            
        
        }
    }
}
