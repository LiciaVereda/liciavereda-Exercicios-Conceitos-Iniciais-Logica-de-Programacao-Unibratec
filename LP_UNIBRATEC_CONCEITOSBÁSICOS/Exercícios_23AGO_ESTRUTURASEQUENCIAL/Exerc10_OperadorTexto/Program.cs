using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc10_OperadorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variáveis
            string A = "I", B = "BRA", C = "TEC", S = "X";
            string D, E, F, G;

            //Processamento,

            D = A + B + C;  
            E = B + "SIL";  
            F = C + "NO" + B + "S";  
            G = C + "NO" + B + S;

            //Saída

            Console.WriteLine(" O valor de D é: " + D);
            Console.WriteLine(" O valor de E é: " + E);
            Console.WriteLine(" O valor de F é: " + F);
            Console.WriteLine(" O valor de G é: " + G);
            Console.ReadKey();
        }
    }
}
