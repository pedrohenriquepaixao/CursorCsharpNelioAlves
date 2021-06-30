using ExercicioPropostoHerenca.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPropostoHerenca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numberProduct = int.Parse(Console.ReadLine());

            List<Product> produtos = new List<Product>();
            for (int i = 1; i<= numberProduct; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeProduct == 'c')
                {
                    Product produto = new Product(name, price);
                    produtos.Add(produto);

                } else if (typeProduct == 'u') {

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct produto = new UsedProduct(name,price,date);
                    produtos.Add(produto);

                }
                else
                {

                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct produto = new ImportedProduct(name,price,customFee);
                    produtos.Add(produto);

                }
                
            }
            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS:");
            foreach (Product produto in produtos)
            {
                Console.WriteLine(produto.PriceTag());
            }
        }
    }
}
