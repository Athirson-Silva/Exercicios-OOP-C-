using System;
using System.Globalization;
using Desafio.Entitities;
using Desafio.Entitities.Enums;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime teste = DateTime.Now;
            Console.WriteLine(teste.ToString("dd/MM/yyyy"));
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/mm/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("\nEnter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());



            for ( int i = 1; i <= n; i++ )
            {
                Console.WriteLine($"\nEnter #{i} item data: ");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine("\nORDER SUMMARY: ");
            Console.Write(order);
        }
    }
}
