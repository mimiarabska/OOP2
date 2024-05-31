using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class MyRectangle : MyShape
    {
        public Point StarPoint { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public MyRectangle(Point starPoint, int width, int height)
        {
            StarPoint = starPoint;
            Width = width;
            Height = height;
        }
        public override void DrawShape(Graphics g)
        {
            Pen p = new Pen(Color.Blue);
            g.DrawRectangle(p, StarPoint.X, StarPoint.Y, Width, Height);

        }
    }
}
