using Ass4_Aug25;
using System.Data.Common;

class Program
{
    private static void Main(string[] args)
    {
        SumTheElementsOfAnArray();
        Console.WriteLine("-------------------------------");
        FindValueInArray();
        Console.WriteLine("-------------------------------");
        FindMaxValueInArray();
        Console.WriteLine("-------------------------------");
        Minesweeper.DoMin();
        Console.WriteLine("-------------------------------");
        AddElementsToArray();
        Console.WriteLine("-------------------------------");
        FindMaxValueInTwoDimensionalArray();
        Console.WriteLine("-------------------------------");
        SumTheMainDiagonalOfSquareMatrix();
    }

    #region Practice
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
        #region Khai báo và khởi tạo mảng số nguyên
        int size;
        do
        {
            Console.Write("Enter a size: ");
            size = GetInteger(1, int.MaxValue, "Enter again!");
            if (size > 20)
                Console.WriteLine("Size should not exceed 20");
        } while (size > 20);

        int[] array = new int[size];
        int i = 0;
        while (i < array.Length)
        {
            Console.Write("- Enter element " + (i + 1) + ": ");
            array[i] = GetInteger(int.MinValue, int.MaxValue, "Enter again!");
            i++;
        }

        Console.WriteLine("\n=> Property list: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + "\t");
        }
        Console.WriteLine();
        #endregion

        #region Tìm phần tử lớn nhất, phần tử lẻ lớn nhất
        int max = array[0], maxOdd = 0;
        int index = 1, indexOdd = 1;
        bool hasOddValue = false;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] % 2 != 0)
            {
                hasOddValue = true;
                maxOdd = array[j];
                indexOdd = j + 1;
                break;
            }
        }
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > max)
            {
                max = array[j];
                index = j + 1;
            }
            if (array[j] > maxOdd && array[j] % 2 != 0)
            {
                maxOdd = array[j];
                indexOdd = j + 1;
            }
        }
        Console.WriteLine(
            hasOddValue ? "\n=> The largest property value in the list is " + max + " at position " + index
            + ",\nand the odd largest property value in the list is " + maxOdd + " at position " + indexOdd
        : "\n=> The largest property value in the list is " + max + " at position " + index
            + ",\nand the odd value in the list is not exist");
        #endregion
    }
    #endregion

    #region Exercise
    public static void AddElementsToArray()
    {
        #region Khai báo và khởi tạo mảng số nguyên gồm N phần tử cho trước
        int[] array = InstantiateArray();
        int n = array.Length;

        Console.WriteLine("\n=> Initial element list: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + "\t");
        }
        Console.WriteLine("\n");
        #endregion

        #region Thực hiện chèn phần tử X ở vị trí index vào mảng
        Console.Write("Enter the element to add: ");
        int x = GetInteger(int.MinValue, int.MaxValue, "Enter again!");
        Console.Write("Enter the index to add (1 - " + (n - 2) + "): ");
        int index = GetInteger(1, n - 2, "Enter again!");

        Array.Resize(ref array, array.Length + 1);
        for (int j = array.Length - 1; j > index; j--)
        {
            array[j] = array[j - 1];
        }
        array[index] = x;

        Console.WriteLine("=> Element list after adding: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + "\t");
        }
        Console.WriteLine();
        #endregion
    }

    public static void FindMaxValueInTwoDimensionalArray()
    {
        #region Khai báo và khởi tạo mảng 2 chiều
        int[,] array = InstantiateMatrix();
        Console.WriteLine("\n=> Two-dimensional array: ");
        for (int i = 0; i < array.GetLength(0); i++) //row
        {
            for (int j = 0; j < array.GetLength(1); j++) //column
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region Tìm phần tử lớn nhất
        int max = array[0, 0];
        int r = 0, c = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    r = i + 1;
                    c = j + 1;
                }
            }
        }
        Console.WriteLine("=> The largest property value in the array is " + max + " in row " + r + ", column " + c);
        #endregion
    }

    public static void SumTheMainDiagonalOfSquareMatrix()
    {
        #region Khai báo và khởi tạo mảng 2 chiều
        int[,] array = InstantiateMatrix();
        Console.WriteLine("\n=> Two-dimensional array: ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region Tính tổng các số ở đường chéo chính của ma trận vuông
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            try
            {
                sum += array[i, i];
            }
            catch (IndexOutOfRangeException ioore)
            {
                sum += 0;
            }
        }
        Console.WriteLine("=> The sum of the numbers on the main diagonal of the square matrix is " + sum);
        #endregion
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

    private static int[,] InstantiateMatrix()
    {
        Console.Write("Enter a number of row: ");
        int row = GetInteger(1, int.MaxValue, "Enter again!");
        Console.Write("Enter a number of column: ");
        int column = GetInteger(1, int.MaxValue, "Enter again!");
        int[,] array = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write("- Enter element in row " + (i + 1) + ", column " + (j + 1) + ": ");
                array[i, j] = GetInteger(int.MinValue, int.MaxValue, "Enter again!");
            }
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
    #endregion
}