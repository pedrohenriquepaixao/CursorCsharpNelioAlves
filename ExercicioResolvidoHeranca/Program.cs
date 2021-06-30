using ExercicioResolvidoHeranca.Entity;
using System.Globalization;
using System;
using System.Collections.Generic;

namespace ExercicioResolvidoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the number of employees: ");
            int howMuchEmployees = int.Parse(Console.ReadLine());

            List<Employee> empregados = new List<Employee>();
            
            for (int i = 0; i < howMuchEmployees; i++)
            {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced (y/n) ? ");
                Boolean isOutsourced = Console.ReadLine() == "y" ? true : false;

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                if (isOutsourced)
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    OutsourcedEmployee empregado = new OutsourcedEmployee(name, hours,valuePerHour,additionalCharge);
                    empregados.Add(empregado);
                }
                else
                {
                    Employee empregado = new Employee(name,hours,valuePerHour);
                    empregados.Add(empregado);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee empregado in empregados) Console.WriteLine(empregado);

        }
    }
}
