using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            copyProcess.WorkerSupportsCancellation = true;
            copyProcess.WorkerReportsProgress = true;
            copyProcess.RunWorkerCompleted += CopyProcess_RunWorkerCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbPath.Visible = false;
            lbCopy.Visible = false;
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lbPath.Visible = true;
                lbPath.Text = ofd.FileName;
                txtBoxSource.Text = ofd.FileName;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtBoxDestination.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtBoxSource.Text == "" || txtBoxDestination.Text == "")
            {
                MessageBox.Show("Thiếu thông tin đường dẫn");
                return;
            }
            else
            {
                if (!copyProcess.IsBusy)
                {
                    lbPath.Text = "Đang sao chép: " + txtBoxSource.Text;
                    tip.SetToolTip(progressBar1, "Đang sao chép: " + txtBoxSource.Text);

                    string[] args = { txtBoxSource.Text, txtBoxDestination.Text };
                    copyProcess.RunWorkerAsync(args);
                }
            }
        }

        private void copyProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string[] args = e.Argument as string[];
            string sourceFile = args[0];
            string destFolder = args[1];
            string fileName = Path.GetFileName(sourceFile);
            string destPath = Path.Combine(destFolder, fileName);

            for (int i = 0; i <= 90; i++)
            {
                Thread.Sleep(20);
                worker.ReportProgress(i);
            }

            try
            {
                File.Copy(sourceFile, destPath, true);
                worker.ReportProgress(100);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void copyProcess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void CopyProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Lỗi: " + e.Error.Message);
            }
            else
            {
                lbCopy.Visible = true;
                MessageBox.Show("Sao chép thành công!");
                ResetForm();
            }
        }

        private void ResetForm()
        {
            txtBoxSource.Clear();
            txtBoxDestination.Clear();
            lbPath.Text = "";
            lbPath.Visible = false;
            lbCopy.Visible = false;
            progressBar1.Value = 0;
            tip.SetToolTip(progressBar1, "Sẵn sàng");
        }
        private void timer_Tick(object sender, EventArgs e) { }
    }
}