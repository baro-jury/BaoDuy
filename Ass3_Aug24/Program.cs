class Program
{
    private static void Main(string[] args)
    {
        DesignMenu();
        Console.WriteLine("-------------------------------");
        CheckForPrime();
        Console.WriteLine("-------------------------------");
        ShowGeometry();
    }

    public static void DesignMenu()
    {
        while (true)
        {
            int choice;
            Console.WriteLine("====== Menu ======");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.Write("\n=> Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Draw the square");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Draw the rectangle");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    Console.WriteLine();
                    break;
            }
        }
    }

    public static void CheckForPrime()
    {
        int number;
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        if (number < 2) Console.WriteLine(number + " is not a prime");
        else
        {
            int i = 2;
            bool isPrime = true;
            while (i <= Math.Sqrt(number))
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
                i++;
            }
            if (isPrime) Console.WriteLine(number + " is a prime");
            else Console.WriteLine(number + " is not a prime");
        }
    }

    public static void ShowGeometry()
    {
        
    }
}