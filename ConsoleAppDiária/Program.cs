using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDiária
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da diária do hotel: ");
            double vd = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de adultos: ");
            double qa = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de crianças: ");
            double qc = double.Parse(Console.ReadLine());

            double resultado = qa * vd + (qc * (vd / 2));

            Console.WriteLine("O valor por dia da família será: R$" + resultado);

            Console.WriteLine("Informe a quantidade de dias de hospadegem: ");
            double dh = double.Parse(Console.ReadLine());

            resultado = resultado * dh;

            Console.WriteLine("O valor total da hospedagem é: R$" + resultado);


            Console.WriteLine("Informe o valor de parcelas: ");
            double vp = double.Parse(Console.ReadLine());

            resultado = resultado / vp;

            Console.WriteLine("O valor de cada parcela é: R$" + resultado);

            Console.ReadKey();

        }
    }
}
