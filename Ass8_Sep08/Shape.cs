using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass8_Sep08
{
    public class Shape
    {
        private string color = "green";
        private bool isFilled = true;

        public string Color { get { return color; } set { color = value; } }

        public bool IsFilled { get { return isFilled; } set { isFilled = value; } }

        public Shape() { }

        public Shape(string color, bool isFilled)
        {
            Color = color;
            IsFilled = isFilled;
        }

        public override string ToString()
        {
            return "A Shape with color of " + Color + " and "
                    + (IsFilled ? "filled" : "not filled");
        }
    }

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

    public class Rectangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle() { }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            Width = width;
            Length = length;
        }

        public double GetArea() => Width * Length;

        public double GetPerimeter() => 2 * (Width + Length);

        public override string ToString()
        {
            return "A Rectangle with width = " + Width
                    + " and length = " + Length
                    + ", which is a subclass of " + base.ToString();
        }
    }

    public class Square : Rectangle
    {
        public Square() { }

        public Square(double side) : base(side, side) { }

        public Square(double side, string color, bool filled) : base(side, side, color, filled) { }

        public double Side
        {
            get
            {
                return Width;
            }
            set
            {
                Width = value;
                Length = value;
            }
        }

        public override string ToString()
        {
            return "A Square with side = " + Side
                    + ", which is a subclass of " + base.ToString();
        }
    }
}
