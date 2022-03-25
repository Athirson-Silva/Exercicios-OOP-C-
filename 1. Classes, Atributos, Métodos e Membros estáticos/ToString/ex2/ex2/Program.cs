using System;
using System.Globalization;
namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario A = new Funcionario();

            Console.WriteLine("Entre com os dados do funcionário: ");
            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            A.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            A.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + A);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + A);

        }
    }
}
