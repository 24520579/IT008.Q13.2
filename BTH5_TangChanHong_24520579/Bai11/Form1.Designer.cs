namespace Bai11
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radGradient = new System.Windows.Forms.RadioButton();
            this.radSolid = new System.Windows.Forms.RadioButton();
            this.radTexture = new System.Windows.Forms.RadioButton();
            this.radHatch = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEllipse = new System.Windows.Forms.RadioButton();
            this.radRect = new System.Windows.Forms.RadioButton();
            this.radLine = new System.Windows.Forms.RadioButton();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 638);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radGradient);
            this.groupBox3.Controls.Add(this.radSolid);
            this.groupBox3.Controls.Add(this.radTexture);
            this.groupBox3.Controls.Add(this.radHatch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 221);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // radGradient
            // 
            this.radGradient.AutoSize = true;
            this.radGradient.Location = new System.Drawing.Point(12, 160);
            this.radGradient.Name = "radGradient";
            this.radGradient.Size = new System.Drawing.Size(295, 35);
            this.radGradient.TabIndex = 4;
            this.radGradient.Text = "LinearGradientBrush";
            this.radGradient.UseVisualStyleBackColor = true;
            // 
            // radSolid
            // 
            this.radSolid.AutoSize = true;
            this.radSolid.Checked = true;
            this.radSolid.Location = new System.Drawing.Point(12, 37);
            this.radSolid.Name = "radSolid";
            this.radSolid.Size = new System.Drawing.Size(176, 35);
            this.radSolid.TabIndex = 1;
            this.radSolid.TabStop = true;
            this.radSolid.Text = "SolidBrush";
            this.radSolid.UseVisualStyleBackColor = true;
            // 
            // radTexture
            // 
            this.radTexture.AutoSize = true;
            this.radTexture.Location = new System.Drawing.Point(12, 119);
            this.radTexture.Name = "radTexture";
            this.radTexture.Size = new System.Drawing.Size(208, 35);
            this.radTexture.TabIndex = 3;
            this.radTexture.Text = "TextureBrush";
            this.radTexture.UseVisualStyleBackColor = true;
            // 
            // radHatch
            // 
            this.radHatch.AutoSize = true;
            this.radHatch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radHatch.Location = new System.Drawing.Point(12, 78);
            this.radHatch.Name = "radHatch";
            this.radHatch.Size = new System.Drawing.Size(188, 35);
            this.radHatch.TabIndex = 2;
            this.radHatch.Text = "HatchBrush";
            this.radHatch.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 166);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(51, 104);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(169, 43);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(125, 30);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(158, 38);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEllipse);
            this.groupBox1.Controls.Add(this.radRect);
            this.groupBox1.Controls.Add(this.radLine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // radEllipse
            // 
            this.radEllipse.AutoSize = true;
            this.radEllipse.Location = new System.Drawing.Point(12, 119);
            this.radEllipse.Name = "radEllipse";
            this.radEllipse.Size = new System.Drawing.Size(125, 35);
            this.radEllipse.TabIndex = 4;
            this.radEllipse.Text = "Ellipse";
            this.radEllipse.UseVisualStyleBackColor = true;
            // 
            // radRect
            // 
            this.radRect.AutoSize = true;
            this.radRect.Location = new System.Drawing.Point(12, 78);
            this.radRect.Name = "radRect";
            this.radRect.Size = new System.Drawing.Size(168, 35);
            this.radRect.TabIndex = 3;
            this.radRect.Text = "Rectangle";
            this.radRect.UseVisualStyleBackColor = true;
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.Checked = true;
            this.radLine.Location = new System.Drawing.Point(12, 37);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(96, 35);
            this.radLine.TabIndex = 2;
            this.radLine.TabStop = true;
            this.radLine.Text = "Line";
            this.radLine.UseVisualStyleBackColor = true;
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(341, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(957, 638);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 638);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEllipse;
        private System.Windows.Forms.RadioButton radRect;
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radGradient;
        private System.Windows.Forms.RadioButton radSolid;
        private System.Windows.Forms.RadioButton radTexture;
        private System.Windows.Forms.RadioButton radHatch;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}

