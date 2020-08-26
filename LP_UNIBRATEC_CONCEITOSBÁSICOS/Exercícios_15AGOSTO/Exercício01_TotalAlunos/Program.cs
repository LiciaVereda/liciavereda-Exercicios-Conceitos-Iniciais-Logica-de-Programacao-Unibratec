using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01_TotalAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int qtdeAlunos1, qtdeAlunos2, qtdeAlunos3, qtdeAlunos4, totalAlunos;
            

            Console.Write("Digite o número de alunos do curso 01: ");
            qtdeAlunos1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de alunos do curso 02: ");
            qtdeAlunos2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de alunos do curso 03: ");
            qtdeAlunos3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de alunos do curso 04: ");
            qtdeAlunos4 = Convert.ToInt32(Console.ReadLine());

            totalAlunos = (qtdeAlunos1 + qtdeAlunos2 + qtdeAlunos3 + qtdeAlunos4);
            Console.WriteLine("O número de alunos da instituição é: " + totalAlunos);
            Console.ReadKey();
            

            



        }
    }
}
