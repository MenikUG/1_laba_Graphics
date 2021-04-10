using System.Drawing;
using System.Drawing.Drawing2D;

namespace _1_laba_Graphics
{
    public class Complement : Shape
    {
        public override void Paint(Graphics graphic)
        {
            GraphicsPath FirstPath = new GraphicsPath();
            GraphicsPath SecondPath = new GraphicsPath();
            Rectangle regionRect = new Rectangle(20, 20, 100, 100);
            FirstPath.AddEllipse(regionRect);
            graphic.DrawPath(Pens.Black, FirstPath);
            Rectangle complementRect = new Rectangle(90, 30, 100, 100);
            SecondPath.AddEllipse(complementRect);
            graphic.DrawPath(Pens.Red, SecondPath);
            Region myRegion = new Region(FirstPath);
            Region complementRegion = new Region(SecondPath);
            myRegion.Complement(SecondPath);
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            graphic.FillRegion(myBrush, myRegion);
        }
    }
}
