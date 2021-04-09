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
            this.menu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Line_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellips_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Beziers_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.SegmentEllipse_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Diagram_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Polygon_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_drawing.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_drawing
            // 
            this.panel_drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_drawing.BackColor = System.Drawing.SystemColors.Info;
            this.panel_drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_drawing.Controls.Add(this.trackBar1);
            this.panel_drawing.Location = new System.Drawing.Point(12, 30);
            this.panel_drawing.Name = "panel_drawing";
            this.panel_drawing.Size = new System.Drawing.Size(989, 610);
            this.panel_drawing.TabIndex = 1;
            this.panel_drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_drawing_Paint);
            this.panel_drawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_drawing_MouseClick);
            this.panel_drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_drawing_MouseMove);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
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
            this.Polygon_Button});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(76, 24);
            this.toolStripDropDownButton1.Text = "Фигуры";
            // 
            // Line_Button
            // 
            this.Line_Button.CheckOnClick = true;
            this.Line_Button.Name = "Line_Button";
            this.Line_Button.Size = new System.Drawing.Size(224, 26);
            this.Line_Button.Text = "Линия";
            this.Line_Button.Click += new System.EventHandler(this.Line_Button_Click);
            // 
            // Ellips_Button
            // 
            this.Ellips_Button.CheckOnClick = true;
            this.Ellips_Button.Name = "Ellips_Button";
            this.Ellips_Button.Size = new System.Drawing.Size(224, 26);
            this.Ellips_Button.Text = "Эллипс";
            this.Ellips_Button.Click += new System.EventHandler(this.Ellips_Button_Click);
            // 
            // Beziers_Button
            // 
            this.Beziers_Button.Name = "Beziers_Button";
            this.Beziers_Button.Size = new System.Drawing.Size(224, 26);
            this.Beziers_Button.Text = "Кривая Безье";
            this.Beziers_Button.Click += new System.EventHandler(this.Beziers_Button_Click);
            // 
            // SegmentEllipse_Button
            // 
            this.SegmentEllipse_Button.Name = "SegmentEllipse_Button";
            this.SegmentEllipse_Button.Size = new System.Drawing.Size(224, 26);
            this.SegmentEllipse_Button.Text = "Сегмент Эллипса";
            this.SegmentEllipse_Button.Click += new System.EventHandler(this.SegmentEllipse_Button_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(928, 3);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 253);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Visible = false;
            // 
            // Diagram_Button
            // 
            this.Diagram_Button.Name = "Diagram_Button";
            this.Diagram_Button.Size = new System.Drawing.Size(224, 26);
            this.Diagram_Button.Text = "Диаграмма";
            this.Diagram_Button.Click += new System.EventHandler(this.Diagram_Button_Click);
            // 
            // Polygon_Button
            // 
            this.Polygon_Button.Name = "Polygon_Button";
            this.Polygon_Button.Size = new System.Drawing.Size(224, 26);
            this.Polygon_Button.Text = "Полигон";
            this.Polygon_Button.Click += new System.EventHandler(this.Polygon_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 652);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel_drawing);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №1";
            this.panel_drawing.ResumeLayout(false);
            this.panel_drawing.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
    }
}

