using Ass8_Sep08;

namespace Ass9_Sep11
{
    public class ComparableCircle : Circle, IComparable<ComparableCircle>
    {
        public ComparableCircle() { }
        public ComparableCircle(double radius) : base(radius) { }
        public ComparableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

        public int CompareTo(ComparableCircle? other)
        {
            if (Radius > other.Radius) return 1;
            else if (Radius < other.Radius) return -1;
            else return 1;
        }
    }
}
