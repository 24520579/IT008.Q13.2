using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var solidBrush = new SolidBrush(Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255)));
            this.BackColor = solidBrush.Color;
        }
    }
}
