using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ExercicioMembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;
    
    
        public static double Calculadora(double cotacao, double dolares)
        {
            double total = dolares * cotacao;
            return total + total * IOF / 100;
        }
    
    
    }
}
