using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diametro_do_circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro;
            double raio;
            double area;

            Console.WriteLine("Digite o diâmetro do círculo:");
            diametro = Convert.ToDouble(Console.ReadLine());

            raio = diametro / 2;

            area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo com diâmetro {0} é: {1}", diametro, area);
        }
    }
}