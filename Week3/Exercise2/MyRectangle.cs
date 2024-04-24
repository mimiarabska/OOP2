using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

    }
    class MyRectangle
    {
        public double Perimeter { get; set; }
        public double Face { get; set; }   

        public MyRectangle(Point a, Point b)
        {
            Perimeter = Math.Abs(a.X - b.X)*2 + Math.Abs(a.Y - b.Y) * 2;
            Face = Math.Abs(a.X - b.X) * Math.Abs(a.Y - b.Y);
        }
    }
}
