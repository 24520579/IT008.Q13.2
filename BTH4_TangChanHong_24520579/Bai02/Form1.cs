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
            timerClock.Start();
        }

        private void clockTick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt");
            lbClock.Left = (this.ClientSize.Width - lbClock.Size.Width) / 2;
        }
    }
}
