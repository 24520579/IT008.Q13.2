using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnReDraw_Click(object sender, EventArgs e)
        {
            pnDraw.Refresh();
            Random rand = new Random();
            Graphics redraw=pnDraw.CreateGraphics();
            int x = rand.Next(0,300);
            int y = rand.Next(10, 150);
            var font = new Font(new FontFamily("Arial"), 15, FontStyle.Bold, GraphicsUnit.Pixel);
            var solidBrush = new SolidBrush(Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255)));
            redraw.DrawString("Paint Event", font, solidBrush, new PointF(x, y));
        }

        
    }
}
