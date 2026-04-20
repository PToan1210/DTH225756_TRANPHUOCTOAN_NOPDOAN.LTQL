using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmdangnhap : Form
    {
        public static TaiKhoan_DTO TaiKhoanHienTai { get; set; }
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDN.Text.Trim();
            string matKhau = txtMatKhauDN.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauDN.Focus();
                return;
            }

            // Kiểm tra đăng nhập
            TaiKhoan_DTO taiKhoan = TaiKhoan_BUS.KiemTraDangNhap(tenDangNhap, matKhau);

            if (taiKhoan != null)
            {
                // Lưu thông tin người dùng hiện tại
                TaiKhoanHienTai = taiKhoan;

                MessageBox.Show($"Chào mừng {taiKhoan.SHoTen}!", "Đăng nhập thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form trang chủ
                frmTrangChu f = new frmTrangChu();
                f.Show();

                // Ẩn form đăng nhập
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtMatKhauDN.Clear();
                txtMatKhauDN.Focus();
            }
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = "";
            txtMatKhauDN.Text = "";
            ckbHien.Checked = false;
            txtMatKhauDN.PasswordChar = '*';
        }

        private void ckbHien_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauDN.PasswordChar = ckbHien.Checked ? '\0' : '*';
        }

        private void lkbQuen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản trị viên để được hỗ trợ!",
                "Quên mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangKy f = new frmDangKy();
            f.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
