using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMatheus2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aresta;
            int area;
            string aux;

            Console.WriteLine("digite o valor da aresta:");
            aux = Console.ReadLine();
            aresta = int.Parse(aux);

            area = aresta * aresta;



            Console.WriteLine("o valor da area do quadrado é:");
            Console.WriteLine(area);

        }
    }
}
