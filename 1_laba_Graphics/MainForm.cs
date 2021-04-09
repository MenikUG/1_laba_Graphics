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
		private void Line_Button_Click(object sender, EventArgs e)
		{	// Выбор отрисовки линий
			panel_drawing.Refresh();
			if (Line_Button.Checked)
				mode = 1;
			else
				mode = 0;
			count_click = 0;
		}
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
						panel_drawing.Refresh();
						points.Clear();
						count_click = 0;
					}
					break;
			}
		   
		}

	}
}
