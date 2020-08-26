using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc._18_Val_e_Perc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para ler:
            • Quantidade de Apartamentos
            • Valor da Conta de Energia
            • Valor da Conta de Água
            Calcular e mostrar:
            • Valor total que cada morador deve pagar
            • Percentual que cada morador deve pagar*/

            int qtdeApartamentos;
            double valorEnergia, valorAgua, valorMorador, valorContas, percentualMorador;


            //Entrada
            Console.Write("Digite o valor da Conta de Energia ");
            valorEnergia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da Conta de Água ");
            valorAgua = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite quantos apartamentos tem no prédio ");
            qtdeApartamentos = Convert.ToInt32(Console.ReadLine());


            //Processamento

            valorContas = (valorEnergia + valorAgua);
            valorMorador = valorContas / qtdeApartamentos;
            percentualMorador = valorMorador / valorContas;

            //Saída
            Console.WriteLine();
            Console.WriteLine("O valor a ser pago pelo morador: R$ {0,3:F}", valorMorador);
            Console.WriteLine("O % a ser pago pelo morador é de: {0:P}", percentualMorador);
            Console.ReadKey();




        }
    }
}
