using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_laba_Graphics
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public int mode = 0;
		public int count_click = 0;
		Color color = Color.Red;
		List<Point> points = new List<Point>();
		List<Shape> storage = new List<Shape>();
		private void panel_drawing_Paint(object sender, PaintEventArgs e)
		{	// Для отрисовки на панели
			Graphics graphic = e.Graphics;
			foreach(Shape i in storage)
				i.Paint(graphic);
		}
		private void panel_drawing_MouseMove(object sender, MouseEventArgs e)
		{	// Для отображении линий
			if(mode == 1 && count_click == 1)
			{
				if (storage.Any()) 
					if (storage.Last() is Line)
						storage.RemoveAt(storage.Count - 1);				
				points.Insert(1, new Point(e.X, e.Y));
				storage.Add(new Line(points[0], points[1], color));
				panel_drawing.Refresh();
			}
			if(mode == 2 && count_click == 1)
            {
				if (storage.Any())
					if (storage.Last() is Ellipse)
						storage.RemoveAt(storage.Count - 1);
				storage.Add(new Ellipse(points[0].X, points[0].Y, e.X - points[0].X, e.Y - points[0].Y, color));
				panel_drawing.Refresh();
			}
		}
		private void panel_drawing_MouseClick(object sender, MouseEventArgs e)
		{
			switch (mode)
			{
				case 1:
					if(count_click == 0)
					{
						points.Add(new Point(e.X, e.Y));
						count_click = 1;
					}
					else
					{
						points.Add(new Point(e.X, e.Y));
						storage.Add(new Line(points[0], points[1], color));
						points.Clear();
						count_click = 0;
					}
					break;
				case 2:
					if (count_click == 0)
					{
						points.Add(new Point(e.X, e.Y));
						count_click = 1;
					}
					else
					{
						storage.Add(new Ellipse(points[0].X, points[0].Y, e.X - points[0].X, e.Y - points[0].Y, color));
						points.Clear();
						count_click = 0;
					}
					break;
				case 3:
					if(count_click == 3)
                    {
						points.Add(new Point(e.X, e.Y));
						storage.Add(new Bezier(points[0], points[1], points[2], points[3], color));
						points.Clear();
						count_click = 0;
					}
                    else
                    {
						points.Add(new Point(e.X, e.Y));
						count_click++;
                    }
					break;
				case 4:
					storage.Add(new Pie(e.X - 50, e.Y - 50, 100, 100, 0.0F, trackBar1.Value, color));
					break;
				case 5:
					storage.Add(new Diagram(e.X - 50, e.Y - 50, 100, 100, 0.0F, 360.0F, color));					
					break;
				case 6:
					storage.Add(new Polygon(color));
					break;
			}
			panel_drawing.Refresh();
		}
		private void Line_Button_Click(object sender, EventArgs e)
		{   // Выбор линий
			mode = 1;
			count_click = 0;
		}
		private void Ellips_Button_Click(object sender, EventArgs e)
        {   // Выбор эллипсов
			mode = 2;
			count_click = 0;
		}
        private void Beziers_Button_Click(object sender, EventArgs e)
        {	// Выбор кривой Безье
			mode = 3;
			count_click = 0;
        }
        private void SegmentEllipse_Button_Click(object sender, EventArgs e)
        {
			mode = 4;
			if (!trackBar1.Visible)
				trackBar1.Visible = true;
			else 
				trackBar1.Visible = false;

		}
        private void Diagram_Button_Click(object sender, EventArgs e)
        {
			mode = 5;
        }
        private void Polygon_Button_Click(object sender, EventArgs e)
        {
			mode = 6;
        }
    }
}
