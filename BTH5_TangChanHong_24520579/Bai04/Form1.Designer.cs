namespace Bai04
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
            this.lbFont = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbBoxFont = new System.Windows.Forms.ComboBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.cbBoxSize = new System.Windows.Forms.ComboBox();
            this.ckBoxBold = new System.Windows.Forms.CheckBox();
            this.ckBoxItalic = new System.Windows.Forms.CheckBox();
            this.ckBoxUnderline = new System.Windows.Forms.CheckBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.grBoxAllign = new System.Windows.Forms.GroupBox();
            this.rbtnRight = new System.Windows.Forms.RadioButton();
            this.rbtnCenter = new System.Windows.Forms.RadioButton();
            this.rbtnLeft = new System.Windows.Forms.RadioButton();
            this.panelHello = new System.Windows.Forms.FlowLayoutPanel();
            this.clDialog = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.grBoxAllign.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFont
            // 
            this.lbFont.AutoSize = true;
            this.lbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFont.Location = new System.Drawing.Point(3, 0);
            this.lbFont.Name = "lbFont";
            this.lbFont.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbFont.Size = new System.Drawing.Size(113, 33);
            this.lbFont.TabIndex = 0;
            this.lbFont.Text = "Font";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbFont);
            this.flowLayoutPanel1.Controls.Add(this.cbBoxFont);
            this.flowLayoutPanel1.Controls.Add(this.lbSize);
            this.flowLayoutPanel1.Controls.Add(this.cbBoxSize);
            this.flowLayoutPanel1.Controls.Add(this.ckBoxBold);
            this.flowLayoutPanel1.Controls.Add(this.ckBoxItalic);
            this.flowLayoutPanel1.Controls.Add(this.ckBoxUnderline);
            this.flowLayoutPanel1.Controls.Add(this.lbColor);
            this.flowLayoutPanel1.Controls.Add(this.btnColor);
            this.flowLayoutPanel1.Controls.Add(this.grBoxAllign);
            this.flowLayoutPanel1.Controls.Add(this.panelHello);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(592, 309);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cbBoxFont
            // 
            this.cbBoxFont.FormattingEnabled = true;
            this.cbBoxFont.Location = new System.Drawing.Point(122, 3);
            this.cbBoxFont.Name = "cbBoxFont";
            this.cbBoxFont.Size = new System.Drawing.Size(198, 33);
            this.cbBoxFont.TabIndex = 1;
            this.cbBoxFont.SelectedIndexChanged += new System.EventHandler(this.cbBoxFont_SelectedIndexChanged);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(326, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.lbSize.Size = new System.Drawing.Size(107, 33);
            this.lbSize.TabIndex = 2;
            this.lbSize.Text = "Size";
            // 
            // cbBoxSize
            // 
            this.cbBoxSize.FormattingEnabled = true;
            this.cbBoxSize.Location = new System.Drawing.Point(439, 3);
            this.cbBoxSize.Name = "cbBoxSize";
            this.cbBoxSize.Size = new System.Drawing.Size(149, 33);
            this.cbBoxSize.TabIndex = 3;
            this.cbBoxSize.SelectedIndexChanged += new System.EventHandler(this.cbBoxSize_SelectedIndexChanged);
            // 
            // ckBoxBold
            // 
            this.ckBoxBold.AutoSize = true;
            this.ckBoxBold.Font = new System.Drawing.Font("Impact", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxBold.Location = new System.Drawing.Point(3, 42);
            this.ckBoxBold.Name = "ckBoxBold";
            this.ckBoxBold.Padding = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.ckBoxBold.Size = new System.Drawing.Size(83, 58);
            this.ckBoxBold.TabIndex = 4;
            this.ckBoxBold.Text = "B";
            this.ckBoxBold.UseVisualStyleBackColor = true;
            this.ckBoxBold.CheckedChanged += new System.EventHandler(this.ckBoxBold_CheckedChanged);
            // 
            // ckBoxItalic
            // 
            this.ckBoxItalic.AutoSize = true;
            this.ckBoxItalic.Font = new System.Drawing.Font("Century Gothic", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxItalic.Location = new System.Drawing.Point(92, 42);
            this.ckBoxItalic.Name = "ckBoxItalic";
            this.ckBoxItalic.Size = new System.Drawing.Size(55, 37);
            this.ckBoxItalic.TabIndex = 5;
            this.ckBoxItalic.Text = "I";
            this.ckBoxItalic.UseVisualStyleBackColor = true;
            this.ckBoxItalic.CheckedChanged += new System.EventHandler(this.ckBoxItalic_CheckedChanged);
            // 
            // ckBoxUnderline
            // 
            this.ckBoxUnderline.AutoSize = true;
            this.ckBoxUnderline.Font = new System.Drawing.Font("Century Gothic", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxUnderline.Location = new System.Drawing.Point(153, 42);
            this.ckBoxUnderline.Name = "ckBoxUnderline";
            this.ckBoxUnderline.Size = new System.Drawing.Size(64, 36);
            this.ckBoxUnderline.TabIndex = 6;
            this.ckBoxUnderline.Text = "U";
            this.ckBoxUnderline.UseVisualStyleBackColor = true;
            this.ckBoxUnderline.CheckedChanged += new System.EventHandler(this.ckBoxUnderline_CheckedChanged);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(223, 39);
            this.lbColor.Name = "lbColor";
            this.lbColor.Padding = new System.Windows.Forms.Padding(120, 0, 0, 0);
            this.lbColor.Size = new System.Drawing.Size(205, 33);
            this.lbColor.TabIndex = 7;
            this.lbColor.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(434, 42);
            this.btnColor.Name = "btnColor";
            this.btnColor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.btnColor.Size = new System.Drawing.Size(54, 36);
            this.btnColor.TabIndex = 8;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // grBoxAllign
            // 
            this.grBoxAllign.Controls.Add(this.rbtnRight);
            this.grBoxAllign.Controls.Add(this.rbtnCenter);
            this.grBoxAllign.Controls.Add(this.rbtnLeft);
            this.grBoxAllign.Location = new System.Drawing.Point(3, 106);
            this.grBoxAllign.Name = "grBoxAllign";
            this.grBoxAllign.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.grBoxAllign.Size = new System.Drawing.Size(214, 189);
            this.grBoxAllign.TabIndex = 9;
            this.grBoxAllign.TabStop = false;
            this.grBoxAllign.Text = "Aliign Text";
            // 
            // rbtnRight
            // 
            this.rbtnRight.AutoSize = true;
            this.rbtnRight.Location = new System.Drawing.Point(23, 154);
            this.rbtnRight.Name = "rbtnRight";
            this.rbtnRight.Size = new System.Drawing.Size(93, 29);
            this.rbtnRight.TabIndex = 2;
            this.rbtnRight.TabStop = true;
            this.rbtnRight.Text = "Right";
            this.rbtnRight.UseVisualStyleBackColor = true;
            this.rbtnRight.CheckedChanged += new System.EventHandler(this.rbtnRight_CheckedChanged);
            // 
            // rbtnCenter
            // 
            this.rbtnCenter.AutoSize = true;
            this.rbtnCenter.Location = new System.Drawing.Point(23, 98);
            this.rbtnCenter.Name = "rbtnCenter";
            this.rbtnCenter.Size = new System.Drawing.Size(107, 29);
            this.rbtnCenter.TabIndex = 1;
            this.rbtnCenter.TabStop = true;
            this.rbtnCenter.Text = "Center";
            this.rbtnCenter.UseVisualStyleBackColor = true;
            this.rbtnCenter.CheckedChanged += new System.EventHandler(this.rbtnCenter_CheckedChanged);
            // 
            // rbtnLeft
            // 
            this.rbtnLeft.AutoSize = true;
            this.rbtnLeft.Location = new System.Drawing.Point(23, 46);
            this.rbtnLeft.Name = "rbtnLeft";
            this.rbtnLeft.Size = new System.Drawing.Size(79, 29);
            this.rbtnLeft.TabIndex = 0;
            this.rbtnLeft.TabStop = true;
            this.rbtnLeft.Text = "Left";
            this.rbtnLeft.UseVisualStyleBackColor = true;
            this.rbtnLeft.CheckedChanged += new System.EventHandler(this.rbtnLeft_CheckedChanged);
            // 
            // panelHello
            // 
            this.panelHello.BackColor = System.Drawing.Color.White;
            this.panelHello.Location = new System.Drawing.Point(223, 106);
            this.panelHello.Name = "panelHello";
            this.panelHello.Size = new System.Drawing.Size(332, 174);
            this.panelHello.TabIndex = 10;
            this.panelHello.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHello_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 388);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.grBoxAllign.ResumeLayout(false);
            this.grBoxAllign.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFont;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbBoxFont;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.ComboBox cbBoxSize;
        private System.Windows.Forms.CheckBox ckBoxBold;
        private System.Windows.Forms.CheckBox ckBoxItalic;
        private System.Windows.Forms.CheckBox ckBoxUnderline;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox grBoxAllign;
        private System.Windows.Forms.RadioButton rbtnRight;
        private System.Windows.Forms.RadioButton rbtnCenter;
        private System.Windows.Forms.RadioButton rbtnLeft;
        private System.Windows.Forms.FlowLayoutPanel panelHello;
        private System.Windows.Forms.ColorDialog clDialog;
    }
}

