namespace Bai02
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
            this.btnReDraw = new System.Windows.Forms.Button();
            this.pnDraw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnReDraw
            // 
            this.btnReDraw.Location = new System.Drawing.Point(30, 32);
            this.btnReDraw.Name = "btnReDraw";
            this.btnReDraw.Size = new System.Drawing.Size(173, 61);
            this.btnReDraw.TabIndex = 0;
            this.btnReDraw.Text = "Vẽ lại";
            this.btnReDraw.UseVisualStyleBackColor = true;
            this.btnReDraw.Click += new System.EventHandler(this.btnReDraw_Click);
            // 
            // pnDraw
            // 
            this.pnDraw.Location = new System.Drawing.Point(12, 100);
            this.pnDraw.Name = "pnDraw";
            this.pnDraw.Size = new System.Drawing.Size(776, 338);
            this.pnDraw.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnDraw);
            this.Controls.Add(this.btnReDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReDraw;
        private System.Windows.Forms.Panel pnDraw;
    }
}

