using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milha_maritima
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double milhaMaritimaEmMetros = 1852; // uma milha marítima equivale a 1852 metros
            const double metroEmQuilometro = 0.001; // um quilômetro equivale a 1000 metros

            Console.WriteLine("Digite o número de milhas marítimas:");
            double milhasMaritimas = Convert.ToDouble(Console.ReadLine());

            double metros = milhasMaritimas * milhaMaritimaEmMetros;

            double quilometros = metros * metroEmQuilometro;

            Console.WriteLine("{0} milhas marítimas equivalem a {1} quilômetros.", milhasMaritimas, quilometros);
        }
    }
}