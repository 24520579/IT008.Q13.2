using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
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

        private void btnCong_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtBoxNum1.Text);
            float num2 = float.Parse(txtBoxNum2.Text);
            float result = num1 + num2;
            txtBoxDapAn.Text = result.ToString();
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtBoxNum1.Text);
            float num2 = float.Parse(txtBoxNum2.Text);
            float result = num1 - num2;
            txtBoxDapAn.Text = result.ToString();
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtBoxNum1.Text);
            float num2 = float.Parse(txtBoxNum2.Text);
            float result = num1 * num2;
            txtBoxDapAn.Text = result.ToString();
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtBoxNum1.Text);
            float num2 = float.Parse(txtBoxNum2.Text);
            if (num2 != 0)
            {
                float result = num1 / num2;
                txtBoxDapAn.Text = result.ToString();
            }
            else txtBoxDapAn.Text = "So chia phai khac 0";
        }
    }
}
