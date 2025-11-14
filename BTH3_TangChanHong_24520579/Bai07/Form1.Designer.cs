namespace Bai07
{
    partial class MainForm
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
            this.lblScreen = new System.Windows.Forms.Label();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBoxC = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.chooseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.groupBoxA.SuspendLayout();
            this.groupBoxB.SuspendLayout();
            this.groupBoxC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScreen
            // 
            this.lblScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.Location = new System.Drawing.Point(12, 9);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(460, 30);
            this.lblScreen.TabIndex = 0;
            this.lblScreen.Text = "MÀN HÌNH";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.button5);
            this.groupBoxA.Controls.Add(this.button4);
            this.groupBoxA.Controls.Add(this.button3);
            this.groupBoxA.Controls.Add(this.button2);
            this.groupBoxA.Controls.Add(this.button1);
            this.groupBoxA.Location = new System.Drawing.Point(12, 53);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(460, 70);
            this.groupBoxA.TabIndex = 1;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Lô A (5000 VND)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(105, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(195, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(285, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(375, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.button10);
            this.groupBoxB.Controls.Add(this.button9);
            this.groupBoxB.Controls.Add(this.button8);
            this.groupBoxB.Controls.Add(this.button7);
            this.groupBoxB.Controls.Add(this.button6);
            this.groupBoxB.Location = new System.Drawing.Point(12, 129);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(460, 70);
            this.groupBoxB.TabIndex = 2;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "Lô B (6500 VND)";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(15, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(105, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 40);
            this.button7.TabIndex = 1;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(195, 21);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 40);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(285, 21);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 40);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(375, 21);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 40);
            this.button10.TabIndex = 4;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // groupBoxC
            // 
            this.groupBoxC.Controls.Add(this.button15);
            this.groupBoxC.Controls.Add(this.button14);
            this.groupBoxC.Controls.Add(this.button13);
            this.groupBoxC.Controls.Add(this.button12);
            this.groupBoxC.Controls.Add(this.button11);
            this.groupBoxC.Location = new System.Drawing.Point(12, 205);
            this.groupBoxC.Name = "groupBoxC";
            this.groupBoxC.Size = new System.Drawing.Size(460, 70);
            this.groupBoxC.TabIndex = 3;
            this.groupBoxC.TabStop = false;
            this.groupBoxC.Text = "Lô C (8000 VND)";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(15, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 40);
            this.button11.TabIndex = 0;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(105, 21);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 40);
            this.button12.TabIndex = 1;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(195, 21);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 40);
            this.button13.TabIndex = 2;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(285, 21);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 40);
            this.button14.TabIndex = 3;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(375, 21);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 40);
            this.button15.TabIndex = 4;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseNumber);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(12, 290);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(108, 20);
            this.lblThanhTien.TabIndex = 4;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(126, 290);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(65, 20);
            this.payment.TabIndex = 5;
            this.payment.Text = "0 (VND)";
            // 
            // chooseButton
            // 
            this.chooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseButton.Location = new System.Drawing.Point(12, 330);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(108, 35);
            this.chooseButton.TabIndex = 6;
            this.chooseButton.Text = "Chọn";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(126, 330);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 35);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Hủy Bỏ";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.Location = new System.Drawing.Point(364, 330);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(108, 35);
            this.finishButton.TabIndex = 8;
            this.finishButton.Text = "Hoàn tất";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.groupBoxC);
            this.Controls.Add(this.groupBoxB);
            this.Controls.Add(this.groupBoxA);
            this.Controls.Add(this.lblScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán vé rạp chiếu phim";
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxB.ResumeLayout(false);
            this.groupBoxC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxB;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBoxC;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button finishButton;
    }
}