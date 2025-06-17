using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapeList = new List<Shape>();
        Square square12 = new Square("Red", 3);
        Rectangle retangle12 = new Rectangle ("Blue", 3 ,4);
        Circle circle12 = new Circle ("Yellow", 6);

        shapeList.Add(square12);
        shapeList.Add(retangle12);
        shapeList.Add(circle12);

        foreach (var item in shapeList)
        {
            string color = item.GetColor();
            double area = item.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


        
    }
}