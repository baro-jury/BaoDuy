using Ass7_Sep06;

class Program
{
    private static void Main(string[] args)
    {
        //CreateRectangle();
        Console.WriteLine("-------------------------------");
        //CreateAnimal();
        Console.WriteLine("-------------------------------");
        //TestStaticMethod();
        Console.WriteLine("-------------------------------");
        CreateFan();
        Console.WriteLine("-------------------------------");
        //CreateStopWatch();

    }

    public static void CreateRectangle()
    {
        Console.Write("Enter the width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter the height: ");
        double height = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height);
        Console.WriteLine("Your rectangle: " + rectangle.Display());
        Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
        Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
    }

    public static void CreateAnimal()
    {
        Cat cat = new Cat("20kg", "1.5", "Kitty");
        cat.PrintInfo();
    }

    public static void TestStaticMethod()
    {
        Student.Change();
        Student s1 = new Student(111, "Hoang");
        Student s2 = new Student(222, "Khanh");
        Student s3 = new Student(333, "Nam");

        s1.Display();
        s2.Display();
        s3.Display();
    }

    public static void CreateFan()
    {
        Fan fan1 = new Fan(Fan.FAST, true, 10, "yellow");
        Fan fan2 = new Fan(Fan.MEDIUM, false, 5, "blue");
        Console.WriteLine("Fan 1: " + fan1.ToString() + "\n");
        Console.WriteLine("Fan 2: " + fan2.ToString());
    }

    public static void CreateStopWatch()
    {
        Cat cat = new Cat("20kg", "1.5", "Kitty");
        cat.PrintInfo();
    }
}