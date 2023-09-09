using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass8_Sep08
{
    public class Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point2D() { }

        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float[] GetXY()
        {
            return new float[2] { X, Y };
        }

        public void SetXY(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public class Point3D : Point2D
    {
        public float Z { get; set; }

        public Point3D() { }

        public Point3D(float x, float y, float z) : base(x, y)
        {
            Z = z;
        }

        public float[] GetXYZ()
        {
            return new float[3] { X, Y, Z };
        }

        public void SetXYZ(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
