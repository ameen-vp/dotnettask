// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Principal;

public interface Shapes
{
    double Getarea();

}
    public class Circle : Shapes
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Getarea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Rectangle : Shapes
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int length, int width)
        {

            Length = length;
            Width = width;
        }

        public double Getarea()
        {
            return Length * Width;
        }
    }

public class Square : Shapes
{

    public double Side { get; set; }

 
    public Square(double side)
    {
        Side = side;
    }

  
    public double Getarea()
    {
        return Side * Side;
    }
}

public class Program
{
    public static void Main()
    {
        Shapes circle = new Circle(5);
        Shapes rectangle = new Rectangle(10, 13);
        Shapes ameen = new Square(10); 

        Console.WriteLine("this is circle: " + circle.Getarea());
        Console.WriteLine("this is rectangle: " + rectangle.Getarea()); 
        Console.WriteLine("this is square: " + ameen.Getarea()); 
    }
}

