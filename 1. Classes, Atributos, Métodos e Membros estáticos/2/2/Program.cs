using System;
using System.Globalization;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario X = new Funcionario();
            Funcionario Y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            X.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            X.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            Y.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Salário médio = " + ((X.Salario + Y.Salario) / 2.0).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
