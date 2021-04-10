using System.Drawing;

namespace _1_laba_Graphics
{
    public class Pie: Shape
    {
        public int Width;
        public int Height;
        public float startAngle;
        public float endAngle;
        public Pie(int x, int y, int Width, int Height, float startAngle, float endAngle, Color color)
        {
            this.x = x;
            this.y = y;
            this.Width = Width;
            this.Height = Height;
            this.startAngle = startAngle;
            this.endAngle = endAngle;
            this.color = color;
        }

        public override void Paint(Graphics graphic)
        {
            Rectangle rect = new Rectangle(x, y, Width, Height);
            graphic.FillPie(new SolidBrush(color), rect, startAngle, endAngle);
            graphic.DrawEllipse(new Pen(Color.Black, 2), rect);
        }
    }
}
