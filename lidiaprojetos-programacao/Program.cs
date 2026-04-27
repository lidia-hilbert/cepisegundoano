using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Atividade_do_Anteenilsom
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Quantos numeros inteiros você quer somar: ");
        int n = int.Parse(Console.ReadLine());

        int soma = 0;

            for (int i = 0; i < n; i++)
            {
                //Console.WritLine("oi);
                Console.WriteLine("Valor : #{0}", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            {
            Console.WriteLine("soma = " + soma);




            }
      }
 }
    

