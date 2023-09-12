using Ass8_Sep08;

namespace Ass9_Sep11
{
    public interface Resizeable
    {
        public void Resize(double percent);
    }

    public class CircleResizer : Circle, Resizeable
    {
        public CircleResizer() { }
        public CircleResizer(double radius) : base(radius) { }

        public void Resize(double percent)
        {
            Radius *= (1 + percent);
        }

        public override string ToString()
        {
            return "A Circle with radius = " + Radius + ", and area = " + GetArea();
        }
    }

    public class RectangleResizer : Rectangle, Resizeable
    {
        public RectangleResizer() { }
        public RectangleResizer(double width, double length) : base(width, length) { }

        public void Resize(double percent)
        {
            Width *= (1 + percent / 100);
            Length *= (1 + percent / 100);
        }

        public override string ToString()
        {
            return "A Rectangle with width = " + Width + " and length = " + Length
                + ", and area = " + GetArea();
        }
    }

    public class SquareResizer : Square, Resizeable
    {
        public SquareResizer() { }
        public SquareResizer(double side) : base(side) { }

        public void Resize(double percent)
        {
            Side *= (1 + percent / 100);
        }

        public override string ToString()
        {
            return "A Square with side = " + Side + ", and area = " + GetArea();
        }
    }
}
