using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass12_Sep18
{
    public class Board
    {
        public char PLAYER_FACTION = 'O'; 
        public char COMPUTER_FACTION = 'X'; 

        public char[,] squares = new char[3, 3];

        public Board()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    squares[i, j] = ' ';
                }
            }
        }

        public void Draw()
        {
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", squares[0, 0], squares[0, 1], squares[0, 2]);

            Console.WriteLine("_____|_____|_____");

            Console.WriteLine("     |     |");

            Console.WriteLine("  {0}  |  {1}  |  {2}", squares[1, 0], squares[1, 1], squares[1, 2]);

            Console.WriteLine("_____|_____|_____");

            Console.WriteLine("     |     |");

            Console.WriteLine("  {0}  |  {1}  |  {2}", squares[2, 0], squares[2, 1], squares[2, 2]);

            Console.WriteLine("     |     |");
        }

        public char CheckWin()
        {
            // Kiểm tra hàng ngang
            for (int i = 0; i < 3; i++)
            {
                if (squares[i, 0] != ' '
                    && squares[i, 0] == squares[i, 1]
                    && squares[i, 1] == squares[i, 2])
                {
                    return squares[i, 0];
                }
            }

            // Kiểm tra hàng dọc 
            for (int j = 0; j < 3; j++)
            {
                if (squares[0, j] != ' '
                    && squares[0, j] == squares[1, j]
                    && squares[1, j] == squares[2, j])
                {
                    return squares[0, j];
                }
            }

            // Kiểm tra đường chéo
            if (squares[0, 0] != ' '
                && squares[0, 0] == squares[1, 1]
                && squares[1, 1] == squares[2, 2])
            {
                return squares[0, 0];
            }

            if (squares[0, 2] != ' '
                && squares[0, 2] == squares[1, 1]
                && squares[1, 1] == squares[2, 0])
            {
                return squares[0, 2];
            }

            // Trả về ký tự người chiến thắng, nếu không có thì trả về ' '
            return ' ';
        }
    }
}
