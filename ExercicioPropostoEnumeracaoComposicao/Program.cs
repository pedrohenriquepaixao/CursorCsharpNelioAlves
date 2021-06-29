using ExercicioPropostoEnumeracaoComposicao.Entities.Utils;
using System.Globalization;
using System;
using ExercicioPropostoEnumeracaoComposicao.Entities;

namespace ExercicioPropostoEnumeracaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine();

            Console.Write("How many items to this order? ");
            int howManyItems = int.Parse(Console.ReadLine());

            Order order = new Order();
            
            order.Status = status;

            order.Client = client;
            
            for(int i = 0; i < howManyItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product produto = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity,produto.Price,produto);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
