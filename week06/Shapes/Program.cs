using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Red", 5, 3);
        shapes.Add(rectangle);

        Circle circle = new Circle("Green", 2.5);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetType().Name} is: {shape.GetArea()}");
        }
    }
}