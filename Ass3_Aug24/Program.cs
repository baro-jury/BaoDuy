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
        bool isRunning = true;
        while (isRunning)
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
                    isRunning = false;
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
        number = GetInteger(Int32.MinValue, Int32.MaxValue, "Enter again!");
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
        bool isRunning = true;
        string resultInLine = "";
        while (isRunning)
        {
            int choice;
            Console.WriteLine("====== Menu ======");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("0. Exit");
            Console.Write("\n=> Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nPrint the rectangle");
                    Console.Write("Length = ");
                    int length = GetInteger(2, Int32.MaxValue, "Enter again!");
                    Console.Write("Width = ");
                    int width = GetInteger(1, length - 1, "Enter again!");
                    Console.WriteLine();
                    for (int i = 1; i <= width; i++)
                    {
                        for (int j = 1; j <= length; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("\nPrint the square triangle");
                    Console.Write(
                        "------------------------------------\n" +
                        "| 1 - Bottom-left square triangle  |\n" +
                        "| 2 - Top-left square triangle     |\n" +
                        "| 3 - Bottom-right square triangle |\n" +
                        "| 4 - Top-right square triangle    |\n" +
                        "------------------------------------\n" +
                        "Type of square triangle = ");
                    int type = GetInteger(1, 4, "Enter again!");
                    Console.Write("Height = ");
                    int height = GetInteger(1, Int32.MaxValue, "Enter again!");
                    Console.WriteLine();
                    switch (type)
                    {
                        case 1: //bottom left
                            for (int i = 1; i <= height; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            break;
                        case 2: //top left
                            for (int i = height; i >= 1; i--)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            break;
                        case 3: //bottom right
                            for (int i = 1; i <= height; i++)
                            {
                                resultInLine = "";
                                for (int j = 1; j <= i; j++)
                                {
                                    resultInLine += "* ";
                                    resultInLine.Trim();
                                }
                                for (int j = 1; j <= (height - i); j++)
                                {
                                    resultInLine = "  " + resultInLine;
                                }
                                Console.WriteLine(resultInLine);
                            }
                            Console.WriteLine();
                            break;
                        case 4: //top right
                            for (int i = height; i >= 1; i--)
                            {
                                resultInLine = "";
                                for (int j = 1; j <= i; j++)
                                {
                                    resultInLine += "* ";
                                    resultInLine.Trim();
                                }
                                for (int j = 1; j <= (height - i); j++)
                                {
                                    resultInLine = "  " + resultInLine;
                                }
                                Console.WriteLine(resultInLine);
                            }
                            Console.WriteLine();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("\nPrint isosceles triangle");
                    Console.Write("Height = ");
                    height = GetInteger(1, Int32.MaxValue, "Enter again!");
                    Console.WriteLine();
                    for (int i = 1; i <= height; i++)
                    //for (int i = height; i >= 1; i--)
                    {
                        resultInLine = "";
                        for (int j = 1; j <= i; j++)
                        {
                            resultInLine += "* ";
                            resultInLine.Trim();
                        }
                        for (int j = 1; j <= (height - i); j++)
                        {
                            resultInLine += " ";
                            resultInLine = " " + resultInLine;
                        }
                        Console.WriteLine(resultInLine);
                    }
                    Console.WriteLine();
                    break;
                case 0:
                    //Environment.Exit(0);
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("No choice!");
                    Console.WriteLine();
                    break;
            }
        }
    }

    private static int GetInteger(int min, int max, string errorMsg)
    {
        while (true)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < min || number > max)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else return number;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Out of range!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMsg);
                Console.ResetColor();
            }
        }
    }
}