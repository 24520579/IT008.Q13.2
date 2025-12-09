namespace Bai09
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
            this.cbBoxShape = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbBoxShape
            // 
            this.cbBoxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxShape.FormattingEnabled = true;
            this.cbBoxShape.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Ellipse",
            "Pie",
            "Filled Circle",
            "Filled Square",
            "Filled Ellipse",
            "Filled Pie"});
            this.cbBoxShape.Location = new System.Drawing.Point(12, 27);
            this.cbBoxShape.Name = "cbBoxShape";
            this.cbBoxShape.Size = new System.Drawing.Size(228, 39);
            this.cbBoxShape.TabIndex = 0;
            this.cbBoxShape.SelectedIndexChanged += new System.EventHandler(this.cboShapes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 489);
            this.Controls.Add(this.cbBoxShape);
            this.Name = "Form1";
            this.Text = "ComboBoxTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxShape;
    }
}

