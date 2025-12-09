using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cboDashStyle.DataSource = Enum.GetNames(typeof(DashStyle));
            cboWidth.Items.AddRange(new string[] { "1", "5", "8", "10", "15", "20" });
            cboWidth.SelectedIndex = 2;
            cboLineJoin.DataSource = Enum.GetNames(typeof(LineJoin));
            cboDashCap.DataSource = Enum.GetNames(typeof(DashCap));
            cboStartCap.DataSource = Enum.GetNames(typeof(LineCap));
            cboEndCap.DataSource = Enum.GetNames(typeof(LineCap));
        }

        private void UpdateDrawing(object sender, EventArgs e)
        {
            picCanvas.Invalidate();
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            try
            {
                DashStyle ds = (DashStyle)Enum.Parse(typeof(DashStyle), cboDashStyle.SelectedItem.ToString());
                float width = float.Parse(cboWidth.SelectedItem.ToString());
                LineJoin lj = (LineJoin)Enum.Parse(typeof(LineJoin), cboLineJoin.SelectedItem.ToString());
                DashCap dc = (DashCap)Enum.Parse(typeof(DashCap), cboDashCap.SelectedItem.ToString());
                LineCap sc = (LineCap)Enum.Parse(typeof(LineCap), cboStartCap.SelectedItem.ToString());
                LineCap ec = (LineCap)Enum.Parse(typeof(LineCap), cboEndCap.SelectedItem.ToString());

                using (Pen p = new Pen(Color.Red, width))
                {
                    p.DashStyle = ds;
                    p.LineJoin = lj;
                    p.DashCap = dc;
                    p.StartCap = sc;
                    p.EndCap = ec;

                    Point[] points = {
                        new Point(50, 50),
                        new Point(150, 250),
                        new Point(250, 100)
                    };

                    g.DrawLines(p, points);
                }
            }
            catch { }
        }
    }
}