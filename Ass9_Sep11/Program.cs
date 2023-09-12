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
        //ResizeGeometry();
        Console.WriteLine("-------------------------------");
        Icolor();
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

    #region Exercise
    public static void ResizeGeometry()
    {
        Resizeable[] shapes = new Resizeable[3];
        shapes[0] = new CircleResizer();
        shapes[1] = new RectangleResizer();
        shapes[2] = new SquareResizer();

        Random rand = new Random();
        double[] percentage = new double[3];

        Console.WriteLine("Pre-resized:");
        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine(shapes[i]);
            percentage[i] = rand.Next(1, 101) / 100.0;
            shapes[i].Resize(percentage[i]);
        }

        Console.WriteLine("\nAfter-resized:");
        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine(shapes[i] +
                ", with an increase rate of " + (percentage[i] * 100) + "%");
        }
    }

    public static void Icolor()
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Circle();
        shapes[1] = new Rectangle();
        shapes[2] = new SquareColor();

        foreach (Resizeable shape in shapes)
        {
            Console.WriteLine(shape);
        }
    }
    #endregion
}