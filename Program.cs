
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMatheus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;
            string aux;

            Console.WriteLine("digite o valor do retangulo:");
            aux = Console.ReadLine();
            b = int.Parse(aux);

            Console.WriteLine("digite o valor do retangulo:");
            a = int.Parse(Console.ReadLine());

            area = b + a;

            Console.WriteLine("o valor do retangulo e:");
            Console.WriteLine(area);
        }
    }
}