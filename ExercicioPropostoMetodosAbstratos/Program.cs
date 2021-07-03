using ExercicioPropostoMetodosAbstratos.Entities;
using System;

namespace ExercicioPropostoMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of taxpayers: ");
            int numberTaxPayers = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberTaxPayers; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data:");
                Console.WriteLine("Indiviual or Company( i/c )? ");
                char individualOrCompany = char.Parse(Console.ReadLine());

                if(individualOrCompany == 'i')
                {

                    Individual taxpayer = new Individual(); 
                }
            }
        }
    }
}
