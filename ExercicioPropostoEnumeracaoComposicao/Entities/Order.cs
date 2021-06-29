using ExercicioPropostoEnumeracaoComposicao.Entities.Utils;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoEnumeracaoComposicao.Entities
{
    class Order
    {
        public DateTime Moment = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set;} = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(OrderStatus status, List<OrderItem> items, Client client)
        {
            Status = status;
            Items = items;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem Item in Items)
            {
                total += Item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, ${item.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Total price: ${Total().ToString("F2",CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
