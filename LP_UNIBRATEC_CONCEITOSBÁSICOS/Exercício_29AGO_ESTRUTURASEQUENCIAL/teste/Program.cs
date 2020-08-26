using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {


            //Declaração
            double  percentualBranco, percentualValido, percentualNulo;
            int votoBranco, votoValido, votoNulo, totalVoto,a;

            //Entrada

            try
            {
                Console.Write("Digite a quantidade de votos válidos: ");
                votoValido = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de votos em branco: ");
                votoBranco = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de votos nulos: ");
                votoNulo = Convert.ToInt32(Console.ReadLine());

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

            //votoValido = Convert.ToDouble(votoValido);

            percentualValido = Convert.ToDouble( votoValido) / Convert.ToDouble(totalVoto);

            percentualBranco = votoBranco / totalVoto;

            percentualNulo = votoNulo / totalVoto;
            //a = Math.Round(1000 / 1200);


            //Saída

            Console.WriteLine(+totalVoto);
            //Console.WriteLine(+a);
            Console.WriteLine(" O percentual de votos VÁLIDOS é: {0:P6}", percentualValido);
            Console.WriteLine(" O percentual de votos BRANCOS é: {0:P6}", percentualBranco);
            Console.WriteLine(" O percentual de votos NULOS é: {0:P6}", percentualNulo);
            Console.ReadKey();

            /*  // Declaração

              int horaInicialCaminhada, minutoInicialCaminhada, horaFinalCaminhada, minutoFinalCaminhada, minutosTotaisPercorridos, diferencaHoras;
              double distanciaPercorrida, distanciaPorMinuto;

              //Entrada

              try
              {
                  Console.Write("Digite a hora inicial da caminhada: ");
                  horaInicialCaminhada = Convert.ToInt32(Console.ReadLine());

                  Console.Write("Digite o minuto inicial da caminhada: ");
                  minutoInicialCaminhada = Convert.ToInt32(Console.ReadLine());

                  Console.Write("Digite a hora final da caminhada: ");
                  horaFinalCaminhada = Convert.ToInt32(Console.ReadLine());

                  Console.Write("Digite o minuto inicial da caminhada: ");
                  minutoFinalCaminhada = Convert.ToInt32(Console.ReadLine());

                  Console.Write("Digite a distância percorrida durante a caminhada: ");
                  distanciaPercorrida = Convert.ToDouble(Console.ReadLine());

              }

              catch
              {
                  Console.Write("Digite valores numéricos.");
                  Console.ReadKey();
                  return;
              }

              //Processamento

              diferencaHoras = horaFinalCaminhada - horaInicialCaminhada;

              minutosTotaisPercorridos =  (diferencaHoras * 60) + (minutoFinalCaminhada- minutoInicialCaminhada) ;

              distanciaPorMinuto = distanciaPercorrida / minutosTotaisPercorridos;

              //Saída

              Console.WriteLine("");
              Console.WriteLine(" No final da caminhada a pessoa percorreu: {0,2:F2} minutos", minutosTotaisPercorridos);
              Console.WriteLine(" No final da caminhada a pessoa percorreu: {0,2:F2} metros por minuto", distanciaPorMinuto);
              Console.ReadKey();
              */
        }
    }
}
