using System.Drawing;
using System.Drawing.Drawing2D;

namespace _1_laba_Graphics
{
    public class Interpolation : Shape
    {
        public override void Paint(Graphics graphic)
        {
            Point[] myPoints = new[] { new Point(0, 0), new Point(200, 0), new Point(200, 200), new Point(0, 200) };
            PathGradientBrush myBrush = new PathGradientBrush(myPoints);
            Color[] colors = new[] { Color.FromArgb(255, 0, 128, 0), Color.FromArgb(255, 128, 0, 255), Color.FromArgb(255, 0, 128, 128) };
            float[] relativePositions = new[] { 0.0F, 0.4F, 1.0F };
            ColorBlend colorBlend = new ColorBlend();
            colorBlend.Colors = colors;
            colorBlend.Positions = relativePositions;
            myBrush.InterpolationColors = colorBlend;
            // Заливаем прямоугольник, больший по размерам, чем квадрат
            graphic.FillRectangle(myBrush, 0, 0, 200, 200);
        }
    }
}
