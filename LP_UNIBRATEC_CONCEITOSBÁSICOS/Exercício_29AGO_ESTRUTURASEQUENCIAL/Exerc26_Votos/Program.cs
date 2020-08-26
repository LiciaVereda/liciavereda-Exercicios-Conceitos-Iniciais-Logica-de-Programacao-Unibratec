using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc26_Votos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração
            double votoBranco, votoValido, votoNulo, totalVoto, percentualBranco, percentualValido, percentualNulo;


            //Entrada

            try
            {
                Console.Write("Digite a quantidade de votos válidos: ");
                votoValido = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade de votos em branco: ");
                votoBranco = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade de votos nulos: ");
                votoNulo = Convert.ToDouble(Console.ReadLine());

            }

            catch
            {
                Console.Write("");
                Console.Write("Digite valores númericos.");
                Console.ReadKey();
                return;

            }

            //Processamento

            totalVoto = votoValido + votoBranco + votoNulo;

            percentualValido = votoValido / totalVoto;

            percentualBranco = votoBranco / totalVoto;

            percentualNulo = votoNulo / totalVoto;


            //Saida

            Console.WriteLine();
            Console.WriteLine(" O percentual de votos VÁLIDOS é: {0,0:P2}", percentualValido);
            Console.WriteLine(" O percentual de votos BRANCOS é: {0,0:P2}", percentualBranco);
            Console.WriteLine(" O percentual de votos NULOS é: {0,0:P2}", percentualNulo);
            Console.ReadKey();












        }
    }
}
