using Ass6_Aug30;

class Program
{
    SnakeLite snakeLite = new SnakeLite();
    private static void Main(string[] args)
    {
        //Console.SetCursorPosition(0, 0); // đặt vị trí của rắn hoặc mồi tại tọa độ (x, y)
        //Console.ForegroundColor = ConsoleColor.Green; // đặt màu cho rắn
        //Console.BackgroundColor = ConsoleColor.Red; // đặt màu cho mồi
        //Console.Write("O"); // vẽ rắn hoặc mồi bằng ký tự O

        //// xóa đi ký tự cũ
        //Console.SetCursorPosition(oldX, oldY); // đặt vị trí của rắn hoặc mồi tại tọa độ cũ
        //Console.Write(" "); // xóa ký tự cũ bằng khoảng trắng

        //// vẽ lại đối tượng ở vị trí mới
        //Console.SetCursorPosition(newX, newY); // đặt vị trí của rắn hoặc mồi tại vị trí mới
        //Console.ForegroundColor = ConsoleColor.Green; // đặt lại màu cho rắn
        //Console.BackgroundColor = ConsoleColor.Red; // đặt lại màu cho mồi
        //Console.Write("O"); // vẽ rắn hoặc mồi bằng ký tự O

        Console.Clear();
        int width = 20;
        int height = 8;

        //Ve hang tren cung
        Console.BackgroundColor = ConsoleColor.Red;
        for (int i = 0; i < width; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.Write('#');
        }
        //Ve hang duoi cung
        for (int i = 1; i < width; i++)
        {
            Console.SetCursorPosition(i, height);
            Console.Write('#');
        }
        //Ve hang ben trai
        for (int i = 1; i < height + 1; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write('#');
        }
        for (int i = 1; i < height + 1; i++)
        {
            Console.SetCursorPosition(width - 1, i);
            Console.Write('#');
        }
        Console.BackgroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(2, 2);
        Console.Write(' ');
        Console.SetCursorPosition(0, 9);
        Console.ResetColor();
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


//int width, height;
//bool isAlive = true;
//int[] bonusCord = new int[] { };
//bool didDrawBonus = false;
//static void Main(string[] args)
//{
//    Console.Clear();
//    Console.BackgroundColor = ConsoleColor.Red; Program pg = new Program(); pg.DrawBound(pg.width, pg.height);
//    pg.height = 9;
//    Pg.width = 20;
//    int[] snakeCord = { { 2, 2 } };
//    pg.SpawnBonus(snakeCord); while (pg.isAlive)
//    {
//        pg.DrawSnake(snakeCord);
//        ConsoleKeyInfo keyInfo = Console.ReadKey();
//        if (keyInfo.Key == ConsoleKey.UpArrow)
//        {
//            pg.MoveSnake(ref snakeCord, ConsoleKey.UpArrow);
//else if (keyInfo.Key == ConsoleKey.DownArrow)


//            { 
////eat bonus
//// int[] tempCord = new int[snakeCord.GetLength(0) + 1, 2];
//// int shiftedx snakeCord[snakeCord.GetLength (0) 1, 0] + shiftx; =
//// int shiftedy snakeCord [snakeCord.GetLength(0) 1, 1] + shifty; -
//// for (int i = 0; i < snakeCord.GetLength(0); i++)
//tempCord[i, 0] = snakeCord[i, 0];
//11
//tempCord[i, 1] = snakeCord[i, 1];
//// }
//// tempCord[snakeCord.GetLength(0), 0] = shiftedx;
//// tempCord [snakeCord.GetLength(0), 1] = shiftedY;
//// snakeCord = (int[,])tempCord.clone();
//// didDrawBonus = false;
//SpawnBonus(snakeCord);
//// return;
//}
//for (int i = 0; i < snakeCord.GetLength(0); i++)
//{
//    if (i snakeCord.GetLength(0) - 1)
//}
//snakeCord[i, 0] = snakeCord[i, 0] + shiftx; snakeCord[1, 1] = snakeCord[i, 1] + shifty;
//}
//}
//if (snakeCord[snakeCord.GetLength(0) - 1, 0] ==
//snakeCord[snakeCord.GetLength(0) 1, 0] - snakeCord[snakeCord.GetLength(0) 1, 1] snakeCord[snakeCord.GetLength(0) 1, 1] - == width - 1 || height || 0) == ==
//isAlive = false;
//Console.WriteLine("Game over");
//return;
//{
//}
//}