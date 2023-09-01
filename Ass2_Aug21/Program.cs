class Program
{
    private static void Main(string[] args)
    {
        ResolveLinearEquation();
        Console.WriteLine("-------------------------------");
        ResolveQuadraticEquation();
        Console.WriteLine("-------------------------------");
        CalculateBodyMassIndex();
        Console.WriteLine("-------------------------------");
        ReadNumbersIntoWords();
    }

    public static void ResolveLinearEquation()
    {
        try
        {
            Console.WriteLine("Enter constants for an equation as 'a*x + b = 0'");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                if (b == 0) Console.WriteLine("The solution for '{0}*x = 0' is {1}", a, 0);
                else Console.WriteLine("The solution for '{0}*x + {1} = 0' is {2}", a, b, -b / a);
            }
            else
            {
                Console.WriteLine(b == 0 ? "The solution is all x!" : "No solution!");
            }

            Console.WriteLine("----------");

            Console.WriteLine("Enter constants for an equation as 'a*x + b = c'");
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                if (b == 0) Console.WriteLine("The solution for '{0}*x = {1}' is {2}", a, c, c / a);
                else Console.WriteLine("The solution for '{0}*x + {1} = {2}' is {3}", a, b, c, (c - b) / a);
            }
            else
            {
                Console.WriteLine(b == c ? "The solution is all x!" : "No solution!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void ResolveQuadraticEquation()
    {
        try
        {
            Console.WriteLine("Enter constants for an equation as 'a * x^2 + b * x + c = 0'");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            if ((a + b + c) == 0) Console.WriteLine("The solution is x1 = {0}, x2 = {1}", 1, c / a);
            else if ((a - b + c) == 0) Console.WriteLine("The solution is x1 = {0}, x2 = {1}", -1, -c / a);
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta > 0)
                {
                    Console.WriteLine("The solution is x1 = {0}, x2 = {1}", (-b + Math.Sqrt(delta)) / 2 * a, (-b - Math.Sqrt(delta)) / 2 * a);
                }
                else
                {
                    Console.WriteLine(delta == 0 ? "The solution is x1 = x2 = " + (-b / 2 * a) : "No solution!");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void CalculateBodyMassIndex()
    {
        try
        {
            Console.Write("Enter your height (m): ");
            double height = float.Parse(Console.ReadLine());
            Console.Write("Enter your weight (kg): ");
            double weight = float.Parse(Console.ReadLine());
            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);
            Console.WriteLine("BMI: " + bmi);

            if (bmi < 18.5) Console.WriteLine("Underweight");
            else if (bmi < 25) Console.WriteLine("Normal");
            else if (bmi < 30) Console.WriteLine("Overweight");
            else Console.WriteLine("Obese");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public static void ReadNumbersIntoWords()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertNumberToWords(number));
        }
        catch (ArgumentOutOfRangeException aoore)
        {
            Console.WriteLine("Out of ability");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
    }

    public static string ConvertNumberToWords(int number)
    {
        string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                             "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (number < 0 || number > 999)
        {
            throw new ArgumentOutOfRangeException();
        }

        string result = "";
        switch (number / 100)
        {
            case 0:
                if (number < 20)
                {
                    result = ones[number];
                }
                else
                {
                    result = tens[number / 10]
                        + (number % 10 != 0 ? " " + ones[number % 10] : "");
                }
                break;
            case 1:
                result = ones[number / 100] + " hundred"
                    + (number % 100 != 0 ? " and " + ConvertNumberToWords(number % 100) : "");
                break;
            default:
                result = ones[number / 100] + " hundreds"
                    + (number % 100 != 0 ? " and " + ConvertNumberToWords(number % 100) : "");
                break;
        }
        return result;
    }
}