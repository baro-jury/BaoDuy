using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass12_Sep18
{
    public class Player
    {
        public string Name { get; set; }

        public virtual void TakeTurn(Board board) { }

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

    public class HumanPlayer : Player
    {
        public override void TakeTurn(Board board)
        {
            // Hiển thị bảng cờ
            board.Draw();

            // Nhập vào tọa độ ô người chơi muốn đánh
            Console.Write("Nhập hàng: ");
            int row = GetInteger(0, 2, "Enter again!");
            Console.Write("Nhập cột: ");
            int col = GetInteger(0, 2, "Enter again!");

            // Kiểm tra tọa độ hợp lệ
            if (row >= 0 && row < 3 && col >= 0 && col < 3
                && board.squares[row, col] == ' ')
            {

                // Đánh dấu ô đã đánh
                board.squares[row, col] = board.PLAYER_FACTION;
            }
            else
            {
                Console.WriteLine("Ô đã được đánh hoặc tọa độ không hợp lệ!");
            }
        }
    }

    public class ComputerPlayer : Player
    {
        public override void TakeTurn(Board board)
        {
            // Sinh tọa độ ngẫu nhiên 
            Random rnd = new Random();
            int row = rnd.Next(0, 3);
            int col = rnd.Next(0, 3);

            while (board.squares[row, col] != ' ')
            {
                // Sinh lại nếu trùng ô đã đánh
                row = rnd.Next(0, 3);
                col = rnd.Next(0, 3);
            }

            // Đánh dấu ô máy chọn
            board.squares[row, col] = board.COMPUTER_FACTION;
        }
    }
}
