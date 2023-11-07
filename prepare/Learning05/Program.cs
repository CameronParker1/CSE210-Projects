using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 8);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Orange", 3, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("Purple", 4);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}