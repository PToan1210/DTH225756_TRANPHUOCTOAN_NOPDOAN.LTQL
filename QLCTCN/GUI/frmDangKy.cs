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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            txtTenNguoiDung.Clear();
            txtTenDK.Clear();
            txtMatKhauDK.Clear();
            txtNhaplaiDK.Clear();
            txtEmail.Clear();
            ckbHienDK.Checked = false;
            txtMatKhauDK.PasswordChar = '*';
            txtNhaplaiDK.PasswordChar = '*';
        }

        private void btnXacNhanDK_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.SHoTen = txtTenNguoiDung.Text.Trim();
            tk.STenDangNhap = txtTenDK.Text.Trim();
            tk.SEmail = txtEmail.Text.Trim();

            string matKhau = txtMatKhauDK.Text;
            string xacNhanMatKhau = txtNhaplaiDK.Text;

            if (TaiKhoan_BUS.DangKy(tk, matKhau, xacNhanMatKhau))
            {
                MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void ckbHienDK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauDK.PasswordChar = ckbHienDK.Checked ? '\0' : '*';
            txtNhaplaiDK.PasswordChar = ckbHienDK.Checked ? '\0' : '*';
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
