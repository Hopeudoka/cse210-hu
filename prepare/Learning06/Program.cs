using System;

class Program
{
    static void Main(string[] args)
    {
        Square newSquare = new Square("Green", 10.0);

        // Console.WriteLine($"{newSquare.GetColor()}");
        // Console.WriteLine($"{newSquare.GetArea()}");

        Rectangle newRectangle = new Rectangle("Grey", 15, 10);

        // Console.WriteLine($"{newRectangle.GetColor()}");
        // Console.WriteLine($"{newRectangle.GetArea()}"); 

        Circle newCircle = new Circle("Red", 4);

        // Console.WriteLine($"{newCircle.GetColor()}");
        // Console.WriteLine($"{newCircle.GetArea()}");

        List<Shape> shapeList = new List<Shape>();
        
        shapeList.Add(newSquare);
        shapeList.Add(newRectangle);
        shapeList.Add(newCircle);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine($"{shape.GetColor()}");
            Console.WriteLine($"{shape.GetArea()}");
        }
    }
}