using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class MyHouse : MyShape
    {
        public Point StarPoint { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public MyHouse(Point starPoint, int width, int height)
        {

        }
        public override void DrawShape(Graphics g)
        {
            Pen p = new Pen(Color.Aqua);

        }
    }
}
