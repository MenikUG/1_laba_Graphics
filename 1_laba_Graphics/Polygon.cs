using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace _1_laba_Graphics
{
    public class Polygon : Shape
    {
        PointF point1, point2, point3, point4, point5, point6, point7, point8;
        public Polygon(Color color)
        {
            point1 = new PointF(0.0F, 0.0F);
            point2 = new PointF(100.0F, 25.0F);
            point3 = new PointF(200.0F, 5.0F);
            point4 = new PointF(250.0F, 50.0F);
            point5 = new PointF(300.0F, 100.0F);
            point6 = new PointF(350.0F, 200.0F);
            point7 = new PointF(200.0F, 200.0F);
            point8 = new PointF(130.0F, 230.0F);
            this.color = color;
        }

        public override void Paint(Graphics graphic)
        {
            PointF[] pointF = new[] { point1, point2, point3, point4, point5, point6, point7, point8 };
            HatchBrush hatBrush = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Black, this.color);
            FillMode newFillMode = FillMode.Winding;
            graphic.FillPolygon(hatBrush, pointF, newFillMode);
        }
    }
}
