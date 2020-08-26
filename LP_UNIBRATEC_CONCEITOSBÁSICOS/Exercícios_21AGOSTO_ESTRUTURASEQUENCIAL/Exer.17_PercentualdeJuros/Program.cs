using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer._17_PercentualdeJuros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Um cliente atrasou o pagamento da parcela de uma 
            compra, tendo pago juros sobre o valor da parcela.
            Escreva um programa que:
            Leia o valor da parcela e o valor pago.
            Escreva o valor pagos de juros e o percentual de juro*/

            double valorParcela, valorPago, valorJuros, percentuaJuros;

            //Entrada
            Console.Write("Digite o valor da parcela atrasada: R$ ");
            valorParcela = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da pago pelo cliente: R$ ");
            valorPago = Convert.ToDouble(Console.ReadLine());

            //Processamento
            valorJuros = valorPago - valorParcela;
            percentuaJuros = valorJuros / valorParcela;

            //Saida
            Console.WriteLine("O juro pago foi de R$ "+ valorJuros); //Saída sem formatação
            Console.WriteLine("O juro pago foi de R$ {0,2:F}", valorJuros); //Saída com formatação
            Console.WriteLine("O percentual de juro pago foi R$ {0,0:P}", percentuaJuros);
            Console.ReadKey();


        }
    }
}
