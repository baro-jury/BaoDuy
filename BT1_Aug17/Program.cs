using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

class Program
{
    private static void Main(string[] args)
    {
        ShowSystemTime();
        Console.WriteLine("-------------------------------");
        UseOperator();
        Console.WriteLine("-------------------------------");
        ShowGreetings();
        Console.WriteLine("-------------------------------");
        ConvertUSDToVND();
    }

    public static void ShowSystemTime()
    {
        DateTime localDate = DateTime.Now;
        Console.WriteLine("Date time now is: " + localDate);
    }

    public static void UseOperator()
    {
        float width;
        float height;
        Console.Write("Enter width: ");
        width = float.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        height = float.Parse(Console.ReadLine());
        float area = width * height;
        Console.WriteLine("Area is: " + area);
    }

    public static void ShowGreetings()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello: " + name);
    }

    public static void ConvertUSDToVND()
    {
        int rate = 24085;
        Console.Write("Enter USD: ");
        int usd = int.Parse(Console.ReadLine());
        float vnd = usd * rate;
        Console.WriteLine("The corresponding VND is: " + vnd);
    }
}