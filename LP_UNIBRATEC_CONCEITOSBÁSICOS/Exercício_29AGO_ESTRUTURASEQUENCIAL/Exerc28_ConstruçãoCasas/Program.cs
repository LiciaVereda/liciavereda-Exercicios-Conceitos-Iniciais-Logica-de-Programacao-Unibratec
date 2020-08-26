using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc28_ConstruçãoCasas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração
            const double verba = 100000000;
            double salarioMinimo, custoTotalCasa, custoCasa, qtdeCasaConstruida, saldoFinalVerba;
           

            //Entrada

            try
            {
                Console.Write("Digite o valor do Salário Mínimo R$: ");
                salarioMinimo = Convert.ToDouble(Console.ReadLine());
                     
            }

            catch
            {
                Console.WriteLine();
                Console.Write("Digite valores númericos.");
                Console.ReadKey();
                return;

            }

            //Processamento

            custoCasa = 150 * salarioMinimo;
         
            qtdeCasaConstruida = Math.Truncate(verba / custoCasa);
           
            custoTotalCasa = qtdeCasaConstruida * custoCasa;

            saldoFinalVerba = verba - custoTotalCasa;


            //Saída

            Console.WriteLine();
            Console.WriteLine("A quantidade aproximada de casas a serem construídas é de: {0:F4}", qtdeCasaConstruida);
            Console.WriteLine("O saldo final da verba após a construção das casas é de: R$ {0:N5}", saldoFinalVerba);
            Console.ReadKey();


        }
    }
}
