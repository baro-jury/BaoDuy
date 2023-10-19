using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass8_Sep08
{
    public class Circle : Shape
    {
        public double Radius { get; set; } = 1.0;

        public Circle() { }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
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

    public class Cylinder : Circle
    {
        public double Height { get; set; } = 1.0;

        public Cylinder() { }

        public Cylinder(double height, double radius) : base(radius)
        {
            Height = height;
        }

        public Cylinder(double height, double radius, string color) : base(radius, color)
        {
            Height = height;
        }

        public double GetVolume() => Height * GetArea();

        public override string ToString()
        {
            return "A Cylinder with height = " + Height
                    + ", which is a subclass of " + base.ToString();
        }
    }
}
