using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc24_Caminhada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração

            double horaInicialCaminhada, minutoInicialCaminhada, horaFinalCaminhada, minutoFinalCaminhada, minutosTotaisPercorridos, diferencaHoras;
            double distanciaPercorrida, distanciaPorMinuto;

            //Entrada

            try
            {
                Console.Write("Digite a hora inicial da caminhada: ");
                horaInicialCaminhada = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o minuto inicial da caminhada: ");
                minutoInicialCaminhada = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a hora final da caminhada: ");
                horaFinalCaminhada = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o minuto inicial da caminhada: ");
                minutoFinalCaminhada = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a distância percorrida durante a caminhada: ");
                distanciaPercorrida = Convert.ToDouble(Console.ReadLine());

            }

            catch
            {
                Console.WriteLine();
                Console.Write("Digite valores numéricos.");
                Console.ReadKey();
                return;
            }

            //Processamento

            diferencaHoras =  horaFinalCaminhada - horaInicialCaminhada;

            minutosTotaisPercorridos = minutoInicialCaminhada + (diferencaHoras * 60) + minutoFinalCaminhada;

            distanciaPorMinuto = distanciaPercorrida / minutosTotaisPercorridos;

            //Saída

            Console.WriteLine("");
            Console.WriteLine(" No final da caminhada a pessoa percorreu: {0,2:F2} minutos", minutosTotaisPercorridos);
            Console.WriteLine(" No final da caminhada a pessoa percorreu: {0,2:F2} metros por minuto", distanciaPorMinuto);
            Console.ReadKey();

        }
    }
}
