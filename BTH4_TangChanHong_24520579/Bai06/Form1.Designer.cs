namespace Bai06
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSource = new System.Windows.Forms.Label();
            this.txtBoxSource = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.txtBoxDestination = new System.Windows.Forms.TextBox();
            this.lbDestination = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lbCopy = new System.Windows.Forms.ToolStripLabel();
            this.lbPath = new System.Windows.Forms.ToolStripLabel();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.copyProcess = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.btnDestination);
            this.groupBox1.Controls.Add(this.txtBoxDestination);
            this.groupBox1.Controls.Add(this.lbDestination);
            this.groupBox1.Controls.Add(this.btnSource);
            this.groupBox1.Controls.Add(this.txtBoxSource);
            this.groupBox1.Controls.Add(this.lbSource);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(34, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.ForeColor = System.Drawing.Color.Black;
            this.lbSource.Location = new System.Drawing.Point(39, 41);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(265, 25);
            this.lbSource.TabIndex = 0;
            this.lbSource.Text = "Đường dẫn thư mục nguồn";
            // 
            // txtBoxSource
            // 
            this.txtBoxSource.Location = new System.Drawing.Point(333, 35);
            this.txtBoxSource.Name = "txtBoxSource";
            this.txtBoxSource.Size = new System.Drawing.Size(322, 31);
            this.txtBoxSource.TabIndex = 1;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(673, 35);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(59, 31);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(673, 93);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(59, 31);
            this.btnDestination.TabIndex = 5;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // txtBoxDestination
            // 
            this.txtBoxDestination.Location = new System.Drawing.Point(333, 93);
            this.txtBoxDestination.Name = "txtBoxDestination";
            this.txtBoxDestination.Size = new System.Drawing.Size(322, 31);
            this.txtBoxDestination.TabIndex = 4;
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.ForeColor = System.Drawing.Color.Black;
            this.lbDestination.Location = new System.Drawing.Point(39, 99);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(245, 25);
            this.lbDestination.TabIndex = 3;
            this.lbDestination.Text = "Đường dẫn thư mục đích";
            // 
            // btnCopy
            // 
            this.btnCopy.ForeColor = System.Drawing.Color.Black;
            this.btnCopy.Location = new System.Drawing.Point(221, 145);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(221, 32);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Sao chép";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(34, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 39);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(725, 39);
            this.progressBar1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCopy,
            this.lbPath});
            this.toolStrip1.Location = new System.Drawing.Point(0, 412);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "Đang sao chép: ";
            // 
            // lbCopy
            // 
            this.lbCopy.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopy.Name = "lbCopy";
            this.lbCopy.Size = new System.Drawing.Size(163, 32);
            this.lbCopy.Text = "Đang sao chép: ";
            // 
            // lbPath
            // 
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(173, 32);
            this.lbPath.Text = "toolStripLabel2";
            // 
            // copyProcess
            // 
            this.copyProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.copyProcess_DoWork);
            this.copyProcess.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.copyProcess_ProgressChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox txtBoxDestination;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox txtBoxSource;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lbCopy;
        private System.Windows.Forms.ToolStripLabel lbPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.ComponentModel.BackgroundWorker copyProcess;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip tip;
    }
}

