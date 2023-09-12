using Ass8_Sep08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass9_Sep11
{
    public interface IColorable
    {
        public void HowToColor();
    }

    public class SquareColor : Square, IColorable
    {
        public SquareColor() { }
        public SquareColor(double side) : base(side) { }

        public void HowToColor()
        {
            Console.WriteLine("Color all four sides.");
        }
    }
}
