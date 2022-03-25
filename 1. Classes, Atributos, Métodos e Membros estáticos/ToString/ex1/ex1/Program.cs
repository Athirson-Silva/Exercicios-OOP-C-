using System;
using System.Globalization;
namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo A = new Retangulo();

            Console.WriteLine("Entre com a largura da base e a altura do retângulo: ");
            A.Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(A);
        }
    }
}
