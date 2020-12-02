using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_1
{
    class Point
    {
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public override string ToString()
        {
            return $"({x}; {y})";
        }
    }
}
