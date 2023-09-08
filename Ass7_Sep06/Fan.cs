using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ass7_Sep06
{
    public class Fan
    {
        public const int SLOW = 1, MEDIUM = 2, FAST = 3;

        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";

        public int Speed { get { return speed; } set { speed = value; } }
        public bool On { get { return on; } set { on = value; } }
        public double Radius { get { return radius; } set { radius = value; } }
        public string Color { get { return color; } set { color = value; } }

        public Fan()
        {
        }

        public Fan(int speed, bool on, double radius, string color)
        {
            Speed = speed;
            On = on;
            Radius = radius;
            Color = color;
        }

        public override string ToString()
        {
            return On ? "Fan is on\nSpeed = " + Speed + ", Color = " + Color + ", Radius = " + Radius
                : "Fan is off\nColor = " + Color + ", Radius = " + Radius;
        }
    }
}
