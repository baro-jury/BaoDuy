using Ass12_Sep18;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class Program
{
    static Player p1;
    static Player p2;

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Board board = new Board();
        InstantiatePlayers();

        bool gameOver = false;
        char result = ' ';
        while (!gameOver)
        {
            p1.TakeTurn(board);
            result = board.CheckWin();
            if (result != ' ')
            {
                break;
            }
            board.CheckFullBoard();

            p2.TakeTurn(board);
            result = board.CheckWin();
            if (result != ' ')
            {
                break;
            }
            board.CheckFullBoard();

            gameOver = board.IsFull;
        }

        board.Display();
        SaveGameRecord(result);
    }

    public static void InstantiatePlayers()
    {
        Console.Write("Số người chơi: ");
        int players = GetInteger(1, 2, "Nhập lại!");

        Console.WriteLine("\nNgười chơi 1 nhập thông tin:");
        Console.Write("Tên: ");
        string name1 = GetString("AI", "^\\w+$", "Không cho phép kí tự đặc biệt!");
        Console.Write("Quân cờ: ");
        string faction = GetString(null, "^[OXox]$", "Chỉ cho phép quân O hoặc X!");
        char faction1 = faction.ToUpper().ToCharArray()[0];
        char faction2 = faction1 == 'O' ? 'X' : 'O';

        p1 = new HumanPlayer(name1, faction1);
        if (players == 1)
        {
            p2 = new ComputerPlayer(faction2);
        }
        else
        {
            Console.WriteLine("\nNgười chơi 2 nhập thông tin:");
            Console.Write("Tên: ");
            string name2 = GetString(null, "^\\w+$", "Không cho phép kí tự đặc biệt!");
            p2 = new HumanPlayer(name2, faction2);
        }

        Console.WriteLine("\n-> Nguời chơi 1: " + p1.ToString());
        Console.WriteLine("-> Nguời chơi 2: " + p2.ToString()
            + "\nNhấn phím bất kỳ để bắt đầu trò chơi!");
        Console.ReadLine();
        Console.Clear();
    }

    public static void SaveGameRecord(char result)
    {
        string logFilePath = "D:\\BaoDuy\\.Unity\\_CodeGym\\BaoDuy\\Ass12_Sep18\\playerlog.txt";
        StreamWriter sw = new StreamWriter(logFilePath, true);

        sw.WriteLine("Ngày {0}", DateTime.Now);

        if (result == p1.Faction)
        {
            Console.WriteLine($"=> {p1.Name} thắng!");
            sw.WriteLine($"{p1.Name} thắng");
        }
        else if (result == p2.Faction)
        {
            Console.WriteLine($"=> {p2.Name} thắng!");
            sw.WriteLine($"{p2.Name} thắng");
        }
        else
        {
            Console.WriteLine("=> Hòa!");
            sw.WriteLine("Hòa");
        }

        sw.Close();
    }

    #region Validation
    public static int GetInteger(int min, int max, string errorMsg)
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
            catch (ArgumentOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ngoài phạm vi cho phép!");
                Console.ResetColor();
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMsg);
                Console.ResetColor();
            }
        }
    }

    public static string GetString(string? duplicatedName, string regex, string errorMsg)
    {
        while (true)
        {
            try
            {
                string input = Console.ReadLine();
                if (input.Equals(duplicatedName))
                {
                    throw new DuplicatedStringException();
                }
                if (!Regex.Match(input, regex).Success)
                {
                    throw new Exception();
                }
                else return input;
            }
            catch (DuplicatedStringException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Đã được sử dụng!");
                Console.ResetColor();
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMsg);
                Console.ResetColor();
            }
        }
    }
    #endregion
}