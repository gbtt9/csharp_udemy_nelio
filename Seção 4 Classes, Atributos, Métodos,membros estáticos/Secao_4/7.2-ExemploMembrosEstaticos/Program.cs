﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _7._2_ExemploMembrosEstaticos
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);


            Console.WriteLine("Circuferencia " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI:" + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

      




    }
}
