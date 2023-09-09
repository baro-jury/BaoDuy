using Ass8_Sep08;
using System;

class Program
{
    private static void Main(string[] args)
    {
        CreateShapes();
        Console.WriteLine("-------------------------------");
        CreateCircle();
        Console.WriteLine("-------------------------------");
        CreatePoint2D();
    }

    public static void CreateShapes()
    {
        Shape shape = new Shape();
        Console.WriteLine(shape);
        shape = new Shape("red", false);
        Console.WriteLine(shape + "\n");
        //-------------------------------
        Circle circle = new Circle();
        Console.WriteLine(circle);
        circle = new Circle(3.5);
        Console.WriteLine(circle);
        circle = new Circle(3.5, "indigo", false);
        Console.WriteLine(circle + "\n");
        //-------------------------------
        Rectangle rectangle = new Rectangle();
        Console.WriteLine(rectangle);
        rectangle = new Rectangle(2.3, 5.8);
        Console.WriteLine(rectangle);
        rectangle = new Rectangle(2.5, 3.8, "orange", true);
        Console.WriteLine(rectangle + "\n");
        //-------------------------------
        Square square = new Square();
        Console.WriteLine(square);
        square = new Square(2.3);
        Console.WriteLine(square);
        square = new Square(5.8, "yellow", true);
        Console.WriteLine(square);
    }

    public static void CreateCircle()
    {
        Circle circle = new Circle();
        Console.WriteLine(circle);
        circle = new Circle(3.5);
        Console.WriteLine(circle);
        circle = new Circle(3.5, "indigo");
        Console.WriteLine(circle + "\n");
        //-------------------------------
        Cylinder cylinder = new Cylinder();
        Console.WriteLine(cylinder);
        cylinder = new Cylinder(2.3, 3.5);
        Console.WriteLine(cylinder);
        cylinder = new Cylinder(2.5, 3.8, "orange");
        Console.WriteLine(cylinder);
    }

    public static void CreatePoint2D()
    {
        Point2D point2D = new Point2D();
        Console.WriteLine(point2D);
        point2D = new Point2D(3.1f, 11.5f);
        Console.WriteLine(point2D + "\n");
        //-------------------------------
        Point3D point3D = new Point3D();
        Console.WriteLine(point3D);
        point3D = new Point3D(2, 3, 5);
        Console.WriteLine(point3D);
    }
}