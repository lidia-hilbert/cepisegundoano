using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioquatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Impoto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + func);

            Console.Write("Deseja aumentaro salário e qual porcentagem?: ");
            double porcent = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcent);

            Console.WriteLine("Dados atualizados: "+func);

        }
    }
}
