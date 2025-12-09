using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        string fontName;
        int fontSize;
        FontStyle fstyle;
        string align;
        Color textColor;
        public Form1()
        {
            InitializeComponent();
            fontName = "Arial";
            fontSize = 24;
            fstyle= FontStyle.Regular;
            align = "Left";
            btnColor.BackColor = panelHello.ForeColor;
        }

        private void cbBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontName = cbBoxFont.SelectedItem.ToString();
            panelHello.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                cbBoxFont.Items.Add(font.Name);
            }
            for (int i=1;i<=100;i++)
            {
                cbBoxSize.Items.Add(i.ToString());
            }
            cbBoxFont.SelectedItem = "Arial";
            cbBoxSize.Text = "24";
            rbtnLeft.Checked = true;
        }

        private void cbBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontSize=cbBoxSize.SelectedIndex+1;
            panelHello.Refresh();
            if (cbBoxSize.ToString() == "" || cbBoxSize.Text.ToString() == "0")
                fontSize = 1;
            else fontSize = int.Parse(cbBoxSize.Text.ToString());
            panelHello.Refresh();
        }

        private void ckBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            fstyle ^= FontStyle.Bold;
            panelHello.Refresh();
        }

        private void ckBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
             fstyle ^= FontStyle.Italic;
            panelHello.Refresh();
        }
        private void ckBoxUnderline_CheckedChanged(object sender, EventArgs e)
        {
            fstyle ^= FontStyle.Underline;
            panelHello.Refresh();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
           if(clDialog.ShowDialog()== DialogResult.OK)
            {
                panelHello.ForeColor = clDialog.Color;
                panelHello.Refresh();
            }
           btnColor.BackColor = panelHello.ForeColor;
        }

        private void rbtnLeft_CheckedChanged(object sender, EventArgs e)
        {
            align = "Left";
            panelHello.Refresh();
        }

        private void rbtnCenter_CheckedChanged(object sender, EventArgs e)
        {
            align = "center";
            panelHello.Refresh();
        }

        private void rbtnRight_CheckedChanged(object sender, EventArgs e)
        {
            align = "right";
            panelHello.Refresh();
        }

        private void panelHello_Paint(object sender, PaintEventArgs e)
        {
            drawString(align, fontName, fontSize, fstyle, textColor);
        }
        private void drawString(string align, string fontName, int fontSize, FontStyle fstyle, Color textColor)
        {
            Graphics g = panelHello.CreateGraphics();
            g.Clear(panelHello.BackColor);
            Font font = new Font(fontName, fontSize, fstyle);
            Brush brush = new SolidBrush(panelHello.ForeColor);
            StringFormat strFormat = new StringFormat();
            if (align == "Left")
                strFormat.Alignment = StringAlignment.Near;
            else if (align == "center")
                strFormat.Alignment = StringAlignment.Center;
            else if (align == "right")
                strFormat.Alignment = StringAlignment.Far;
            Rectangle rect = new Rectangle(0, 0, panelHello.Width, panelHello.Height);
            g.DrawString("Hello", font, brush, rect, strFormat);
        }
    }
}
