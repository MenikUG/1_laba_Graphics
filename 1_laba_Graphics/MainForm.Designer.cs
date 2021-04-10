namespace _1_laba_Graphics
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_drawing = new System.Windows.Forms.Panel();
            this.trackBar_Y = new System.Windows.Forms.TrackBar();
            this.trackBar_X = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.flip_90r = new System.Windows.Forms.Button();
            this.flip_90l = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Line_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellips_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Beziers_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.SegmentEllipse_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Diagram_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Polygon_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.PolygonV2_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Gradient_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.GradientV2_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.TextureKist_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.SubShape_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipBezier_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Selectphoto_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Flip_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Scale_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Inver_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_select_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openPicture = new System.Windows.Forms.OpenFileDialog();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.GradientAlongThePath_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Interpolation_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Complement_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Exclude_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_drawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_drawing
            // 
            this.panel_drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_drawing.BackColor = System.Drawing.SystemColors.Info;
            this.panel_drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_drawing.Controls.Add(this.trackBar_Y);
            this.panel_drawing.Controls.Add(this.trackBar_X);
            this.panel_drawing.Controls.Add(this.trackBar2);
            this.panel_drawing.Controls.Add(this.flip_90r);
            this.panel_drawing.Controls.Add(this.flip_90l);
            this.panel_drawing.Controls.Add(this.pictureBox1);
            this.panel_drawing.Controls.Add(this.trackBar1);
            this.panel_drawing.Location = new System.Drawing.Point(12, 30);
            this.panel_drawing.Name = "panel_drawing";
            this.panel_drawing.Size = new System.Drawing.Size(989, 610);
            this.panel_drawing.TabIndex = 1;
            this.panel_drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_drawing_Paint);
            this.panel_drawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_drawing_MouseClick);
            this.panel_drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_drawing_MouseMove);
            // 
            // trackBar_Y
            // 
            this.trackBar_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar_Y.Location = new System.Drawing.Point(364, 549);
            this.trackBar_Y.Maximum = 100;
            this.trackBar_Y.Minimum = -100;
            this.trackBar_Y.Name = "trackBar_Y";
            this.trackBar_Y.Size = new System.Drawing.Size(214, 56);
            this.trackBar_Y.TabIndex = 9;
            this.trackBar_Y.Visible = false;
            this.trackBar_Y.Scroll += new System.EventHandler(this.trackBar_Y_Scroll);
            // 
            // trackBar_X
            // 
            this.trackBar_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar_X.Location = new System.Drawing.Point(124, 549);
            this.trackBar_X.Maximum = 200;
            this.trackBar_X.Minimum = -200;
            this.trackBar_X.Name = "trackBar_X";
            this.trackBar_X.Size = new System.Drawing.Size(214, 56);
            this.trackBar_X.TabIndex = 8;
            this.trackBar_X.Visible = false;
            this.trackBar_X.Scroll += new System.EventHandler(this.trackBar_X_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.Location = new System.Drawing.Point(928, 255);
            this.trackBar2.Maximum = 50;
            this.trackBar2.Minimum = 2;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(56, 175);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.Value = 10;
            this.trackBar2.Visible = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // flip_90r
            // 
            this.flip_90r.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flip_90r.Image = ((System.Drawing.Image)(resources.GetObject("flip_90r.Image")));
            this.flip_90r.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flip_90r.Location = new System.Drawing.Point(810, 570);
            this.flip_90r.Name = "flip_90r";
            this.flip_90r.Size = new System.Drawing.Size(178, 39);
            this.flip_90r.TabIndex = 6;
            this.flip_90r.Text = "Поворот на 90°";
            this.flip_90r.UseVisualStyleBackColor = true;
            this.flip_90r.Visible = false;
            this.flip_90r.Click += new System.EventHandler(this.flip_90r_Click);
            // 
            // flip_90l
            // 
            this.flip_90l.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flip_90l.Image = ((System.Drawing.Image)(resources.GetObject("flip_90l.Image")));
            this.flip_90l.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flip_90l.Location = new System.Drawing.Point(631, 570);
            this.flip_90l.Name = "flip_90l";
            this.flip_90l.Size = new System.Drawing.Size(169, 39);
            this.flip_90l.TabIndex = 5;
            this.flip_90l.Text = "Поворот на 90°";
            this.flip_90l.UseVisualStyleBackColor = true;
            this.flip_90l.Visible = false;
            this.flip_90l.Click += new System.EventHandler(this.flip_90l_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 601);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(928, 3);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Minimum = -360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 253);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Visible = false;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1013, 27);
            this.menu.TabIndex = 2;
            this.menu.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Line_Button,
            this.Ellips_Button,
            this.Beziers_Button,
            this.SegmentEllipse_Button,
            this.Diagram_Button,
            this.Polygon_Button,
            this.PolygonV2_Button,
            this.Gradient_Button,
            this.GradientV2_Button,
            this.TextureKist_Button,
            this.SubShape_Button,
            this.FlipBezier_Button,
            this.GradientAlongThePath_Button,
            this.Interpolation_Button,
            this.Complement_Button,
            this.Exclude_Button});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(76, 24);
            this.toolStripDropDownButton1.Text = "Фигуры";
            // 
            // Line_Button
            // 
            this.Line_Button.Name = "Line_Button";
            this.Line_Button.Size = new System.Drawing.Size(317, 26);
            this.Line_Button.Text = "Линия";
            this.Line_Button.Click += new System.EventHandler(this.Line_Button_Click);
            // 
            // Ellips_Button
            // 
            this.Ellips_Button.Name = "Ellips_Button";
            this.Ellips_Button.Size = new System.Drawing.Size(317, 26);
            this.Ellips_Button.Text = "Эллипс";
            this.Ellips_Button.Click += new System.EventHandler(this.Ellips_Button_Click);
            // 
            // Beziers_Button
            // 
            this.Beziers_Button.Name = "Beziers_Button";
            this.Beziers_Button.Size = new System.Drawing.Size(317, 26);
            this.Beziers_Button.Text = "Кривая Безье";
            this.Beziers_Button.Click += new System.EventHandler(this.Beziers_Button_Click);
            // 
            // SegmentEllipse_Button
            // 
            this.SegmentEllipse_Button.Name = "SegmentEllipse_Button";
            this.SegmentEllipse_Button.Size = new System.Drawing.Size(317, 26);
            this.SegmentEllipse_Button.Text = "Сегмент Эллипса";
            this.SegmentEllipse_Button.Click += new System.EventHandler(this.SegmentEllipse_Button_Click);
            // 
            // Diagram_Button
            // 
            this.Diagram_Button.Name = "Diagram_Button";
            this.Diagram_Button.Size = new System.Drawing.Size(317, 26);
            this.Diagram_Button.Text = "Диаграмма";
            this.Diagram_Button.Click += new System.EventHandler(this.Diagram_Button_Click);
            // 
            // Polygon_Button
            // 
            this.Polygon_Button.Name = "Polygon_Button";
            this.Polygon_Button.Size = new System.Drawing.Size(317, 26);
            this.Polygon_Button.Text = "Полигон";
            this.Polygon_Button.Click += new System.EventHandler(this.Polygon_Button_Click);
            // 
            // PolygonV2_Button
            // 
            this.PolygonV2_Button.Name = "PolygonV2_Button";
            this.PolygonV2_Button.Size = new System.Drawing.Size(317, 26);
            this.PolygonV2_Button.Text = "Заливка пути из двух полигонов";
            this.PolygonV2_Button.Click += new System.EventHandler(this.PolygonV2_Button_Click);
            // 
            // Gradient_Button
            // 
            this.Gradient_Button.Name = "Gradient_Button";
            this.Gradient_Button.Size = new System.Drawing.Size(317, 26);
            this.Gradient_Button.Text = "Градиент";
            this.Gradient_Button.Click += new System.EventHandler(this.Gradient_Button_Click);
            // 
            // GradientV2_Button
            // 
            this.GradientV2_Button.Name = "GradientV2_Button";
            this.GradientV2_Button.Size = new System.Drawing.Size(317, 26);
            this.GradientV2_Button.Text = "Градиент из массива точек";
            this.GradientV2_Button.Click += new System.EventHandler(this.GradientV2_Button_Click);
            // 
            // TextureKist_Button
            // 
            this.TextureKist_Button.Name = "TextureKist_Button";
            this.TextureKist_Button.Size = new System.Drawing.Size(317, 26);
            this.TextureKist_Button.Text = "Текстурная кисть";
            this.TextureKist_Button.Click += new System.EventHandler(this.TextureKist_Button_Click);
            // 
            // SubShape_Button
            // 
            this.SubShape_Button.Name = "SubShape_Button";
            this.SubShape_Button.Size = new System.Drawing.Size(317, 26);
            this.SubShape_Button.Text = "Вычитание фигур";
            this.SubShape_Button.Click += new System.EventHandler(this.SubShape_Button_Click);
            // 
            // FlipBezier_Button
            // 
            this.FlipBezier_Button.Name = "FlipBezier_Button";
            this.FlipBezier_Button.Size = new System.Drawing.Size(317, 26);
            this.FlipBezier_Button.Text = "Поворот кривой Безье";
            this.FlipBezier_Button.Click += new System.EventHandler(this.FlipBezier_Button_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Selectphoto_Button,
            this.Flip_btn,
            this.Scale_Button,
            this.Inver_Button});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(121, 24);
            this.toolStripDropDownButton2.Text = "Изображение";
            // 
            // Selectphoto_Button
            // 
            this.Selectphoto_Button.Name = "Selectphoto_Button";
            this.Selectphoto_Button.Size = new System.Drawing.Size(252, 26);
            this.Selectphoto_Button.Text = "Выбрать изображение";
            this.Selectphoto_Button.Click += new System.EventHandler(this.Selectphoto_Button_Click);
            // 
            // Flip_btn
            // 
            this.Flip_btn.Name = "Flip_btn";
            this.Flip_btn.Size = new System.Drawing.Size(252, 26);
            this.Flip_btn.Text = "Повороты";
            this.Flip_btn.Click += new System.EventHandler(this.Flip_btn_Click);
            // 
            // Scale_Button
            // 
            this.Scale_Button.Name = "Scale_Button";
            this.Scale_Button.Size = new System.Drawing.Size(252, 26);
            this.Scale_Button.Text = "Масштаб";
            this.Scale_Button.Click += new System.EventHandler(this.Scale_Button_Click);
            // 
            // Inver_Button
            // 
            this.Inver_Button.Name = "Inver_Button";
            this.Inver_Button.Size = new System.Drawing.Size(252, 26);
            this.Inver_Button.Text = "Инвертировать цвета";
            this.Inver_Button.Click += new System.EventHandler(this.Inver_Button_Click);
            // 
            // btn_select_color
            // 
            this.btn_select_color.BackColor = System.Drawing.Color.White;
            this.btn_select_color.Location = new System.Drawing.Point(568, 0);
            this.btn_select_color.Name = "btn_select_color";
            this.btn_select_color.Size = new System.Drawing.Size(118, 27);
            this.btn_select_color.TabIndex = 3;
            this.btn_select_color.Text = "Цвет";
            this.btn_select_color.UseVisualStyleBackColor = false;
            this.btn_select_color.Click += new System.EventHandler(this.btn_select_color_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // openPicture
            // 
            this.openPicture.FileName = "openPicture";
            this.openPicture.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(268, 0);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(83, 29);
            this.Clear_Button.TabIndex = 4;
            this.Clear_Button.Text = "Очистить";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // GradientAlongThePath_Button
            // 
            this.GradientAlongThePath_Button.Name = "GradientAlongThePath_Button";
            this.GradientAlongThePath_Button.Size = new System.Drawing.Size(317, 26);
            this.GradientAlongThePath_Button.Text = "Градиент вдоль пути";
            this.GradientAlongThePath_Button.Click += new System.EventHandler(this.GradientAlongThePath_Button_Click);
            // 
            // Interpolation_Button
            // 
            this.Interpolation_Button.Name = "Interpolation_Button";
            this.Interpolation_Button.Size = new System.Drawing.Size(317, 26);
            this.Interpolation_Button.Text = "Интерполяция цвета";
            this.Interpolation_Button.Click += new System.EventHandler(this.Interpolation_Button_Click);
            // 
            // Complement_Button
            // 
            this.Complement_Button.Name = "Complement_Button";
            this.Complement_Button.Size = new System.Drawing.Size(317, 26);
            this.Complement_Button.Text = "Комплемент";
            this.Complement_Button.Click += new System.EventHandler(this.Complement_Button_Click);
            // 
            // Exclude_Button
            // 
            this.Exclude_Button.Name = "Exclude_Button";
            this.Exclude_Button.Size = new System.Drawing.Size(317, 26);
            this.Exclude_Button.Text = "Исключение";
            this.Exclude_Button.Click += new System.EventHandler(this.Exclude_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 652);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.btn_select_color);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel_drawing);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №1";
            this.panel_drawing.ResumeLayout(false);
            this.panel_drawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_drawing;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem Line_Button;
        private System.Windows.Forms.ToolStripMenuItem Ellips_Button;
        private System.Windows.Forms.ToolStripMenuItem Beziers_Button;
        private System.Windows.Forms.ToolStripMenuItem SegmentEllipse_Button;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem Diagram_Button;
        private System.Windows.Forms.ToolStripMenuItem Polygon_Button;
        private System.Windows.Forms.ToolStripMenuItem PolygonV2_Button;
        private System.Windows.Forms.ToolStripMenuItem Gradient_Button;
        private System.Windows.Forms.Button btn_select_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem GradientV2_Button;
        private System.Windows.Forms.ToolStripMenuItem TextureKist_Button;
        private System.Windows.Forms.ToolStripMenuItem SubShape_Button;
        private System.Windows.Forms.OpenFileDialog openPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem Selectphoto_Button;
        private System.Windows.Forms.ToolStripMenuItem Flip_btn;
        private System.Windows.Forms.Button flip_90r;
        private System.Windows.Forms.Button flip_90l;
        private System.Windows.Forms.ToolStripMenuItem Scale_Button;
        private System.Windows.Forms.ToolStripMenuItem Inver_Button;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.ToolStripMenuItem FlipBezier_Button;
        private System.Windows.Forms.TrackBar trackBar_Y;
        private System.Windows.Forms.TrackBar trackBar_X;
        private System.Windows.Forms.ToolStripMenuItem GradientAlongThePath_Button;
        private System.Windows.Forms.ToolStripMenuItem Interpolation_Button;
        private System.Windows.Forms.ToolStripMenuItem Complement_Button;
        private System.Windows.Forms.ToolStripMenuItem Exclude_Button;
    }
}

