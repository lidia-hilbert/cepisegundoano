using exercicioraio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioraio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Entre com o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
