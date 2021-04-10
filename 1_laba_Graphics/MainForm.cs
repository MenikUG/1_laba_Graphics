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
		Bitmap bitmap1;
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
			if(mode == 2 && count_click == 1) // Для отображения кругов 
			{
				if (storage.Any())
					if (storage.Last() is Ellipse)
						storage.RemoveAt(storage.Count - 1);
				storage.Add(new Ellipse(points[0].X, points[0].Y, e.X - points[0].X, e.Y - points[0].Y, color));
				panel_drawing.Refresh();
			}
		}
		private void panel_drawing_MouseClick(object sender, MouseEventArgs e)
		{	// Добавляем фигуру в хранилище
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
				case 7:
					if (count_click == 7)
					{
						points.Add(new Point(e.X, e.Y));
						storage.Add(new PolygonV2(points, color));
						panel_drawing.Refresh();
						points.Clear();
						count_click = 0;
					}
					else
					{
						points.Add(new Point(e.X, e.Y));
						count_click++;
					}
					break;
				case 8:
					storage.Add(new Gradient(color));
					break;
				case 9:
					storage.Add(new GradientV2());
					break;
				case 10:
					storage.Add(new TextuteKist(e.X-30, e.Y-30));
					break;
				case 11:
					storage.Add(new SubShape(e.X - 50, e.Y - 50, color));
					break;
				case 13:
					storage.Add(new GradientAlongThePath());
					break;
				case 14:
					storage.Add(new Interpolation());
					break;
				case 15:
					storage.Add(new Complement());
					break;
				case 16:
					storage.Add(new Exclude());
					break;
			}
			panel_drawing.Refresh();
		}
		private void btn_select_color_Click(object sender, EventArgs e)
		{	// Кнопка выбора цвета
			if (colorDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			btn_select_color.BackColor = colorDialog1.Color;
			color = colorDialog1.Color;
		}
		private void Line_Button_Click(object sender, EventArgs e)
		{   // Выбор режима Линии
			mode = 1;
			count_click = 0;
		}
		private void Ellips_Button_Click(object sender, EventArgs e)
		{   // Выбор режима Эллипсов
			mode = 2;
			count_click = 0;
		}
		private void Beziers_Button_Click(object sender, EventArgs e)
		{	// Выбор режима кривая Безье
			mode = 3;
			count_click = 0;
		}
		private void SegmentEllipse_Button_Click(object sender, EventArgs e)
		{	// Выбор режима сегмента Эллипса
			mode = 4;
			if (!trackBar1.Visible)
				trackBar1.Visible = true;
			else 
				trackBar1.Visible = false;
		}
		private void Diagram_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Диаграммы
			mode = 5;
		}
		private void Polygon_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Полигон
			mode = 6;
		}
		private void PolygonV2_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Заливка пути из двух полигонов
			mode = 7;
			count_click = 0;
		}
		private void Gradient_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Градиент
			mode = 8;
		}
		private void GradientV2_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Градиент из массива точек
			mode = 9;
		}
		private void TextureKist_Button_Click(object sender, EventArgs e)
		{	// Выбор режима текстурная кисть
			mode = 10;
		}
		private void SubShape_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Вычитания фигур
			mode = 11;
		}
		private void Selectphoto_Button_Click(object sender, EventArgs e)
		{	// Выбираем путь к изображению
			if (openPicture.ShowDialog() == DialogResult.Cancel)
				return;
			pictureBox1.ImageLocation = openPicture.FileName;
			bitmap1 = (Bitmap)Bitmap.FromFile(openPicture.FileName);
			pictureBox1.Visible = true;
		}
		private void Flip_btn_Click(object sender, EventArgs e)
		{	// Выбор режима Поворот изображения
			if (!flip_90l.Visible)
			{
				flip_90l.Visible = true;
				flip_90r.Visible = true;
			}
			else
			{
				flip_90l.Visible = false;
				flip_90r.Visible = false;
			}
		}
		private void flip_90l_Click(object sender, EventArgs e)
		{   // Поворачивает выбранное изображение на 90° влево
			bitmap1.RotateFlip(RotateFlipType.Rotate90FlipXY);
			pictureBox1.Image = bitmap1;
			pictureBox1.Refresh();
		}
		private void flip_90r_Click(object sender, EventArgs e)
		{	// Поворачивает выбранное изображение на 90° вправо
			bitmap1.RotateFlip(RotateFlipType.Rotate90FlipNone);
			pictureBox1.Image = bitmap1;
			pictureBox1.Refresh();
		}
		private void Scale_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Масштабирования
			if(!trackBar2.Visible)
				trackBar2.Visible = true;
			else
				trackBar2.Visible = false;
		}
		private void trackBar2_Scroll(object sender, EventArgs e)
		{	// Масштабирование изображения
			int Width = Convert.ToInt32(bitmap1.Width / (trackBar2.Value * 0.1));
			int Height = Convert.ToInt32(bitmap1.Height / (trackBar2.Value * 0.1));
			Bitmap temp = new Bitmap(bitmap1, new Size(Width, Height));
			pictureBox1.Image = temp;
			pictureBox1.Refresh();
		}
		private void Inver_Button_Click(object sender, EventArgs e)
		{	// Инвертирование цветов изображения
			int x;
			int y;
			for (x = 0; x < bitmap1.Width; x++)
			{
				for (y = 0; y < bitmap1.Height; y++)
				{
					Color oldColor = bitmap1.GetPixel(x, y);
					Color newColor;
					newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
					bitmap1.SetPixel(x, y, newColor);
					pictureBox1.Image = bitmap1;
					pictureBox1.Refresh();
				}
			}
		}
		private void Clear_Button_Click(object sender, EventArgs e)
		{	// Кнопка очистки
			storage.Clear();
			panel_drawing.Refresh();
			pictureBox1.Visible = false;
			flip_90l.Visible = false;
			flip_90r.Visible = false;
			trackBar1.Visible = false;
			trackBar2.Visible = false;
			trackBar_X.Visible = false;
			trackBar_Y.Visible = false;
		}
		private void FlipBezier_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Поворот кривой Безье
			if (!trackBar_X.Visible)
			{
				trackBar_X.Visible = true;
				trackBar_Y.Visible = true;
			}
			else
			{
				trackBar_X.Visible = false;
				trackBar_Y.Visible = false;
			}
			mode = 12;
			points.Add(new Point(233, 271));
			points.Add(new Point(334, 152));
			points.Add(new Point(497, 371));
			points.Add(new Point(588, 252));
			storage.Add(new Bezier(points[0], points[1], points[2], points[3], color));
			points.Clear();
		}
		private void GradientAlongThePath_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Градиент вдоль пути
			mode = 13;
		}
		private void Interpolation_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Интерполяции
			mode = 14;
		}
		private void Complement_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Комлемент
			mode = 15;
		}
		private void Exclude_Button_Click(object sender, EventArgs e)
		{	// Выбор режима Исключения
			mode = 16;
		}

		int cX = 0;
		int cY = 0;
		int x1, x2, x3, x4;
		int y1, y2, y3, y4;
		private void trackBar_X_Scroll(object sender, EventArgs e)
		{	// Поворот по Оси X
			if (mode == 12)
			{
				if (storage.Any())
					if (storage.Last() is Bezier)
					{
						int k = trackBar_X.Value * 5;
						Bezier last = storage.Last() as Bezier;
						if (cX == 0)
						{
							x1 = last.pt1.X;
							x2 = last.pt2.X;
							x3 = last.pt3.X;
							x4 = last.pt4.X;
							cX = 1;
							cY = 0;
						}					
						points.Add(new Point(x1 - k, last.pt1.Y));
						points.Add(new Point(x2 + k, last.pt2.Y));
						points.Add(new Point(x3 - k, last.pt3.Y));
						points.Add(new Point(x4 + k, last.pt4.Y));
						storage.RemoveAt(storage.Count - 1);
						storage.Add(new Bezier(points[0], points[1], points[2], points[3], color));
					}
				panel_drawing.Refresh();
				points.Clear();
			}
		}
		private void trackBar_Y_Scroll(object sender, EventArgs e)
		{	// Поворот по Оси Y
			if (mode == 12)
			{
				if (storage.Any())
					if (storage.Last() is Bezier)
					{
						int k = trackBar_Y.Value *  10;
						Bezier last = storage.Last() as Bezier;
						if (cY == 0)
						{
							y1 = last.pt1.Y;
							y2 = last.pt2.Y;
							y3 = last.pt3.Y;
							y4 = last.pt4.Y;
							cY = 1;
							cX = 0;
						}
						points.Add(new Point(last.pt1.X, y1));
						points.Add(new Point(last.pt2.X, y2 + k));
						points.Add(new Point(last.pt3.X, y3 - k));
						points.Add(new Point(last.pt4.X, y4));
						storage.RemoveAt(storage.Count - 1);
						storage.Add(new Bezier(points[0], points[1], points[2], points[3], color));
					}
				panel_drawing.Refresh();
				points.Clear();
			}
		}
	}
}
