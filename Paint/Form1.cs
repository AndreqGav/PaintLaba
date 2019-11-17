using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        private Bitmap canvas;
        private Bitmap blockCanvas;

        private Mode mode;
        private Brush mainBrush = new SolidBrush(Color.Black);

        private int X, Y;
        private int endX, endY;
        private int endClickX, endClickY;

        private Color color;
        private bool isDraw;
        private float ScaleFactor = 1f;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            mode = Mode.None;
            canvas = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            blockCanvas = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            endX = endY = 0;

            color = Color.Black;
            buttonColor.BackColor = color;
        }

        private void color_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            color = button.BackColor;
            buttonColor.BackColor = color;
            buttonColor.Update();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveDialig = new SaveFileDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                canvas.Save(saveFileDialog1.FileName);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var picture = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                canvas = new Bitmap(picture, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = canvas;
            }
        }

        #region ToolStripButton

        private void DrawPencil_Click(object sender, EventArgs e)
        {
            mode = Mode.Pencil;
        }

        private void DrawRectangle_Click(object sender, EventArgs e)
        {
            mode = Mode.Rectangle;
        }

        private void DrawEllipse_Click(object sender, EventArgs e)
        {
            mode = Mode.Ellipse;
        }

        private void DrawBucket_Click(object sender, EventArgs e)
        {
            mode = Mode.Bucket;
        }

        private void DrawTriangle_Click(object sender, EventArgs e)
        {
            mode = Mode.Triangle;
        }

        private void DrawEraser_Click(object sender, EventArgs e)
        {
            mode = Mode.Eraser;
        }

        private void DrawLine_Click(object sender, EventArgs e)
        {
            mode = Mode.Line;
        }

        #endregion ToolStripButton

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen pen = GetPen();

            Graphics mainGraphics = Graphics.FromImage(canvas);

            switch (mode)
            {
                case Mode.Line:
                    {
                        mainGraphics.DrawLine(pen, endClickX, endClickY, X, Y);
                        break;
                    }
                case Mode.Rectangle:
                    {
                        int x, y;
                        x = endClickX;
                        y = endClickY;

                        if (x > X)
                        {
                            x = X;
                        }

                        if (y > Y)
                        {
                            y = Y;
                        }

                        mainGraphics.DrawRectangle(pen, x, y, Math.Abs(X - endClickX), Math.Abs(Y - endClickY));
                        break;
                    }
                case Mode.Ellipse:
                    {
                        mainGraphics.DrawEllipse(pen, endClickX, endClickY, e.X - endClickX, e.Y - endClickY);
                        break;
                    }
                case Mode.Triangle:
                    {
                        Point a = new Point((e.X + endClickX) / 2, endClickY);
                        Point b = new Point(endClickX, e.Y);
                        Point c = new Point(e.X, e.Y);

                        mainGraphics.DrawPolygon(pen, new Point[] { a, b, c });
                        break;
                    }
                case Mode.Bucket:
                    {
                        FloodFill(new Point(e.X, e.Y), canvas.GetPixel(e.X, e.Y), color, BrushSize.Value);
                        break;
                    }
            }
            isDraw = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDraw = true;

            endClickX = e.X;
            endClickY = e.Y;
            X = e.X;
            Y = e.Y;
            endX = e.X;
            endY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Invalidate();
            X = e.X;
            Y = e.Y;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = GetPen();

            Graphics mainGraphics = Graphics.FromImage(canvas);

            Graphics blockGraphics = Graphics.FromImage(blockCanvas);

            if (!isDraw) // Рисовать курсор
            {
                blockGraphics.Clear(Color.White);
                switch (mode)
                {
                    case Mode.Pencil:
                    case Mode.Eraser:
                        {
                            blockGraphics.DrawEllipse(new Pen(new SolidBrush(Color.Black)), new Rectangle(X - (int)(Convert.ToInt32(Convert.ToDouble(BrushSize.Value) * ScaleFactor) / 2), Y - (int)(Convert.ToInt32(Convert.ToDouble(BrushSize.Value) * ScaleFactor) / 2), (int)Convert.ToInt32(Convert.ToDouble(BrushSize.Value) * ScaleFactor), (int)Convert.ToInt32(Convert.ToDouble(BrushSize.Value) * ScaleFactor)));
                            break;
                        }

                    case Mode.Rectangle:
                    case Mode.Ellipse:
                    case Mode.Triangle:
                    case Mode.Line:
                    case Mode.Bucket:
                        {
                            blockGraphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(X - 4, Y), new Point(X + 4, Y));
                            blockGraphics.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(X, Y - 4), new Point(X, Y + 4));
                            break;
                        }
                }
                if (mode != Mode.None)
                {
                    blockGraphics.DrawImage(canvas, 0, 0);
                    pictureBox1.Image = blockCanvas;
                }
            }
            else // Рисвать сами объекты
            {
                switch (mode)
                {
                    case Mode.Pencil:
                        {
                            mainGraphics.DrawLine(pen, endX, endY, X, Y);
                            pictureBox1.Image = canvas;

                            break;
                        }
                    case Mode.Line:
                        {
                            blockGraphics.Clear(Color.White);
                            blockGraphics.DrawImage(canvas, 0, 0);

                            blockGraphics.DrawLine(pen, endClickX, endClickY, X, Y);
                            pictureBox1.Image = blockCanvas;
                            break;
                        }
                    case Mode.Eraser:
                        {
                            mainGraphics.DrawLine(GetPen(Color.White), endX, endY, X, Y);
                            pictureBox1.Image = canvas;

                            break;
                        }
                    case Mode.Rectangle:
                        {
                            blockGraphics.Clear(Color.White);
                            blockGraphics.DrawImage(canvas, 0, 0);

                            int x, y;
                            x = endClickX;
                            y = endClickY;

                            if (x > X)
                            {
                                x = X;
                            }

                            if (y > Y)
                            {
                                y = Y;
                            }

                            blockGraphics.DrawRectangle(pen, x, y, Math.Abs(X - endClickX), Math.Abs(Y - endClickY));
                            pictureBox1.Image = blockCanvas;

                            break;
                        }
                    case Mode.Ellipse:
                        {
                            blockGraphics.Clear(Color.White);
                            blockGraphics.DrawImage(canvas, 0, 0);

                            blockGraphics.DrawEllipse(pen, endClickX, endClickY, X - endClickX, Y - endClickY);
                            pictureBox1.Image = blockCanvas;

                            break;
                        }
                    case Mode.Triangle:
                        {
                            blockGraphics.Clear(Color.White);
                            blockGraphics.DrawImage(canvas, 0, 0);

                            Point a = new Point((X + endClickX) / 2, endClickY);
                            Point b = new Point(endClickX, Y);
                            Point c = new Point(X, Y);

                            blockGraphics.DrawPolygon(pen, new Point[] { a, b, c });
                            pictureBox1.Image = blockCanvas;

                            break;
                        }
                }
            }

            endX = X;
            endY = Y;
        }

        private Pen GetPen(Color? _color = null)
        {
            Pen pen = new Pen(mainBrush, BrushSize.Value);
            pen.Color = _color ?? color;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            return pen;
        }

        private bool MatchColor(Color a, Color b, int tolerance)
        {
            bool isAlike = false;
            if (b.A >= (a.A - tolerance) && b.A <= (a.A + tolerance))
            {
                if (b.R >= (a.R - tolerance) && b.R <= (a.R + tolerance))
                {
                    if (b.G >= (a.G - tolerance) && b.G <= (a.G + tolerance))
                    {
                        if (b.B >= (a.B - tolerance) && b.B <= (a.B + tolerance))
                        {
                            isAlike = true;
                        }
                    }
                }
            }
            return isAlike;
        }

        // Заливка
        private void FloodFill(Point p1, Color color1, Color color2, int tolerace)
        {
            Queue<Point> q = new Queue<Point>();
            q.Enqueue(p1);

            while (q.Count > 0)
            {
                Point p2 = q.Dequeue();

                if (!MatchColor(this.canvas.GetPixel(p2.X, p2.Y), color1, tolerace))
                {
                    continue;
                }

                if (MatchColor(this.canvas.GetPixel(p2.X, p2.Y), color2, 0))
                {
                    continue;
                }

                Point p3 = p2, p4 = new Point(p2.X + 1, p2.Y);

                while ((p3.X > 0) && MatchColor(canvas.GetPixel(p3.X, p3.Y), color1, tolerace))
                {
                    canvas.SetPixel(p3.X, p3.Y, color2);

                    if ((p3.Y > 0) && MatchColor(canvas.GetPixel(p3.X, p3.Y - 1), color1, tolerace))
                    {
                        q.Enqueue(new Point(p3.X, p3.Y - 1));
                    }

                    if ((p3.Y < canvas.Height - 1) && MatchColor(canvas.GetPixel(p3.X, p3.Y + 1), color1, tolerace))
                    {
                        q.Enqueue(new Point(p3.X, p3.Y + 1));
                    }

                    p3.X--;
                }

                while ((p4.X < canvas.Width - 1) && MatchColor(canvas.GetPixel(p4.X, p4.Y), color1, tolerace))
                {
                    canvas.SetPixel(p4.X, p4.Y, color2);

                    if ((p4.Y > 0) && MatchColor(canvas.GetPixel(p4.X, p4.Y - 1), color1, tolerace))
                    {
                        q.Enqueue(new Point(p4.X, p4.Y - 1));
                    }

                    if ((p4.Y < canvas.Height - 1) && MatchColor(canvas.GetPixel(p4.X, p4.Y + 1), color1, tolerace))
                    {
                        q.Enqueue(new Point(p4.X, p4.Y + 1));
                    }

                    p4.X++;
                }
            }

            pictureBox1.Image = canvas;
        }

    }
}
