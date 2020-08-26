using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02_PreçoVenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoVenda, precoCusto, valorFrete, valorLucro;

            Console.Write("Digite o preço de custo do produto: ");
            precoCusto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do frete do produto: ");
            valorFrete = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o preço do lucro do produto: ");
            valorLucro = Convert.ToDouble(Console.ReadLine());

            precoVenda = (precoCusto + valorFrete + valorLucro);
            Console.Write(" O valor de venda deste produto é: " + precoVenda);
            Console.ReadKey();


        }
    }
}
