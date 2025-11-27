using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bai03
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video/Sound File | *.avi; *.mpeg; *.wav; *.midi; *.mp4; *.mp3";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = Path.GetFileName(dialog.FileName);
                mediaPlayer.URL = dialog.FileName;
                mediaPlayer.Ctlcontrols.play();
            }
        }

        private void clockTick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt");
        }
    }
}
