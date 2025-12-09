namespace Bai10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDashStyle = new System.Windows.Forms.Label();
            this.cboDashStyle = new System.Windows.Forms.ComboBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.cboWidth = new System.Windows.Forms.ComboBox();
            this.lblLineJoin = new System.Windows.Forms.Label();
            this.cboLineJoin = new System.Windows.Forms.ComboBox();
            this.lblDashCap = new System.Windows.Forms.Label();
            this.cboDashCap = new System.Windows.Forms.ComboBox();
            this.lblStartCap = new System.Windows.Forms.Label();
            this.cboStartCap = new System.Windows.Forms.ComboBox();
            this.lblEndCap = new System.Windows.Forms.Label();
            this.cboEndCap = new System.Windows.Forms.ComboBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashStyle
            // 
            this.lblDashStyle.AutoSize = true;
            this.lblDashStyle.Location = new System.Drawing.Point(40, 44);
            this.lblDashStyle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDashStyle.Name = "lblDashStyle";
            this.lblDashStyle.Size = new System.Drawing.Size(122, 25);
            this.lblDashStyle.TabIndex = 24;
            this.lblDashStyle.Text = "Dash Style:";
            // 
            // cboDashStyle
            // 
            this.cboDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashStyle.FormattingEnabled = true;
            this.cboDashStyle.Location = new System.Drawing.Point(200, 38);
            this.cboDashStyle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboDashStyle.Name = "cboDashStyle";
            this.cboDashStyle.Size = new System.Drawing.Size(238, 33);
            this.cboDashStyle.TabIndex = 23;
            this.cboDashStyle.SelectedIndexChanged += new System.EventHandler(this.UpdateDrawing);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(40, 121);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(73, 25);
            this.lblWidth.TabIndex = 22;
            this.lblWidth.Text = "Width:";
            // 
            // cboWidth
            // 
            this.cboWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWidth.FormattingEnabled = true;
            this.cboWidth.Location = new System.Drawing.Point(200, 115);
            this.cboWidth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboWidth.Name = "cboWidth";
            this.cboWidth.Size = new System.Drawing.Size(238, 33);
            this.cboWidth.TabIndex = 21;
            this.cboWidth.SelectedIndexChanged += new System.EventHandler(this.UpdateDrawing);
            // 
            // lblLineJoin
            // 
            this.lblLineJoin.AutoSize = true;
            this.lblLineJoin.Location = new System.Drawing.Point(40, 198);
            this.lblLineJoin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLineJoin.Name = "lblLineJoin";
            this.lblLineJoin.Size = new System.Drawing.Size(105, 25);
            this.lblLineJoin.TabIndex = 20;
            this.lblLineJoin.Text = "Line Join:";
            // 
            // cboLineJoin
            // 
            this.cboLineJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineJoin.FormattingEnabled = true;
            this.cboLineJoin.Location = new System.Drawing.Point(200, 192);
            this.cboLineJoin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboLineJoin.Name = "cboLineJoin";
            this.cboLineJoin.Size = new System.Drawing.Size(238, 33);
            this.cboLineJoin.TabIndex = 19;
            this.cboLineJoin.SelectedIndexChanged += new System.EventHandler(this.UpdateDrawing);
            // 
            // lblDashCap
            // 
            this.lblDashCap.AutoSize = true;
            this.lblDashCap.Location = new System.Drawing.Point(40, 275);
            this.lblDashCap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDashCap.Name = "lblDashCap";
            this.lblDashCap.Size = new System.Drawing.Size(113, 25);
            this.lblDashCap.TabIndex = 18;
            this.lblDashCap.Text = "Dash Cap:";
            // 
            // cboDashCap
            // 
            this.cboDashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashCap.FormattingEnabled = true;
            this.cboDashCap.Location = new System.Drawing.Point(200, 269);
            this.cboDashCap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboDashCap.Name = "cboDashCap";
            this.cboDashCap.Size = new System.Drawing.Size(238, 33);
            this.cboDashCap.TabIndex = 17;
            this.cboDashCap.SelectedIndexChanged += new System.EventHandler(this.UpdateDrawing);
            // 
            // lblStartCap
            // 
            this.lblStartCap.AutoSize = true;
            this.lblStartCap.Location = new System.Drawing.Point(40, 352);
            this.lblStartCap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStartCap.Name = "lblStartCap";
            this.lblStartCap.Size = new System.Drawing.Size(108, 25);
            this.lblStartCap.TabIndex = 16;
            this.lblStartCap.Text = "Start Cap:";
            // 
            // cboStartCap
            // 
            this.cboStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartCap.FormattingEnabled = true;
            this.cboStartCap.Location = new System.Drawing.Point(200, 346);
            this.cboStartCap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboStartCap.Name = "cboStartCap";
            this.cboStartCap.Size = new System.Drawing.Size(238, 33);
            this.cboStartCap.TabIndex = 15;
            this.cboStartCap.SelectedIndexChanged += new System.EventHandler(this.UpdateDrawing);
            // 
            // lblEndCap
            // 
            this.lblEndCap.AutoSize = true;
            this.lblEndCap.Location = new System.Drawing.Point(40, 429);
            this.lblEndCap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEndCap.Name = "lblEndCap";
            this.lblEndCap.Size = new System.Drawing.Size(101, 25);
            this.lblEndCap.TabIndex = 14;
            this.lblEndCap.Text = "End Cap:";
            // 
            // cboEndCap
            // 
            this.cboEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEndCap.FormattingEnabled = true;
            this.cboEndCap.Location = new System.Drawing.Point(200, 423);
            this.cboEndCap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboEndCap.Name = "cboEndCap";
            this.cboEndCap.Size = new System.Drawing.Size(238, 33);
            this.cboEndCap.TabIndex = 13;
            this.cboEndCap.SelectedIndexChanged += new System.EventHandler(this.UpdateDrawing);
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanvas.Location = new System.Drawing.Point(480, 38);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(656, 631);
            this.picCanvas.TabIndex = 12;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PicCanvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 731);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.cboEndCap);
            this.Controls.Add(this.lblEndCap);
            this.Controls.Add(this.cboStartCap);
            this.Controls.Add(this.lblStartCap);
            this.Controls.Add(this.cboDashCap);
            this.Controls.Add(this.lblDashCap);
            this.Controls.Add(this.cboLineJoin);
            this.Controls.Add(this.lblLineJoin);
            this.Controls.Add(this.cboWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.cboDashStyle);
            this.Controls.Add(this.lblDashStyle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Pen Demo";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblDashStyle;
        private System.Windows.Forms.ComboBox cboDashStyle;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.ComboBox cboWidth;
        private System.Windows.Forms.Label lblLineJoin;
        private System.Windows.Forms.ComboBox cboLineJoin;
        private System.Windows.Forms.Label lblDashCap;
        private System.Windows.Forms.ComboBox cboDashCap;
        private System.Windows.Forms.Label lblStartCap;
        private System.Windows.Forms.ComboBox cboStartCap;
        private System.Windows.Forms.Label lblEndCap;
        private System.Windows.Forms.ComboBox cboEndCap;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}