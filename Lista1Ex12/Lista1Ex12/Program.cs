using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_elevado_a_y
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double resultado;

            Console.WriteLine("Digite o valor de X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y:");
            y = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(x, y);

            Console.WriteLine("{0} elevado a {1} é igual a {2}", x, y, resultado);
        }
    }
}
