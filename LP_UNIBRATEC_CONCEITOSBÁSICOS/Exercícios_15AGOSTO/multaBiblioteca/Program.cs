using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            const double multa = 1.50;
            int dia;
            double multaTotal;
            Console.WriteLine("Digite os dias em atraso");
            dia = Convert.ToInt32(Console.ReadLine());
            multaTotal = dia * multa;
            Console.WriteLine("O valor a ser pago pelo aluno é: " + multaTotal);
            Console.ReadKey();
        }
    }
}
