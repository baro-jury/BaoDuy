using Ass4_Aug25;
using System.Text.RegularExpressions;

class Program
{
    private static void Main(string[] args)
    {
        SumTheElementsOfAnArray();
        Console.WriteLine("-------------------------------");
        FindValueInArray();
        Console.WriteLine("-------------------------------");
        FindMaxValueInArray();
    }

    public static void SumTheElementsOfAnArray()
    {
        //int[] numbers = new int[5] { 2, 5, 9, 6, 7 };
        int[] numbers = { 2, 5, 9, 6, 7 };
        int total = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }
        Console.WriteLine(total.ToString());
    }

    public static void FindValueInArray()
    {
        string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
        Console.Write("Enter a name’s student: ");
        string name = Console.ReadLine();
        bool isExist = false;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Equals(name))
            {
                Console.WriteLine("Position of the students " + name + " in the list is " + (i + 1));
                isExist = true;
                break;
            }
        }
        if (!isExist)
        {
            Console.WriteLine("Not found " + name + " in the list.");
        }
    }

    public static void FindMaxValueInArray()
    {
        int size;
        do
        {
            Console.Write("Enter a size: ");
            size = GetInteger(1, Int32.MaxValue, "Enter again!");
            if (size > 20)
                Console.WriteLine("Size should not exceed 20");
        } while (size > 20);

        int[] array = new int[size];
        int i = 0;
        while (i < array.Length)
        {
            Console.Write("- Enter element " + (i + 1) + ": ");
            array[i] = GetInteger(Int32.MinValue, Int32.MaxValue, "Enter again!");
            i++;
        }

        Console.WriteLine("\n=> Property list: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + "\t");
        }
        Console.WriteLine();

        int max = array[0];
        int index = 1;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > max)
            {
                max = array[j];
                index = j + 1;
            }
        }
        Console.WriteLine("\n=> The largest property value in the list is " + max + ", at position " + index);
    }

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
    #endregion
}