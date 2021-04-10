using System.Drawing;
using System.Drawing.Drawing2D;

namespace _1_laba_Graphics
{
    public class GradientAlongThePath : Shape
    {
        public override void Paint(Graphics graphic)
        {
            GraphicsPath MyPath = new GraphicsPath();
            MyPath.AddRectangle(new Rectangle(0, 0, 200, 100));
            PathGradientBrush myBrush = new PathGradientBrush(MyPath);
            Color[] redColor = new[] { Color.Red };
            myBrush.SurroundColors = redColor;
            myBrush.CenterColor = Color.Aqua;
            graphic.FillPath(myBrush, MyPath);
            myBrush.FocusScales = new PointF(0.2F, 0.5F);
            graphic.TranslateTransform(0.0F, 150.0F);
            graphic.FillPath(myBrush, MyPath);
        }
    }
}
