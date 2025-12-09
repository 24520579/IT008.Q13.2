using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loading();
            fontTextBox.SelectionStart = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void loading()
        {
            for (int i = 0; i < FontFamily.Families.Length; i++)
            {
                fontTextBox.SelectionFont = new Font(FontFamily.Families[i].Name, 12, FontStyle.Regular);
                fontTextBox.SelectedText = "  " + FontFamily.Families[i].Name + "\r\n";
            }
        }
    }
}
