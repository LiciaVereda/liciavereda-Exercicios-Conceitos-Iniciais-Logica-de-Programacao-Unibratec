using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc24_AumentoSalarial
{
    class Program
    {
        static void Main(string[] args)
        {


            //Declaração
            double salarioMensal, percentualReajuste, novoSalario;

            //Entrada

            try
            {
                Console.Write("Digite o salário mensal: ");
                salarioMensal = Convert.ToDouble(Console.ReadLine());


                Console.Write("Digite o percentual de reajuste: ");
                percentualReajuste = Convert.ToDouble(Console.ReadLine());



            }

            catch
            {
                Console.Write("");
                Console.Write("Digite valores númericos.");
                Console.ReadKey();
                return;

            }

            //Processamento

            novoSalario = salarioMensal + (salarioMensal * percentualReajuste / 100);


            //Saída

            Console.Write();
            Console.Write("Após o reajuste o novo salário é : R$ {0,2:N}", novoSalario);
            Console.ReadKey();

        }
    }
}