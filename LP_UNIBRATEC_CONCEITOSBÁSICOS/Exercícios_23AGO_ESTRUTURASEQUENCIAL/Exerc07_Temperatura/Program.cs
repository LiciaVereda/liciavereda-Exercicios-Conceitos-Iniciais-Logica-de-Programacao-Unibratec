using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc07_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempCelsius, temperaturaFahrenheit;

            
                //Entrada
                try
                {

                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());
                  
                }

                catch
                {
                    Console.WriteLine("Digite valores númericos");
                    Console.ReadKey();
                    return;
                }

               //Processamento

              tempCelsius = (temperaturaFahrenheit - 32) * 5 / 9;
              Console.WriteLine();

               //Saída

                Console.WriteLine(" A temperatura em Celsius é de : {0:F1} °C", tempCelsius);
                Console.ReadKey();
            }
        }
    }

