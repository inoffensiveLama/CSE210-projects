using System;

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square("red", 3.3);

        Shape rectangle = new Rectangle("yellow", 4.2, 3.5);

        Shape circle = new Circle("blue", 10.0);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes){
            shape.GetColor();
            shape.GetArea();
        }
    }
}