using Ass12_Sep18;
using System.Text;

class Program
{
    static Board board;
    static Player p1;
    static Player p2;

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        InstantiateObject();

        bool gameOver = false;
        char result = ' ';
        while (!gameOver)
        {
            p1.TakeTurn(board);
            result = board.CheckWin();
            if (result != ' ')
            {
                gameOver = true;
                board.Draw();
                SaveGameRecord(result);
                break;
            }

            p2.TakeTurn(board);
            result = board.CheckWin();
            if (result != ' ')
            {
                gameOver = true;
                board.Draw();
                SaveGameRecord(result);
                break;
            }
        }
    }

    public static void InstantiateObject()
    {
        board = new Board();
        p1 = new HumanPlayer();
        p2 = new ComputerPlayer();
    }

    public static void SaveGameRecord(char result)
    {
        // Mở file
        string logFilePath = "D:\\BaoDuy\\.Unity\\_CodeGym\\BaoDuy\\Ass12_Sep18\\playerlog.txt";
        StreamWriter sw = new StreamWriter(logFilePath, true);

        // Ghi nội dung
        sw.WriteLine("Ngày {0}", DateTime.Now);

        if (result == board.PLAYER_FACTION)
        {
            sw.WriteLine("Win");
        }
        else if (result == board.COMPUTER_FACTION)
        {
            sw.WriteLine("Lose");
        }
        else
        {
            sw.WriteLine("Draw");
        }

        // Đóng file
        sw.Close();
    }
}