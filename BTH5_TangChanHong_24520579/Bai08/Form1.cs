using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            int cx = width / 2;
            int cy = height / 2;
            int radius = Math.Min(cx, cy) - 20;

            g.TranslateTransform(cx, cy);

            Brush whiteBrush = Brushes.White;
            for (int i = 0; i < 12; i++)
            {
                GraphicsState state = g.Save();
                g.RotateTransform(i * 30);
                g.TranslateTransform(0, -radius);
                g.FillEllipse(whiteBrush, -5, -5, 10, 10);
                g.Restore(state);
            }

            DateTime now = DateTime.Now;
            float hour = now.Hour;
            float minute = now.Minute;
            float second = now.Second;

            GraphicsState hourState = g.Save();
            g.RotateTransform((hour % 12) * 30 + minute * 0.5f);
            Pen hourPen = new Pen(Color.White, 4);
            g.DrawLine(hourPen, 0, 0, 0, -radius * 0.5f);
            g.Restore(hourState);

            GraphicsState minuteState = g.Save();
            g.RotateTransform(minute * 6 + second * 0.1f);
            Pen minutePen = new Pen(Color.White, 2);
            g.DrawLine(minutePen, 0, 0, 0, -radius * 0.7f);
            g.Restore(minuteState);

            GraphicsState secondState = g.Save();
            g.RotateTransform(second * 6);
            Pen secondPen = new Pen(Color.White, 1);
            g.DrawLine(secondPen, 0, 0, 0, -radius * 0.9f);
            g.Restore(secondState);

            g.FillEllipse(Brushes.White, -3, -3, 6, 6);
        }
    }
}