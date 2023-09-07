using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass6_Aug30
{
    class SnakeLite
    {
        public void CreateMap(int width, int height)
        {

        }

        private void SpawnMapWall(int width, int height) 
        {
            Console.Clear();
            width = 20;
            height = 8;

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
        }


        private void DrawBound(int width, int height)
        {
            //draw top
            for (int i = 0; i < width; i++)
            {
                DrawAt(1, 0, '#');
            }

            //draw bottom
            for (int i = 0; i < width; i++)
            {
                DrawAt(i, height - 1, '#');
            }

            //draw left
            for (int i = 1; i < height; i++)
            {
                DrawAt(0, 1, '#');
            }


        }

        private void DrawAt(int v1, int v2, char v3)
        {
            throw new NotImplementedException();
        }

        public void SpawnFood()
        {

        }

        public void ControlSnake()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                // Di chuyển đối tượng lên trên
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                // Di chuyển đối tượng xuống dưới
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                // Di chuyển đối tượng sang trái
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                // Di chuyển đối tượng sang phải
            }
        }
    }
}
