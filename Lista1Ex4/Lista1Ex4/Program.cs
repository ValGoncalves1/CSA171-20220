using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotação_dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacaoDolar;
            double valorDolares;
            double valorReais;

            Console.WriteLine("Digite a cotação do dólar:");
            cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de dólares:");
            valorDolares = Convert.ToDouble(Console.ReadLine());

            valorReais = cotacaoDolar * valorDolares;

            Console.WriteLine("O valor de {1} dolares corresponde a {0} Reais", valorReais, valorDolares);
        }
    }
}
