using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadListBox();
        }

        private void LoadComboBox()
        {
            cmbChuyenNganh.Items.Add("Hệ Thống Thông Tin");
            cmbChuyenNganh.Items.Add("Công Nghệ Phần Mềm");
            cmbChuyenNganh.Items.Add("Khoa Học Máy Tính");
            cmbChuyenNganh.Items.Add("Mạng Máy Tính");
            cmbChuyenNganh.Items.Add("An Toàn Thông Tin");
        }

        private void LoadListBox()
        {
            lstAvailable.Items.Add("Cơ Sở Dữ Liệu");
            lstAvailable.Items.Add("Cơ Sở DL Nâng Cao");
            lstAvailable.Items.Add("PTTK Hệ Thống thông tin");
            lstAvailable.Items.Add("Lập trình C#");
            lstAvailable.Items.Add("Cấu trúc dữ liệu");
            lstAvailable.Items.Add("Giải thuật");
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked)
            {
                chkNu.Checked = false;
            }
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked)
            {
                chkNam.Checked = false;
            }
        }

        private void btnMoveToSelected_Click(object sender, EventArgs e)
        {
            MoveItems(lstAvailable, lstSelected);
        }

        private void btnMoveToAvailable_Click(object sender, EventArgs e)
        {
            MoveItems(lstSelected, lstAvailable);
        }

        private void MoveItems(ListBox source, ListBox destination)
        {
            if (source.SelectedItems.Count == 0) return;

            List<object> itemsToMove = new List<object>();
            foreach (var item in source.SelectedItems)
            {
                itemsToMove.Add(item);
            }

            foreach (var item in itemsToMove)
            {
                destination.Items.Add(item);
                source.Items.Remove(item);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string hoTen = txtHoTen.Text;
            string chuyenNganh = cmbChuyenNganh.Text;
            string gioiTinh = "";

            if (chkNam.Checked)
                gioiTinh = "Nam";
            else if (chkNu.Checked)
                gioiTinh = "Nữ";

            int soMon = lstSelected.Items.Count;

            if (string.IsNullOrWhiteSpace(mssv) ||
                string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(chuyenNganh) ||
                string.IsNullOrWhiteSpace(gioiTinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvSinhVien.Rows.Add(mssv, hoTen, chuyenNganh, gioiTinh, soMon);

            ClearInputs();
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtMSSV.Text = "";
            txtHoTen.Text = "";
            cmbChuyenNganh.SelectedIndex = -1;
            chkNam.Checked = false;
            chkNu.Checked = false;

            foreach (var item in lstSelected.Items)
            {
                lstAvailable.Items.Add(item);
            }
            lstSelected.Items.Clear();

            txtMSSV.Focus();
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSinhVien.SelectedRows[0];

                txtMSSV.Text = row.Cells["colMSSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString();
                cmbChuyenNganh.Text = row.Cells["colChuyenNganh"].Value?.ToString();

                string gioiTinh = row.Cells["colGioiTinh"].Value?.ToString();
                if (gioiTinh == "Nam")
                {
                    chkNam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    chkNu.Checked = true;
                }

                lstSelected.Items.Clear();
                lstAvailable.Items.Clear();
                LoadListBox();
            }
        }
    }
}