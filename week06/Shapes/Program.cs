using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("Blue", 4);
        Console.WriteLine($"The area of the square is: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Red", 5, 3);
        Console.WriteLine($"The area of the rectangle is: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 2.5);
        Console.WriteLine($"The area of the circle is: {circle.GetArea()}");
    }
}