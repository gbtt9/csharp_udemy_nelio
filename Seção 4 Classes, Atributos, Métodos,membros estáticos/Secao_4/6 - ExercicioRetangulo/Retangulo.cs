using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___ExercicioRetangulo
{
    public class Retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            double area = (largura * altura);
            return area;
        }

        public double Perimetro()
        {
            return 2 * (largura + altura);
        }

        public double Diagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(largura,2) + Math.Pow(altura, 2));
            return diagonal;
        }
    }
}
