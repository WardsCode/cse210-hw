using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(2, "Blue");
        Console.WriteLine($"The Color of the Square is {square1.GetColor()} and its area is {square1.GetArea()}");

        Rectangle rectangle1 = new Rectangle(3,5, "Yellow");
        Console.WriteLine($"The Color of the Square is {rectangle1.GetColor()} and its area is {rectangle1.GetArea()}");

        Circle circle1 = new Circle(5,"Red");
        Console.WriteLine($"The Color of the Square is {circle1.GetColor()} and its area is {circle1.GetArea()}");

        List<Shape> listShapes = new List<Shape>();
        listShapes.Add(square1);
        listShapes.Add(rectangle1);
        listShapes.Add(circle1);

        foreach (Shape shapes in listShapes)
        {
            Console.WriteLine(shapes.GetArea());
        }



    }

    
}