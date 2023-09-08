using Ass7_Sep06;

class Program
{
    private static void Main(string[] args)
    {
        CreateRectangle();
        Console.WriteLine("-------------------------------");
        //FindMinValueInArray();
        Console.WriteLine("-------------------------------");
        //RemoveElementFromArray();
        Console.WriteLine("-------------------------------");
        //CountOccurrencesOfCharacter();
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
}