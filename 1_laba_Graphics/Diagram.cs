using System.Drawing;

namespace _1_laba_Graphics
{
    public class Diagram: Pie
    {
        public Diagram(int x, int y, int Width, int Height, float startAngle, float endAngle, Color color) : base(x, y, Width, Height, startAngle, endAngle, color)
        {
        }

        public override void Paint(Graphics graphic)
        {
            Rectangle rect = new Rectangle(x, y, Width, Height);
            graphic.FillPie(new SolidBrush(Color.LightGoldenrodYellow), rect, 0, 130);
            graphic.FillPie(new SolidBrush(Color.PaleTurquoise), rect, 130, 205);
            graphic.FillPie(new SolidBrush(Color.RoyalBlue), rect, 205, 290);
            graphic.FillPie(new SolidBrush(Color.Purple), rect, 290, 50);
            graphic.DrawEllipse(new Pen(Color.Black, 2), rect);
        }
    }
}
