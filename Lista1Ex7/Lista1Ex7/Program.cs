using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Geometrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valor2 = Convert.ToDouble(Console.ReadLine());

            double mediaGeometrica = Math.Sqrt(valor1 * valor2);

            Console.WriteLine("A média geométrica dos valores {0} e {1} é: {2}", valor1, valor2, mediaGeometrica);
        }
    }
}