using System.Drawing;
using System.Drawing.Drawing2D;

namespace _1_laba_Graphics
{
    public class Gradient : Shape
    {
        Color Main_color;
        public Gradient(Color color)
        {
            Main_color = color;
        }

        public override void Paint(Graphics graphic)
        {
            Rectangle MyRectangle = new Rectangle(200, 200, 400, 400);
            Pen MyPen = new Pen(Color.Black , 5);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(MyRectangle);
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            // Центр пути будет красного цвета
            pthGrBrush.CenterColor = Main_color;
            graphic.DrawEllipse(MyPen, MyRectangle);
            graphic.FillPath(pthGrBrush, path);
        }
    }
}
