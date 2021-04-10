using System.Drawing;
using System.Drawing.Drawing2D;

namespace _1_laba_Graphics
{
    public class SubShape : Shape
    {
        public int Width;
        public int Height;
        public SubShape(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public override void Paint(Graphics graphic)
        {
            GraphicsPath FirstPath = new GraphicsPath();
            GraphicsPath SecondPath = new GraphicsPath();

            FirstPath.AddEllipse(new Rectangle(x, y, 200, 100));
            SecondPath.AddRectangle(new Rectangle(x + 50, y + 50, 200, 100));

            Region myRegion = new Region(FirstPath);
            myRegion.Xor(SecondPath);

            graphic.FillRegion(new SolidBrush(this.color), myRegion);
        }
    }
}
