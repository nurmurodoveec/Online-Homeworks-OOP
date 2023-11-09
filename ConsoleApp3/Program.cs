using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(radius: 5);
            Console.WriteLine("Circle Area: " + circle.Area());
            Console.WriteLine("Circle Perimeter: " + circle.Perimeter());

            Triangle triangle = new Triangle(sideA: 3, sideB: 4, hypotenuse: 5);
            Console.WriteLine("Triangle Area: " + triangle.Area());
            Console.WriteLine("Triangle Perimeter: " + triangle.Perimeter());

            Rectangle rectangle = new Rectangle(sideA: 4, sideB: 6);
            Console.WriteLine("Rectangle Area: " + rectangle.Area());
            Console.WriteLine("Rectangle Perimeter: " + rectangle.Perimeter());
        }
    }
}

class Figure
{
    public virtual double Area()
    {
        return 0;
    }

    public virtual double Perimeter()
    {
        return 0;
    }
}

class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Triangle : Figure
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double Hypotenuse { get; set; }

    public Triangle(double sideA, double sideB, double hypotenuse)
    {
        SideA = sideA;
        SideB = sideB;
        Hypotenuse = hypotenuse;
    }

    public override double Area()
    {
        double s = (SideA + SideB + Hypotenuse) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - Hypotenuse));
    }

    public override double Perimeter()
    {
        return SideA + SideB + Hypotenuse;
    }
}

class Rectangle : Figure
{
    public double SideA { get; set; }
    public double SideB { get; set; }

    public Rectangle(double sideA, double sideB)
    {
        SideA = sideA;
        SideB = sideB;
    }

    public override double Area()
    {
        return SideA * SideB;
    }

    public override double Perimeter()
    {
        return 2 * (SideA + SideB);
    }
}




