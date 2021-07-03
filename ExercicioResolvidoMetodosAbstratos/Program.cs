using ExercicioResolvidoMetodosAbstratos.Entities;
using ExercicioResolvidoMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioResolvidoMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int numberShapes = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= numberShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char rectangleOrCircle = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                Shape shape;

                if (rectangleOrCircle == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    shape = new Rectangle(width,height,color);
                    shapes.Add(shape);
                }
                else if (rectangleOrCircle == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    shape = new Circle(radius,color);
                    shapes.Add(shape);
                }
                else
                {
                    throw new ArgumentException();
                }     
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape item in shapes)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
