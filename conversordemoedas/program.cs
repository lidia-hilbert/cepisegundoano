using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólare você vai comprar?: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);    

            double result = Conversor.DolarParaReal(cotacao, quantia);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
