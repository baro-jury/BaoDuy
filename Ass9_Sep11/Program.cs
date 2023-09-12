using Ass8_Sep08;
using Ass9_Sep11;

class Program
{
    private static void Main(string[] args)
    {
        //PracticeAbstractAndInterface();
        Console.WriteLine("-------------------------------");
        //CreateComparableCircle();
        Console.WriteLine("-------------------------------");
        //CreateCircleComparer();
        Console.WriteLine("-------------------------------");
        ResizeGeometry();
        Console.WriteLine("-------------------------------");
        //CreateCircleComparer();
    }

    #region Practice
    public static void PracticeAbstractAndInterface()
    {
        Animal[] animals = new Animal[2];
        animals[0] = new Tiger();
        animals[1] = new Chicken();
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.MakeSound());
            if (animal is Chicken)
            {
                Edible edibler = (Chicken)animal;
                Console.WriteLine(edibler.HowToEat());
            }
        }

        Console.WriteLine();

        Fruit[] fruits = new Fruit[2];
        fruits[0] = new Orange();
        fruits[1] = new Apple();
        foreach (Fruit fruit in fruits)
        {
            Console.WriteLine(fruit.HowToEat());
        }
    }

    public static void CreateComparableCircle()
    {
        ComparableCircle[] circles = new ComparableCircle[3];
        circles[0] = new ComparableCircle(3.6);
        circles[1] = new ComparableCircle();
        circles[2] = new ComparableCircle(3.5, "indigo", false);

        Console.WriteLine("Pre-sorted:");
        foreach (ComparableCircle circle in circles)
        {
            Console.WriteLine(circle);
        }

        Array.Sort(circles);

        Console.WriteLine("\nAfter-sorted:");
        foreach (ComparableCircle circle in circles)
        {
            Console.WriteLine(circle);
        }
    }

    public static void CreateCircleComparer()
    {
        Circle[] circles = new Circle[3];
        circles[0] = new Circle(3.6);
        circles[1] = new Circle();
        circles[2] = new Circle(3.5, "indigo", false);

        Console.WriteLine("Pre-sorted:");
        foreach (Circle circle in circles)
        {
            Console.WriteLine(circle);
        }

        IComparer<Circle> circleComparer = new CircleComparer();
        Array.Sort(circles, circleComparer);

        Console.WriteLine("\nAfter-sorted:");
        foreach (Circle circle in circles)
        {
            Console.WriteLine(circle);
        }
    } 
    #endregion

    public static void ResizeGeometry()
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new CircleResizer();
        shapes[1] = new RectangleResizer();
        shapes[2] = new SquareResizer();

        Console.WriteLine("Pre-resized:");
        foreach (Resizeable shape in shapes)
        {
            Console.WriteLine(shape);
            shape.Resize(10);
        }

        Console.WriteLine("\nAfter-resized:");
        foreach (Resizeable shape in shapes)
        {
            Console.WriteLine(shape);
        }
    }
}