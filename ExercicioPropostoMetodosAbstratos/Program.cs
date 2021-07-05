using ExercicioPropostoMetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPropostoMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of taxpayers: ");
            int numberTaxPayers = int.Parse(Console.ReadLine());
            List<Taxpayer> taxpayers = new List<Taxpayer>();
            for(int i = 1; i <= numberTaxPayers; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data:");
                Console.Write("Indiviual or Company( i/c )? ");
                char individualOrCompany = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                if(individualOrCompany == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    Individual taxpayer = new Individual(name,anualIncome,healthExpenditures);
                    taxpayers.Add(taxpayer);
                }else if (individualOrCompany == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployee = int.Parse(Console.ReadLine());
                    Company taxpayer = new Company(name, anualIncome, numberEmployee);
                    taxpayers.Add(taxpayer);
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0;
            foreach (Taxpayer taxpayer in taxpayers)
            {
                Console.WriteLine(taxpayer);
                totalTaxes += taxpayer.TaxesPaid();

            }
                Console.WriteLine();
                Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
