using ExemploEnum.Entities;
using ExemploEnum.Entities.Enums;
using System;

namespace ExemploEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order pedido = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };

            Console.WriteLine(pedido);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}
