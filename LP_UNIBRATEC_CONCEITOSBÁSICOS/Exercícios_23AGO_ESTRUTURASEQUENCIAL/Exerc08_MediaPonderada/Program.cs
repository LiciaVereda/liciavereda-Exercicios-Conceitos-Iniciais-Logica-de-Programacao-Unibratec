using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc08_MediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            const int peso1 = 2, peso2 = 3, peso3 = 5;
            double nota1, nota2, nota3, media;

            //Entrada
            try
            {
                Console.Write("Digite o valor da nota1: ");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o valor da nota2: ");
                nota2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o valor da nota3: ");
                nota3 = Convert.ToDouble(Console.ReadLine());
            }

            catch
            {
                Console.Write("Digite valores númericos e sem espaços");
                Console.ReadKey();
                return;
            }

            //Processamento
                 media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);

            //Saída

                Console.WriteLine();
                Console.WriteLine("A média do aluno é: {0:F2}", media);
                Console.ReadKey();

                
        }
    }
}
