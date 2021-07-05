﻿using ExercicioPropostoExcecoes.Entities;
using ExercicioPropostoExcecoes.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExercicioPropostoExcecoes
{
    class Program
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
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);
                Console.WriteLine($"New balance: {account.Balance}");

            }catch (DomainException e)
            {
                Console.WriteLine($"Withdraw Error: {e.Message}");
            }
            
           

        }
    }
}
