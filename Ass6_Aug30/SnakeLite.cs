using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Ass6_Aug30
{
    class SnakeLite
    {
        Random random = new Random();
        public Snake snake = new Snake();

        public void CreateMap(int widthInside, int heightInside)
        {
            Console.Clear();

            string horizontalLine = "";
            for (int i = 0; i <= (widthInside + 1); i++)
            {
                horizontalLine += "#";
            }

            Console.BackgroundColor = ConsoleColor.Red;

            //Ve hang tren va duoi
            Console.SetCursorPosition(0, 0);
            Console.Write(horizontalLine);
            Console.SetCursorPosition(0, heightInside + 1);
            Console.Write(horizontalLine);

            //Ve hang ben trai
            for (int i = 1; i <= heightInside; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('#');
            }

            //Ve hang ben phai
            for (int i = 1; i <= heightInside; i++)
            {
                Console.SetCursorPosition(widthInside + 1, i);
                Console.Write('#');
            }

            Console.ResetColor();
        }

        public (int, int) RandomSnakePosition(int widthInside, int heightInside)
        //index cot, index hang
        {
            (int, int) snakePosition;
            snakePosition.Item1 = random.Next(1, widthInside);
            snakePosition.Item2 = random.Next(1, heightInside);
            return snakePosition;
        }

        public void SpawnSnake(int column, int row)
        {
            Console.SetCursorPosition(column, row);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(' ');
        }

        public void ControlSnake(ref int snakeCol, ref int snakeRow)
        {
            int tempCol = 0, tempRow = 0;

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            Console.SetCursorPosition(snakeCol, snakeRow);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(' ');

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    tempRow = snakeRow - 1;
                    tempCol = snakeCol;
                    break;
                case ConsoleKey.DownArrow:
                    tempRow = snakeRow + 1;
                    tempCol = snakeCol;
                    break;
                case ConsoleKey.LeftArrow:
                    tempRow = snakeRow;
                    tempCol = snakeCol - 1;
                    break;
                case ConsoleKey.RightArrow:
                    tempRow = snakeRow;
                    tempCol = snakeCol + 1;
                    break;
            }

            snakeCol = tempCol;
            snakeRow = tempRow;
            SpawnSnake(snakeCol, snakeRow);
        }

        public (int, int) RandomFoodPosition(int widthInside, int heightInside, int snakeCol, int snakeRow)
        //index cot, index hang
        {
            (int, int) foodPosition = (1, 1);
            while (foodPosition.Item1 == snakeCol && foodPosition.Item2 == snakeRow)
            {
                foodPosition.Item1 = random.Next(1, widthInside);
                foodPosition.Item2 = random.Next(1, heightInside);
            }
            return foodPosition;
        }

        public void SpawnFood((int, int) foodPosition)
        {
            int column = foodPosition.Item1, row = foodPosition.Item2;
            Console.SetCursorPosition(column, row);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('O');
        }
    }

    class Snake
    {
        private int score;

        public int Score { get; set; } = 0;
    }
}
