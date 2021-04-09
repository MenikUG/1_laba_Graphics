using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_laba_Graphics
{
    public class Bezier : Shape
    {
        Point point1;
        Point point2;
        Point point3;
        Point point4;
        public Bezier(Point p1, Point p2, Point p3, Point p4, Color color)
        {
            point1 = p1;
            point2 = p2;
            point3 = p3;
            point4 = p4;
            this.color = color;
        }
        public override void Paint(Graphics graphic)
        {
            graphic.DrawBezier(new Pen(this.color, 3), point1, point2, point3, point4);
        }
    }
}
