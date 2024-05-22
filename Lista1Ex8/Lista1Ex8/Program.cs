using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Definindo variáveis para armazenar os valores dos produtos
            double[] valoresProdutos = new double[5];

            // Entrada dos valores dos produtos
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o valor do {i + 1}º produto: R$ ");
                valoresProdutos[i] = double.Parse(Console.ReadLine());
            }

            // Calculando o total dos produtos
            double total = 0;
            foreach (double valor in valoresProdutos)
            {
                total += valor;
            }

            Console.Write("Digite o valor do pagamento: R$ ");
            double pagamento = double.Parse(Console.ReadLine());

            double troco = pagamento - total;

            Console.WriteLine($"Troco a ser devolvido: R$ {troco:F2}");

        }
    }
}