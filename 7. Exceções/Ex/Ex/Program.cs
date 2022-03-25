using System;
using System.Globalization;
using Ex.Entities;
using Ex.Entities.Exceptions;

namespace Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Intial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc1 = new Account(number, holder, balance, withdrawlimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                acc1.Withdraw(amount);
                Console.WriteLine($"New balance: {acc1.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }
}
