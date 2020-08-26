using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03_SomaDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, soma1;
            double num3, num4, soma2, soma3;
            Console.Write("Digite um número inteiro 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um número inteiro 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um número real:");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um número real:");
            num4 = Convert.ToDouble(Console.ReadLine());

            soma1 = num1 + num2;
            soma2 = num3 + num4;
            soma3 = soma1 + soma2;

            Console.WriteLine("A soma dos números inteiros é:" + soma1);
            Console.WriteLine("A soma dos números reais é:" + soma2);
            Console.WriteLine("A soma dos números inteiros e reais é:" + soma3);
            Console.ReadKey();

        }
    } 
}
