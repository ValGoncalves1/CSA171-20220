using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diagonal;
            int lado;
            int area;
            string aux;

            Console.WriteLine("digite o valor da diagonal do quadrado:");
            aux = Console.ReadLine();
            diagonal = int.Parse(aux);


            lado = (int)(diagonal / Math.Sqrt(2));

            area = lado * lado;

            Console.WriteLine("A area diagonal do quadrado é:");
            Console.WriteLine(area);
        }
    }
}