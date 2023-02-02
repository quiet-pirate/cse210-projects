using System;

class Program
{
    static void Main(string[] args)
    {
        Square shape1 = new Square("blue", 3);
        Console.WriteLine($"The {shape1.GetColor()} square has an area of {shape1.GetArea()}");

        Rectangle shape2 = new Rectangle("red", 2, 4);
        Console.WriteLine($"The {shape2.GetColor()} rectangle has an area of {shape2.GetArea()}");

        Circle shape3 = new Circle("yellow", 7);
        Console.WriteLine($"The {shape3.GetColor()} circle has an area of {shape3.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}