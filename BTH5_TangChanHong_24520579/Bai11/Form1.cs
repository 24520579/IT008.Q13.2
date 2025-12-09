using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        Point startPoint;
        Point endPoint;
        bool isDrawing = false;
        Bitmap drawingBitmap;
        Color currentPenColor = Color.Black;

        public Form1()
        {
            InitializeComponent();

            drawingBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(drawingBitmap))
            {
                g.Clear(Color.White);
            }

            btnColor.Click += BtnColor_Click;
            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseMove += PicCanvas_MouseMove;
            picCanvas.MouseUp += PicCanvas_MouseUp;
            picCanvas.Paint += PicCanvas_Paint;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                currentPenColor = cd.Color;
            }
        }

        private void PicCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void PicCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                picCanvas.Invalidate();
            }
        }

        private void PicCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                endPoint = e.Location;
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    DrawShape(g);
                }
                picCanvas.Invalidate();
            }
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingBitmap, Point.Empty);
            if (isDrawing)
            {
                DrawShape(e.Graphics);
            }
        }

        private void DrawShape(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float penWidth = 1;
            float.TryParse(txtWidth.Text, out penWidth);

            using (Pen pen = new Pen(currentPenColor, penWidth))
            {
                int x = Math.Min(startPoint.X, endPoint.X);
                int y = Math.Min(startPoint.Y, endPoint.Y);
                int w = Math.Abs(startPoint.X - endPoint.X);
                int h = Math.Abs(startPoint.Y - endPoint.Y);
                Rectangle rect = new Rectangle(x, y, w, h);

                if (radLine.Checked)
                {
                    g.DrawLine(pen, startPoint, endPoint);
                }
                else
                {
                    using (Brush brush = GetBrush(rect))
                    {
                        if (radRect.Checked)
                        {
                            g.FillRectangle(brush, rect);
                        }
                        else if (radEllipse.Checked)
                        {
                            g.FillEllipse(brush, rect);
                        }
                    }
                }
            }
        }

        private Brush GetBrush(Rectangle rect)
        {
            if (rect.Width <= 0) rect.Width = 1;
            if (rect.Height <= 0) rect.Height = 1;

            if (radSolid.Checked)
            {
                return new SolidBrush(Color.Green);
            }
            else if (radHatch.Checked)
            {
                return new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
            }
            else if (radTexture.Checked)
            {
                Bitmap bmp = new Bitmap(10, 10);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                    g.DrawRectangle(Pens.Black, 0, 0, 10, 10);
                }
                return new TextureBrush(bmp);
            }
            else if (radGradient.Checked)
            {
                return new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
            }
            return new SolidBrush(Color.Black);
        }
    }
}