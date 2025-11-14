using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            string soTaiKhoan = txtSoTaiKhoan.Text.Trim();
            string tenKhachHang = txtTenKhachHang.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soTienStr = txtSoTien.Text.Trim();

            if (string.IsNullOrWhiteSpace(soTaiKhoan) ||
                string.IsNullOrWhiteSpace(tenKhachHang) ||
                string.IsNullOrWhiteSpace(diaChi) ||
                string.IsNullOrWhiteSpace(soTienStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(soTienStr, out decimal soTien) || soTien < 0)
            {
                MessageBox.Show("Số tiền không hợp lệ! Vui lòng nhập số dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem item = TimTaiKhoan(soTaiKhoan);

            if (item == null)
            {
                ListViewItem newItem = new ListViewItem(soTaiKhoan);
                newItem.SubItems.Add(tenKhachHang);
                newItem.SubItems.Add(diaChi);
                newItem.SubItems.Add(soTien.ToString("N0"));
                lvTaiKhoan.Items.Add(newItem);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                item.SubItems[1].Text = tenKhachHang;
                item.SubItems[2].Text = diaChi;
                item.SubItems[3].Text = soTien.ToString("N0");
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CapNhatTongTien();
            ClearInputs();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string soTaiKhoan = txtSoTaiKhoan.Text.Trim();

            if (string.IsNullOrWhiteSpace(soTaiKhoan))
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem item = TimTaiKhoan(soTaiKhoan);

            if (item == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    lvTaiKhoan.Items.Remove(item);
                    CapNhatTongTien();
                    ClearInputs();
                    MessageBox.Show("Xóa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvTaiKhoan.SelectedItems[0];
                txtSoTaiKhoan.Text = item.SubItems[0].Text;
                txtTenKhachHang.Text = item.SubItems[1].Text;
                txtDiaChi.Text = item.SubItems[2].Text;

                string soTienFormatted = item.SubItems[3].Text;
                txtSoTien.Text = decimal.Parse(soTienFormatted, System.Globalization.NumberStyles.Any).ToString();
            }
        }

        private ListViewItem TimTaiKhoan(string soTaiKhoan)
        {
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[0].Text.Equals(soTaiKhoan, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }

        private void CapNhatTongTien()
        {
            decimal tongTien = 0;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (decimal.TryParse(item.SubItems[3].Text, System.Globalization.NumberStyles.Any, null, out decimal soTien))
                {
                    tongTien += soTien;
                }
            }
            txtTongTien.Text = tongTien.ToString("N0");
        }

        private void ClearInputs()
        {
            txtSoTaiKhoan.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSoTien.Text = "";
            txtSoTaiKhoan.Focus();
        }
    }
}