using System;
using System.Globalization;
namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alunos A = new Alunos();

            Console.Write("Nome do Aluno: ");
            A.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            A.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(A.CalcularNotaFinal());

        }
    }
}
