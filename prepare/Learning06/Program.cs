using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");

        Square square = new Square("Blue", 5.0);
        Console.WriteLine($"The color of the square is: {square.GetColor()}");
        Console.WriteLine($"The area of the square is: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Red", 5.0, 2.0);
        Console.WriteLine($"The color of the rectangle is: {rectangle.GetColor()}");
        Console.WriteLine($"The area of the rectangle is: {rectangle.GetArea()}");

        Circle circle = new Circle("Yellow", 5.0);
        Console.WriteLine($"The color of the circle is: {circle.GetColor()}");
        Console.WriteLine($"The area of the circle is: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("pink", 3));
        shapes.Add(new Rectangle("green", 2, 2));
        shapes.Add(new Circle("orange", 4));

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);
        }

    }
}