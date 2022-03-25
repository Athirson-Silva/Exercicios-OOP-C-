using System;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            conta.LeiturDeDados();
            Console.WriteLine(conta);

            conta.Depositar();
            Console.WriteLine(conta);

            conta.Sacar();
            Console.WriteLine(conta);          
        }
    }
}
