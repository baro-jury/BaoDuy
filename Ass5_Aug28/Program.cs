using System.Xml.Linq;

class Program
{
    private static void Main(string[] args)
    {
        //ConvertTemperature();
        Console.WriteLine("-------------------------------");
        //FindMinValueInArray();
        Console.WriteLine("-------------------------------");
        RemoveElementFromArray();
        Console.WriteLine("-------------------------------");
        CountOccurrencesOfCharacter();
    }

    #region Practice
    public static void ConvertTemperature()
    {
        double fahrenheit, celsius;
        int choice;
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("====== Menu ======");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");
            Console.Write("\n=> Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Fahrenheit: ");
                    fahrenheit = GetDouble(double.MinValue, double.MaxValue, "Enter again!");
                    Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(fahrenheit) + "\n");
                    break;
                case 2:
                    Console.Write("Enter Celsius: ");
                    celsius = GetDouble(double.MinValue, double.MaxValue, "Enter again!");
                    Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(celsius) + "\n");
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
    private static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (5.0 / 9) * (fahrenheit - 32);
        return celsius;
    }
    private static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (9.0 / 5) * celsius + 32;
        return fahrenheit;
    }

    public static void FindMinValueInArray()
    {
        int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
        //int[] arr = InstantiateArray();
        int index = MinValue(arr);
        Console.WriteLine("The smallest element in the array is: " + arr[index]);
    }
    private static int MinValue(int[] array)
    {
        int min = array[0];
        int index = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }

        return index;
    }
    #endregion

    #region Exercise
    public static void RemoveElementFromArray()
    {
        #region Khai báo và khởi tạo mảng số nguyên gồm N phần tử cho trước
        int[] array = InstantiateArray();
        int n = array.Length;

        Console.WriteLine("\n=> Initial element list: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine("\n");
        #endregion

        #region Nếu phần tử X có xuất hiện, thực hiện xoá X ở vị trí index khỏi mảng
        Console.Write("Enter the element to remove: ");
        int x = GetInteger(int.MinValue, int.MaxValue, "Enter again!");
        int index = 0;
        bool isExisted = false;
        for (int i = 0; i < n; i++)
        {
            if (array[i] == x)
            {
                isExisted = true;
                index = i;
                break;
            }
        }

        if (isExisted)
        {
            for (int i = index; i < (n - 1); i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, n - 1);

            Console.WriteLine("=> Element list after removing: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("=> This element is not existed!");
        }
        #endregion
    }

    public static void CountOccurrencesOfCharacter()
    {

    }

    private static int[] InstantiateArray()
    {
        Console.Write("Enter a size of array: ");
        int size = GetInteger(1, int.MaxValue, "Enter again!");
        int[] array = new int[size];
        int i = 0;
        while (i < array.Length)
        {
            Console.Write("- Enter element " + (i + 1) + ": ");
            array[i] = GetInteger(int.MinValue, int.MaxValue, "Enter again!");
            i++;
        }
        return array;
    }
    #endregion

    #region Validation
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

    private static double GetDouble(double min, double max, string errorMsg)
    {
        while (true)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
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
    #endregion
}