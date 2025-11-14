namespace Bai09
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMoveToAvailable = new System.Windows.Forms.Button();
            this.btnMoveToSelected = new System.Windows.Forms.Button();
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.lstAvailable = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNu = new System.Windows.Forms.CheckBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMoveToAvailable);
            this.groupBox1.Controls.Add(this.btnMoveToSelected);
            this.groupBox1.Controls.Add(this.lstSelected);
            this.groupBox1.Controls.Add(this.lstAvailable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkNu);
            this.groupBox1.Controls.Add(this.chkNam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbChuyenNganh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1140, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnMoveToAvailable
            // 
            this.btnMoveToAvailable.Location = new System.Drawing.Point(662, 297);
            this.btnMoveToAvailable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveToAvailable.Name = "btnMoveToAvailable";
            this.btnMoveToAvailable.Size = new System.Drawing.Size(60, 47);
            this.btnMoveToAvailable.TabIndex = 13;
            this.btnMoveToAvailable.Text = "<";
            this.btnMoveToAvailable.UseVisualStyleBackColor = true;
            this.btnMoveToAvailable.Click += new System.EventHandler(this.btnMoveToAvailable_Click);
            // 
            // btnMoveToSelected
            // 
            this.btnMoveToSelected.Location = new System.Drawing.Point(662, 241);
            this.btnMoveToSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveToSelected.Name = "btnMoveToSelected";
            this.btnMoveToSelected.Size = new System.Drawing.Size(60, 47);
            this.btnMoveToSelected.TabIndex = 12;
            this.btnMoveToSelected.Text = ">";
            this.btnMoveToSelected.UseVisualStyleBackColor = true;
            this.btnMoveToSelected.Click += new System.EventHandler(this.btnMoveToSelected_Click);
            // 
            // lstSelected
            // 
            this.lstSelected.FormattingEnabled = true;
            this.lstSelected.ItemHeight = 25;
            this.lstSelected.Location = new System.Drawing.Point(741, 200);
            this.lstSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelected.Size = new System.Drawing.Size(364, 179);
            this.lstSelected.TabIndex = 11;
            // 
            // lstAvailable
            // 
            this.lstAvailable.FormattingEnabled = true;
            this.lstAvailable.ItemHeight = 25;
            this.lstAvailable.Location = new System.Drawing.Point(324, 200);
            this.lstAvailable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAvailable.Size = new System.Drawing.Size(312, 179);
            this.lstAvailable.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Location = new System.Drawing.Point(1032, 134);
            this.chkNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(71, 29);
            this.chkNu.TabIndex = 8;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            this.chkNu.CheckedChanged += new System.EventHandler(this.chkNu_CheckedChanged);
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Location = new System.Drawing.Point(918, 134);
            this.chkNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(88, 29);
            this.chkNam.TabIndex = 7;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            this.chkNam.CheckedChanged += new System.EventHandler(this.chkNam_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(788, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính:";
            // 
            // cmbChuyenNganh
            // 
            this.cmbChuyenNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChuyenNganh.FormattingEnabled = true;
            this.cmbChuyenNganh.Location = new System.Drawing.Point(188, 131);
            this.cmbChuyenNganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbChuyenNganh.Name = "cmbChuyenNganh";
            this.cmbChuyenNganh.Size = new System.Drawing.Size(553, 33);
            this.cmbChuyenNganh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chuyên Ngành:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(639, 61);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(466, 31);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên:";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(188, 61);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(331, 31);
            this.txtMSSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(441, 448);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(165, 47);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu Thông Tin";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(615, 448);
            this.btnXoaChon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(165, 47);
            this.btnXoaChon.TabIndex = 2;
            this.btnXoaChon.Text = "Xóa Chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHoTen,
            this.colChuyenNganh,
            this.colGioiTinh,
            this.colSoMon});
            this.dgvSinhVien.Location = new System.Drawing.Point(18, 519);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(1140, 400);
            this.dgvSinhVien.TabIndex = 3;
            this.dgvSinhVien.SelectionChanged += new System.EventHandler(this.dgvSinhVien_SelectionChanged);
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.ReadOnly = true;
            this.colMSSV.Width = 120;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Width = 180;
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.HeaderText = "Chuyên Ngành";
            this.colChuyenNganh.MinimumWidth = 6;
            this.colChuyenNganh.Name = "colChuyenNganh";
            this.colChuyenNganh.ReadOnly = true;
            this.colChuyenNganh.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 80;
            // 
            // colSoMon
            // 
            this.colSoMon.HeaderText = "Số Môn";
            this.colSoMon.MinimumWidth = 6;
            this.colSoMon.Name = "colSoMon";
            this.colSoMon.ReadOnly = true;
            this.colSoMon.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 938);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnXoaChon);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Liệu Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChuyenNganh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstAvailable;
        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.Button btnMoveToAvailable;
        private System.Windows.Forms.Button btnMoveToSelected;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoMon;
    }
}