using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbBoxShape.SelectedIndex = 0;
        }

        private void cboShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            string selectedShape = cbBoxShape.SelectedItem.ToString();

            Pen myPen = new Pen(Color.Red, 3);
            Brush myBrush = Brushes.DarkRed;
            Rectangle rectRect = new Rectangle(100, 100, 150, 150);
            Rectangle rectEllipse = new Rectangle(100, 100, 200, 100);

            switch (selectedShape)
            {
                case "Circle":
                    g.DrawEllipse(myPen, rectRect);
                    break;
                case "Square":
                    g.DrawRectangle(myPen, rectRect);
                    break;
                case "Ellipse":
                    g.DrawEllipse(myPen, rectEllipse);
                    break;
                case "Pie":
                    g.DrawPie(myPen, rectRect, 0, 45);
                    break;

                case "Filled Circle":
                    g.FillEllipse(myBrush, rectRect);
                    break;
                case "Filled Square":
                    g.FillRectangle(myBrush, rectRect);
                    break;
                case "Filled Ellipse":
                    g.FillEllipse(myBrush, rectEllipse);
                    break;
                case "Filled Pie":
                    g.FillPie(myBrush, rectRect, 0, 45);
                    break;
            }
        }
    }
}
