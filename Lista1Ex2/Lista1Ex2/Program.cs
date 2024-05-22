using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTrinangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int area;
            string aux;

            Console.WriteLine("Digite o numero da base 'a'");
            aux = Console.ReadLine();
            a = int.Parse(aux);

            Console.WriteLine("Digite o numero da base 'b'");
            b = int.Parse(Console.ReadLine());

            area = a * b / 2;

            Console.WriteLine("a area do triangulo é:");
            Console.WriteLine(area);
        }
    }
}
