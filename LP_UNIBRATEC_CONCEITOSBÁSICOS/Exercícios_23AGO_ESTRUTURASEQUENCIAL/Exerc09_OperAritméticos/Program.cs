using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc09_OperAritméticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variáveis
            int x = 15, y = 4, z = 50 , w , k, o, p, r, s;

            //Processamento
            w = x + 2;
            k = x * y;
            o = 10 + y + z / 2;
            p = 10 + (y + z) / 2;
            r = w % 3;
            s = z % x;

            //Saída

            Console.WriteLine("O valor de w é:" + w);
            Console.WriteLine("O valor de k é:" + k);
            Console.WriteLine("O valor de o é:" + o);
            Console.WriteLine("O valor de p é:" + p);
            Console.WriteLine("O valor de r é:" + r);
            Console.WriteLine("O valor de s é:" + s);
            Console.ReadKey();

        }
    }
}
