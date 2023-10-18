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
        public char Faction { get; set; }

        public virtual void TakeTurn(Board board) { }

        public override string? ToString()
        {
            return Name + " - " + Faction;
        }
    }

    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, char faction)
        {
            Name = name;
            Faction = faction;
        }

        public override void TakeTurn(Board board)
        {
            bool turnCompleted = false;

            // Hiển thị bảng cờ
            board.Display();

            // Nhập vào tọa độ ô người chơi muốn đánh
            Console.WriteLine($"=> Lượt của {Name}: Hãy chọn vị trí đánh cờ");

            while (!turnCompleted)
            {
                Console.Write("Hàng thứ ");
                int row = Program.GetInteger(1, 3, "Nhập lại!");
                Console.Write("Cột thứ ");
                int col = Program.GetInteger(1, 3, "Nhập lại!");

                int indexRow = row - 1, indexCol = col - 1;
                // Kiểm tra tọa độ hợp lệ
                if (board.Squares[indexRow, indexCol] == ' ')
                {
                    // Đánh dấu ô đã đánh
                    board.Squares[indexRow, indexCol] = Faction;
                    turnCompleted = true;
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ô đã được đánh, xin mời đánh lại!");
                    Console.ResetColor();
                }
            }
        }
    }

    public class ComputerPlayer : Player
    {
        public ComputerPlayer(char faction)
        {
            Name = "AI";
            Faction = faction;
        }

        public override void TakeTurn(Board board)
        {
            if (!board.IsFull)
            {
                // Sinh tọa độ ngẫu nhiên 
                Random rnd = new Random();
                int row = rnd.Next(0, 3);
                int col = rnd.Next(0, 3);

                while (board.Squares[row, col] != ' ')
                {
                    // Sinh lại nếu trùng ô đã đánh
                    row = rnd.Next(0, 3);
                    col = rnd.Next(0, 3);
                }

                // Đánh dấu ô máy chọn
                board.Squares[row, col] = Faction;
            }

        }
    }
}
