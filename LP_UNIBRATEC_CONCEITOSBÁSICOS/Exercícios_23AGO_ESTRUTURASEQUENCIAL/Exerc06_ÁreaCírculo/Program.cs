using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc06_ÁreaCírculo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi= 3.14;
            double raioCirculo, areaCirculo;

            //Entrada
            try
            {

                Console.Write("Digite o valor do raio do círculo: ");
                raioCirculo = Convert.ToDouble(Console.ReadLine());
                
            }

            catch
            {
                Console.WriteLine("Digite valores númericos");
                Console.ReadKey();
                return;
            }

            //Processamento

            areaCirculo = (raioCirculo * raioCirculo)*pi;

            //Saída
            Console.WriteLine();
            Console.WriteLine(" A área do circulo é de : {0:F} ", areaCirculo);
            Console.ReadKey();
        }
    }
}
