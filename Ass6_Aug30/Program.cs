using Ass6_Aug30;

class Program
{
    static SnakeLite snakeLite = new SnakeLite();
    private static void Main(string[] args)
    {
        Console.Title = "Snake Lite";

        Console.Write("Enter width (at least 10): ");
        int widthInside = GetInteger(10, int.MaxValue, "Enter again!");
        Console.Write("Enter height (at least 5): ");
        int heightInside = GetInteger(5, int.MaxValue, "Enter again!");

        //int widthInside = 20;
        //int heightInside = 8;
        snakeLite.CreateMap(widthInside, heightInside);

        int snakePosRow = 1, snakePosCol = 1;

        (int, int) foodPos = snakeLite.RandomFoodPosition(widthInside, heightInside, snakePosCol, snakePosRow);

        snakeLite.SpawnSnake(snakePosCol, snakePosRow);
        snakeLite.SpawnFood(foodPos);
        Console.SetCursorPosition(0, heightInside + 2);

        bool inGame = true;
        while (inGame)
        {
            Console.Title = "Snake Game Score: " + snakeLite.snake.Score;

            snakeLite.ControlSnake(ref snakePosCol, ref snakePosRow);
            Console.SetCursorPosition(0, heightInside + 2);

            if (snakePosCol == foodPos.Item1 && snakePosRow == foodPos.Item2)
            {
                snakeLite.snake.Score++;

                Console.SetCursorPosition(foodPos.Item1, foodPos.Item2);
                Console.Write(' ');

                foodPos = snakeLite.RandomFoodPosition(widthInside, heightInside, snakePosCol, snakePosRow);
                snakeLite.SpawnFood(foodPos);
                Console.SetCursorPosition(0, heightInside + 2);
            }

            if (snakePosRow > heightInside || snakePosRow < 1 || snakePosCol > widthInside || snakePosCol < 1)
            {
                inGame = false;
            }
        }

        Console.ResetColor();
        Console.SetCursorPosition(0, heightInside + 2);
        Console.WriteLine("\n=> Game Over!");
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
