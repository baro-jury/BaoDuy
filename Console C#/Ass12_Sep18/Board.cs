using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass12_Sep18
{
    public class Board
    {
        public char[,] Squares { get; set; } = new char[3, 3];
        public bool IsFull { get; set; }

        public Board()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Squares[i, j] = ' ';
                }
            }
        }

        public void CheckFullBoard()
        {
            IsFull = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Squares[i, j] == ' ')
                    {
                        IsFull = false;
                        goto endFunction;
                    }
                }
            }
        endFunction:;
        }

        public void Display()
        {
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Squares[0, 0], Squares[0, 1], Squares[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Squares[1, 0], Squares[1, 1], Squares[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Squares[2, 0], Squares[2, 1], Squares[2, 2]);
            Console.WriteLine("     |     |");
            Console.WriteLine();
        }

        public char CheckWin()
        {
            // Kiểm tra hàng ngang
            for (int i = 0; i < 3; i++)
            {
                if (Squares[i, 0] != ' '
                    && Squares[i, 0] == Squares[i, 1]
                    && Squares[i, 1] == Squares[i, 2])
                {
                    return Squares[i, 0];
                }
            }

            // Kiểm tra hàng dọc 
            for (int j = 0; j < 3; j++)
            {
                if (Squares[0, j] != ' '
                    && Squares[0, j] == Squares[1, j]
                    && Squares[1, j] == Squares[2, j])
                {
                    return Squares[0, j];
                }
            }

            // Kiểm tra đường chéo
            if (Squares[0, 0] != ' '
                && Squares[0, 0] == Squares[1, 1]
                && Squares[1, 1] == Squares[2, 2])
            {
                return Squares[0, 0];
            }

            if (Squares[0, 2] != ' '
                && Squares[0, 2] == Squares[1, 1]
                && Squares[1, 1] == Squares[2, 0])
            {
                return Squares[0, 2];
            }

            // Trả về ký tự người chiến thắng, nếu không có thì trả về ' '
            return ' ';
        }
    }
}
