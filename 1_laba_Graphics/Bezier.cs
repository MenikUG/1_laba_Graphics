using System.Drawing;

namespace _1_laba_Graphics
{
    public class Bezier : Shape
    {
        public Point pt1;
        public Point pt2;
        public Point pt3;
        public Point pt4;
        public Bezier(Point p1, Point p2, Point p3, Point p4, Color color)
        {
            pt1 = p1;
            pt2 = p2;
            pt3 = p3;
            pt4 = p4;
            this.color = color;
        }
        public override void Paint(Graphics graphic)
        {
            graphic.DrawBezier(new Pen(this.color, 3), pt1, pt2, pt3, pt4);
        }
    }
}
