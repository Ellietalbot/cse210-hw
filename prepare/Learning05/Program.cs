using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Yellow", 9);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Red", 8.8, 12);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Orange", 78.2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);

        }


    }
}