using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _1_laba_Graphics
{
    public class PolygonV2: Shape
    {
        List<Point> _points;

        public PolygonV2(List<Point> points, Color color)
        {
            _points = new List<Point>(points);
            this.color = color;
        }

        public override void Paint(Graphics graphic)
        {
            GraphicsPath GPath = new GraphicsPath();
            HatchBrush hatBrush = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Black, this.color);
            GPath.AddPolygon(_points.GetRange(0, 4).ToArray());
            GPath.AddPolygon(_points.GetRange(4, 4).ToArray());
            graphic.FillPath(hatBrush, GPath);
        }
    }
}
