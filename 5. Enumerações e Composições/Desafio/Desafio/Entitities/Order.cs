using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Entitities.Enums;
using System.Globalization;

namespace Desafio.Entitities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public OrderItem OrderItem { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;

        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach(OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append($"{Client.Name} ");
            sb.Append($"({Client.BirthDate.ToString("dd/MM/yyyy")})");
            sb.AppendLine($" - {Client.Email}");
            sb.AppendLine("Order Items: ");
            foreach(OrderItem orderItem in OrderItems)
            {
                sb.Append($"{orderItem.Product.Name}, ");
                sb.Append($"${orderItem.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
                sb.Append($"Quantity: {orderItem.Quantity}, ");
                sb.AppendLine($"Subtotal: ${orderItem.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
