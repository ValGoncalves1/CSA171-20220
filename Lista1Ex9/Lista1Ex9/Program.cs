using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_celcius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;


            Console.WriteLine("Digite a temperatura em graus Celsius:");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("{0} graus Celsius equivalem a {1} graus Fahrenheit.", celsius, fahrenheit);
        }
    }
}