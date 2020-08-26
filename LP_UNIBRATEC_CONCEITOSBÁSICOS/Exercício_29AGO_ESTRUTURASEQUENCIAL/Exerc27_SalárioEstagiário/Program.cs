using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc27_SalárioEstagiário
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração
            const int dia = 30;
            const double percentualDesconto = 0.10;
            int duracaoEstagioDias,duracaoEstagioMeses;
            double salarioBrutoMensal, salarioBrutoTotal, descontoMensal, salarioLiquidoMensal;

            //Processamento
            try
            {
                Console.Write("Digite o salário bruto mensal do estagiário: ");
                salarioBrutoMensal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite de quantos meses é o estágio: ");
                duracaoEstagioMeses = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.Write();
                Console.Write("Digite valores númericos.");
                Console.ReadKey();
                return;
            }

            //Processamento

            duracaoEstagioDias = duracaoEstagioMeses * dia;
            salarioBrutoTotal = salarioBrutoMensal * duracaoEstagioMeses;
            descontoMensal = salarioBrutoMensal * percentualDesconto;
            salarioLiquidoMensal = salarioBrutoMensal - descontoMensal;

            //Saída

            Console.WriteLine();
            Console.WriteLine(" O estágio terá duração de {0:D} DIAS", duracaoEstagioDias);
            Console.WriteLine(" O salário bruto total será de: R$ {0:N}", salarioBrutoTotal);
            Console.WriteLine(" O desconto mensal sobre o salário é de: R$ {0:N}", descontoMensal);
            Console.WriteLine(" O salário líquido mensal é de: R$ {0:N}", salarioLiquidoMensal);
            Console.ReadKey();












        }
    }
}
