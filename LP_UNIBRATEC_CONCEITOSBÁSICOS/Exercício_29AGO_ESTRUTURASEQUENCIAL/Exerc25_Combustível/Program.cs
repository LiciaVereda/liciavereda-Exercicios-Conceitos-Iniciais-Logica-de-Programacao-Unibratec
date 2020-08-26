using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc25_Combustível
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração
            double marcacaoInicialOdometro, marcacaoFinalOdometro, litrosAbastecidos, kmPercorrido, consumoKm;

            //Entrada

            try
            {
                Console.Write("Digite a marcação inicial do odômetro: ");
                marcacaoInicialOdometro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a marcação final do odômetro: ");
                marcacaoFinalOdometro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite quantos litros foram abastecidos no final da viagem: ");
                litrosAbastecidos = Convert.ToDouble(Console.ReadLine());
            }

            catch
            {
                Console.Write("");
                Console.Write("Digite valores númericos.");
                Console.ReadKey();
                return;

            }


            //Processamento

            kmPercorrido = marcacaoFinalOdometro - marcacaoInicialOdometro;
            consumoKm = litrosAbastecidos / kmPercorrido;


            //Saída

            Console.WriteLine(kmPercorrido);
            Console.WriteLine(consumoKm);
            Console.ReadKey();





















        }
    }
}
