using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass8_Sep08
{
    public class Circle : Shape
    {
        private double radius = 1.0;

        public double Radius { get; set; }

        public Circle() { }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(double radius, string color, bool isFilled) : base(color, isFilled)
        {
            Radius = radius;
        }

        public double GetArea() => Radius * Radius * Math.PI;

        public double GetPerimeter() => 2 * Radius * Math.PI;

        public override string ToString()
        {
            return "A Circle with radius = " + Radius
                    + ", which is a subclass of " + base.ToString();
        }
    }
}
