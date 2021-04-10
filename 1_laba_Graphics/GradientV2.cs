using System.Drawing;
using System.Drawing.Drawing2D;

namespace _1_laba_Graphics
{
    public class GradientV2 : Shape
    {
        public override void Paint(Graphics graphic)
        {
            PointF[] myPoints = new[] {
                new PointF(200, 100),
                new PointF(400, 100),
                new PointF(500, 200),
                new PointF(500, 400),
                new PointF(400, 500),
                new PointF(200, 500),
                new PointF(100, 400),
                new PointF(100, 200) };
            PathGradientBrush myBrush = new PathGradientBrush(myPoints);
            Color[] colors = new[] {
                Color.FromArgb(255, 255, 255, 255),
                Color.FromArgb(255, 255, 255, 0),
                Color.FromArgb(255, 255, 0, 255),
                Color.FromArgb(255, 0, 255, 255),
                Color.FromArgb(255, 255, 0, 0),
                Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 0, 0, 255),
                Color.FromArgb(255, 0, 0, 0) };
            myBrush.SurroundColors = colors;
            myBrush.CenterColor = Color.White;
            graphic.FillRectangle(myBrush, new Rectangle(100, 100, 500, 500));
        }
    }
}
