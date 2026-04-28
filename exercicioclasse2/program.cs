using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioclasse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine(p1.nome + " é a mais velha");
            }
            else
            {
                Console.WriteLine(p2.nome + " é o mais velho");
            }
        }
    }
}
