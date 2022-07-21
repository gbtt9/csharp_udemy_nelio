using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2___ExercicioAluno
{
    internal class Aluno
    {
        public string Nome;
        public decimal Nota1;
        public decimal Nota2;
        public decimal Nota3;

        public void NotaFinal()
        {
            decimal notaFinal = Nota1 + Nota2 + Nota3;
            
            if(notaFinal > 60)
            {
               Console.WriteLine("Aprovado " + notaFinal);
            } else
            {
               Console.WriteLine("Reprovado faltam" + (notaFinal - 60));
            }
        }

        /*public override string ToString()
        {
            return Nome + NotaFinal();
        }*/

    }
}