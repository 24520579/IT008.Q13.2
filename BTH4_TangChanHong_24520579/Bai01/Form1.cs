using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickShow(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Button.ToString() + "\nTọa độ chuột "+e.X+":"+e.Y);
        }

        private void keyShow(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Phím: " + e.KeyCode.ToString() + "\nMã ASCII: "+e.KeyValue);
        }
    }
}
