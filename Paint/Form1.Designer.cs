namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.дToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.рToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BrushSize = new System.Windows.Forms.TrackBar();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.DrawRect = new System.Windows.Forms.ToolStripButton();
            this.DrawEllipse = new System.Windows.Forms.ToolStripButton();
            this.DrawTriangle = new System.Windows.Forms.ToolStripButton();
            this.DrawBucket = new System.Windows.Forms.ToolStripButton();
            this.DrawPencil = new System.Windows.Forms.ToolStripButton();
            this.DrawEraser = new System.Windows.Forms.ToolStripButton();
            this.DrawLine = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSize)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.иToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // иToolStripMenuItem
            // 
            this.иToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гToolStripMenuItem});
            this.иToolStripMenuItem.Name = "иToolStripMenuItem";
            this.иToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.иToolStripMenuItem.Text = " И";
            // 
            // гToolStripMenuItem
            // 
            this.гToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оToolStripMenuItem});
            this.гToolStripMenuItem.Name = "гToolStripMenuItem";
            this.гToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.гToolStripMenuItem.Text = "г";
            // 
            // оToolStripMenuItem
            // 
            this.оToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рToolStripMenuItem});
            this.оToolStripMenuItem.Name = "оToolStripMenuItem";
            this.оToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.оToolStripMenuItem.Text = "о";
            // 
            // рToolStripMenuItem
            // 
            this.рToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ьToolStripMenuItem});
            this.рToolStripMenuItem.Name = "рToolStripMenuItem";
            this.рToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.рToolStripMenuItem.Text = "р";
            // 
            // ьToolStripMenuItem
            // 
            this.ьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пToolStripMenuItem});
            this.ьToolStripMenuItem.Name = "ьToolStripMenuItem";
            this.ьToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.ьToolStripMenuItem.Text = "ь";
            // 
            // пToolStripMenuItem
            // 
            this.пToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.иToolStripMenuItem1});
            this.пToolStripMenuItem.Name = "пToolStripMenuItem";
            this.пToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.пToolStripMenuItem.Text = "П";
            // 
            // иToolStripMenuItem1
            // 
            this.иToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дToolStripMenuItem});
            this.иToolStripMenuItem1.Name = "иToolStripMenuItem1";
            this.иToolStripMenuItem1.Size = new System.Drawing.Size(81, 22);
            this.иToolStripMenuItem1.Text = "и";
            // 
            // дToolStripMenuItem
            // 
            this.дToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оToolStripMenuItem1,
            this.рToolStripMenuItem1});
            this.дToolStripMenuItem.Name = "дToolStripMenuItem";
            this.дToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.дToolStripMenuItem.Text = "д";
            // 
            // оToolStripMenuItem1
            // 
            this.оToolStripMenuItem1.Name = "оToolStripMenuItem1";
            this.оToolStripMenuItem1.Size = new System.Drawing.Size(81, 22);
            this.оToolStripMenuItem1.Text = "о";
            // 
            // рToolStripMenuItem1
            // 
            this.рToolStripMenuItem1.Name = "рToolStripMenuItem1";
            this.рToolStripMenuItem1.Size = new System.Drawing.Size(81, 22);
            this.рToolStripMenuItem1.Text = "р";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 454);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(270, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.color_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonColor.Location = new System.Drawing.Point(212, 29);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(30, 30);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(296, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 20);
            this.button5.TabIndex = 0;
            this.button5.Text = " ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.color_Click);
            // 
            // BrushSize
            // 
            this.BrushSize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BrushSize.Location = new System.Drawing.Point(569, 29);
            this.BrushSize.Maximum = 20;
            this.BrushSize.Minimum = 1;
            this.BrushSize.Name = "BrushSize";
            this.BrushSize.Size = new System.Drawing.Size(104, 45);
            this.BrushSize.TabIndex = 4;
            this.BrushSize.Value = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(322, 9);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(20, 20);
            this.button8.TabIndex = 0;
            this.button8.Text = " ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цвет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(575, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ширина кисти";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button11.Location = new System.Drawing.Point(348, 8);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(20, 20);
            this.button11.TabIndex = 0;
            this.button11.Text = " ";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.color_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(270, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.color_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button18.Location = new System.Drawing.Point(374, 8);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(20, 20);
            this.button18.TabIndex = 0;
            this.button18.Text = " ";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.color_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(296, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 20);
            this.button6.TabIndex = 6;
            this.button6.Text = " ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.color_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button22.Location = new System.Drawing.Point(400, 8);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(20, 20);
            this.button22.TabIndex = 0;
            this.button22.Text = " ";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.color_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Lime;
            this.button9.Location = new System.Drawing.Point(322, 29);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(20, 20);
            this.button9.TabIndex = 6;
            this.button9.Text = " ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.color_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Blue;
            this.button12.Location = new System.Drawing.Point(348, 28);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(20, 20);
            this.button12.TabIndex = 6;
            this.button12.Text = " ";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.color_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(270, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 7;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.color_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Yellow;
            this.button19.Location = new System.Drawing.Point(374, 28);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(20, 20);
            this.button19.TabIndex = 6;
            this.button19.Text = " ";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.color_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Maroon;
            this.button7.Location = new System.Drawing.Point(296, 49);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(20, 20);
            this.button7.TabIndex = 7;
            this.button7.Text = " ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.color_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Fuchsia;
            this.button23.Location = new System.Drawing.Point(400, 28);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(20, 20);
            this.button23.TabIndex = 6;
            this.button23.Text = " ";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.color_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Green;
            this.button10.Location = new System.Drawing.Point(322, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(20, 20);
            this.button10.TabIndex = 7;
            this.button10.Text = " ";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.color_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button13.Location = new System.Drawing.Point(348, 48);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(20, 20);
            this.button13.TabIndex = 7;
            this.button13.Text = " ";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.color_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button20.Location = new System.Drawing.Point(374, 48);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(20, 20);
            this.button20.TabIndex = 7;
            this.button20.Text = " ";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.color_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button24.Location = new System.Drawing.Point(400, 48);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(20, 20);
            this.button24.TabIndex = 7;
            this.button24.Text = " ";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.color_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawRect,
            this.DrawEllipse,
            this.DrawTriangle,
            this.DrawBucket,
            this.DrawPencil,
            this.DrawEraser,
            this.DrawLine});
            this.toolStrip2.Location = new System.Drawing.Point(9, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(173, 25);
            this.toolStrip2.TabIndex = 4;
            // 
            // DrawRect
            // 
            this.DrawRect.Checked = true;
            this.DrawRect.CheckOnClick = true;
            this.DrawRect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DrawRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawRect.Image = global::Paint.Properties.Resources.rect;
            this.DrawRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawRect.Name = "DrawRect";
            this.DrawRect.Size = new System.Drawing.Size(23, 22);
            this.DrawRect.Text = "Rectangle";
            this.DrawRect.Click += new System.EventHandler(this.DrawRectangle_Click);
            // 
            // DrawEllipse
            // 
            this.DrawEllipse.CheckOnClick = true;
            this.DrawEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawEllipse.Image = global::Paint.Properties.Resources.ellipse;
            this.DrawEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawEllipse.Name = "DrawEllipse";
            this.DrawEllipse.Size = new System.Drawing.Size(23, 22);
            this.DrawEllipse.Text = "Ellipse tool";
            this.DrawEllipse.Click += new System.EventHandler(this.DrawEllipse_Click);
            // 
            // DrawTriangle
            // 
            this.DrawTriangle.CheckOnClick = true;
            this.DrawTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawTriangle.Image = global::Paint.Properties.Resources.triangle;
            this.DrawTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawTriangle.Name = "DrawTriangle";
            this.DrawTriangle.Size = new System.Drawing.Size(23, 22);
            this.DrawTriangle.Text = "Triangle";
            this.DrawTriangle.Click += new System.EventHandler(this.DrawTriangle_Click);
            // 
            // DrawBucket
            // 
            this.DrawBucket.CheckOnClick = true;
            this.DrawBucket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawBucket.Image = global::Paint.Properties.Resources.bucket;
            this.DrawBucket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawBucket.Name = "DrawBucket";
            this.DrawBucket.Size = new System.Drawing.Size(23, 22);
            this.DrawBucket.Text = "Bucket";
            this.DrawBucket.Click += new System.EventHandler(this.DrawBucket_Click);
            // 
            // DrawPencil
            // 
            this.DrawPencil.CheckOnClick = true;
            this.DrawPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawPencil.Image = global::Paint.Properties.Resources.pencil;
            this.DrawPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawPencil.Name = "DrawPencil";
            this.DrawPencil.Size = new System.Drawing.Size(23, 22);
            this.DrawPencil.Text = "Pencil";
            this.DrawPencil.Click += new System.EventHandler(this.DrawPencil_Click);
            // 
            // DrawEraser
            // 
            this.DrawEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawEraser.Image = global::Paint.Properties.Resources.eraser;
            this.DrawEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawEraser.Name = "DrawEraser";
            this.DrawEraser.Size = new System.Drawing.Size(23, 22);
            this.DrawEraser.Text = "Eraser";
            this.DrawEraser.Click += new System.EventHandler(this.DrawEraser_Click);
            // 
            // DrawLine
            // 
            this.DrawLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawLine.Image = global::Paint.Properties.Resources.line;
            this.DrawLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawLine.Name = "DrawLine";
            this.DrawLine.Size = new System.Drawing.Size(23, 22);
            this.DrawLine.Text = "Line";
            this.DrawLine.Click += new System.EventHandler(this.DrawLine_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.BrushSize);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.buttonColor);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 83);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSize)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem иToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem дToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem рToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar BrushSize;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton DrawRect;
        private System.Windows.Forms.ToolStripButton DrawEllipse;
        private System.Windows.Forms.ToolStripButton DrawPencil;
        private System.Windows.Forms.ToolStripButton DrawTriangle;
        private System.Windows.Forms.ToolStripButton DrawBucket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton DrawEraser;
        private System.Windows.Forms.ToolStripButton DrawLine;
    }
}

