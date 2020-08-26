using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc05_AreaTrapézio
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseMaior, baseMenor, alturaTrapezio, areaTrapezio;

            //Entrada
            try
            {

                Console.Write("Digite o valor da base maior: ");
                baseMaior = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o valor da base menor: ");
                baseMenor = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o valor da altura: ");
                alturaTrapezio = Convert.ToDouble(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Digite valores númericos");
                Console.ReadKey();
                return;
            }

            //Processamento

            areaTrapezio = ((baseMaior + baseMenor) * alturaTrapezio) / 2;
            Console.WriteLine();

            Console.WriteLine(" A área do trapézio é de : {0:F} ", areaTrapezio);
            Console.ReadKey();
        }
    }
}
