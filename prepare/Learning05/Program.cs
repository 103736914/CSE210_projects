using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        // Square square = new Square("green", 3);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        // Rectangle rectangle = new Rectangle("blue", 3, 2);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        // Circle circle = new Circle("purple", 4);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("green", 3));
        shapes.Add(new Rectangle("blue", 3, 2));
        shapes.Add(new Circle("purple", 4));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine();
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
            Console.WriteLine();
    }
}