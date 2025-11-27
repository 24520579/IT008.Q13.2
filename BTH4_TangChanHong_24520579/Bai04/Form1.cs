using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;

namespace Bai04
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadFonts();
            loadSizes();

            cmbFonts.SelectedItem = "Tahoma";
            cmbSizes.SelectedItem = "14";
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void loadFonts()
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach (FontFamily font in installedFontCollection.Families)
            {
                cmbFonts.Items.Add(font.Name);
            }
        }

        private void loadSizes()
        {
            string[] sizes = { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };
            cmbSizes.Items.AddRange(sizes);
        }

        private void TaoVanBanMoi()
        {
            richTextBox1.Clear();
            currentFilePath = "";
            cmbFonts.SelectedItem = "Tahoma";
            cmbSizes.SelectedItem = "14";
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void mnuMoi_Click(object sender, EventArgs e)
        {
            TaoVanBanMoi();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TaoVanBanMoi();
        }

        private void MoTapTin()
        {
            openFileDialog1.Filter = "Tập tin văn bản (*.txt; *.rtf)|*.txt;*.rtf|Tất cả (*.*)|*.*"; 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ext = Path.GetExtension(openFileDialog1.FileName).ToLower();
                    if (ext == ".txt")
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    currentFilePath = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mnuMo_Click(object sender, EventArgs e)
        {
            MoTapTin();
        }

        private void LuuVanBan()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Lưu văn bản thành công");
                }
            }
            else
            {
                richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công");
            }
        }

        private void mnuLuu_Click(object sender, EventArgs e)
        {
            LuuVanBan();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuDinhDang_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectionFont != null)
                {
                    string newFontName = cmbFonts.SelectedItem.ToString();
                    float currentSize = richTextBox1.SelectionFont.Size;
                    FontStyle currentStyle = richTextBox1.SelectionFont.Style;

                    richTextBox1.SelectionFont = new Font(newFontName, currentSize, currentStyle);
                }
            }
            catch { }
        }

        private void cmbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectionFont != null)
                {
                    float newSize = float.Parse(cmbSizes.SelectedItem.ToString());
                    string currentFontName = richTextBox1.SelectionFont.Name;
                    FontStyle currentStyle = richTextBox1.SelectionFont.Style;

                    richTextBox1.SelectionFont = new Font(currentFontName, newSize, currentStyle);
                }
            }
            catch { }
        }

        private void ApplyStyle(FontStyle style)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle;

                if (currentFont.Style.HasFlag(style))
                    newStyle = currentFont.Style & ~style;
                else
                    newStyle = currentFont.Style | style;

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            ApplyStyle(FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            ApplyStyle(FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            ApplyStyle(FontStyle.Underline);
        }
    }
}