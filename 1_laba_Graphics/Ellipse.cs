using System.Drawing;

namespace _1_laba_Graphics
{
    public class Ellipse : Shape
    {
        public int Width;
        public int Height;
        public Ellipse(int x, int y, int width, int height, Color color)
        {
            this.x = x;
            this.y = y;
            this.Width = width;
            this.Height = height;
            this.color = color;
        }
        public override void Paint(Graphics graphic)
        {
            graphic.DrawEllipse(new Pen(this.color, 3), x, y, Width, Height);
        }
    }
}
