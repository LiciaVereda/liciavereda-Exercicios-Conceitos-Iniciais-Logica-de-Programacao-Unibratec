using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer._19_AumSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para ler:
            • Nome do funcionário
            • Quantidade de Horas trabalhada
            • Valor da Hora
            • Percentual de aumento
            Mostrar:
            Nome, seu salário é: R$ Novo salário
             */

            string nomeFuncionario;
            int horasTrabalhadas;
            double valorHora, percentualAumento, novoSalario, valorExtra;

            //Entrada

            Console.Write("Digite o nome do funcionário : ");
            nomeFuncionario = Console.ReadLine();

            Console.Write("Quantas horas o funcionário trabalhou : ");
            horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor da hora deste funcionário : ");
            valorHora = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de aumento no salário deste funcionário : ");
            percentualAumento = Convert.ToDouble(Console.ReadLine());


            //Processamento

            valorExtra = horasTrabalhadas * valorHora;
            novoSalario = ((valorExtra * 100) / percentualAumento) + valorExtra;

            //Saída

            Console.WriteLine("{0}, seu salário é: R$ {1:F}", nomeFuncionario, novoSalario);
            Console.ReadKey();









        }
    }
}
