using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class MyLine : MyShape
    {
        public Point X { get; set; }
        public Point Y { get; set; }

        public MyLine(Point p1 , Point p2)
        {
            X = p1;
            Y = p2;
        }
        public override void DrawShape(Graphics g)
        {
           Pen pen = new Pen(Color.Red);
            g.DrawLine(pen, X , Y);
        }
    }
}
