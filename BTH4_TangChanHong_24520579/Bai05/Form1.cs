using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            Form2 addStudent = new Form2();
            this.Hide();
            addStudent.ShowDialog();
            if (addStudent.newStudent != null)
                dataGridView1.Rows.Add(count++.ToString(), addStudent.newStudent.ID, addStudent.newStudent.name, addStudent.newStudent.apartment, addStudent.newStudent.score.ToString());
            this.Show();
        }
        static int count = 1;

        private void seachBoxTextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value != null && dataGridView1.Rows[i].Cells[2].Value.ToString().ToLower().Contains(toolStripTextBox1.Text.ToLower()))
                    dataGridView1.Rows[i].Visible = true;
                else dataGridView1.Rows[i].Visible = false;
            }
        }

        private void itemMenuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemMenuAdd_Click(object sender, EventArgs e)
        {
            toolStripBtnAdd_Click(sender, e);
        }
    }
}
