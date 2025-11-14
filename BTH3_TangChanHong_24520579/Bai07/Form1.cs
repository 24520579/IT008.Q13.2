using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Bai07
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void chooseNumber(object sender, MouseEventArgs e)
        {
            Control senderControl = sender as Control;

            if (senderControl.BackColor == Color.Blue)
                senderControl.BackColor = Color.White;
            else if (senderControl.BackColor == Color.White)
                senderControl.BackColor = Color.Blue;
            else if (senderControl.BackColor == Color.Yellow)
                MessageBox.Show("Vé tại vị trí này đã được bán!");
        }

        long total = 0;
        private void chooseButton_Click(object sender, EventArgs e)
        {
            foreach (Control btn in groupBoxA.Controls)
            {
                if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.Yellow;
                    total += 5000;
                }
            }

            foreach (Control btn in groupBoxB.Controls)
            {
                if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.Yellow;
                    total += 6500;
                }
            }

            foreach (Control btn in groupBoxC.Controls)
            {
                if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.Yellow;
                    total += 8000;
                }
            }

            payment.Text = total.ToString() + " (VND)";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            total = 0;
            payment.Text = "0 (VND)";

            foreach (Control btn in groupBoxA.Controls)
                if (btn.BackColor == Color.Blue)
                    btn.BackColor = Color.White;

            foreach (Control btn in groupBoxB.Controls)
                if (btn.BackColor == Color.Blue)
                    btn.BackColor = Color.White;

            foreach (Control btn in groupBoxC.Controls)
                if (btn.BackColor == Color.Blue)
                    btn.BackColor = Color.White;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vé được đặt thành công, tổng số tiền phải trả là " + total + " (VND)");

            foreach (Control btn in groupBoxA.Controls)
                if (btn.BackColor == Color.Yellow || btn.BackColor == Color.Blue)
                    btn.BackColor = Color.White;

            foreach (Control btn in groupBoxB.Controls)
                if (btn.BackColor == Color.Yellow || btn.BackColor == Color.Blue)
                    btn.BackColor = Color.White;

            foreach (Control btn in groupBoxC.Controls)
                if (btn.BackColor == Color.Yellow || btn.BackColor == Color.Blue)
                    btn.BackColor = Color.White;

            total = 0;
            payment.Text = "0 (VND)";
        }
    }
}