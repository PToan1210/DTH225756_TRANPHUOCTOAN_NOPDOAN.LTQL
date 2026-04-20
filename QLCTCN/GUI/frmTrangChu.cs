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
    public partial class frmTrangChu : Form
    {
        private int _maNguoiDung;
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            
            _maNguoiDung = frmdangnhap.TaiKhoanHienTai.SMaNguoiDung;
            HienThiThongTinNguoiDung();
            HienThiSoDu();
        }
        private void HienThiThongTinNguoiDung()
        {
            var taiKhoan = frmdangnhap.TaiKhoanHienTai;
            if (taiKhoan != null)
            {
                lbTenND.Text = taiKhoan.SHoTen;

                
                if (taiKhoan.SVaiTro == true)
                    lblVaiTro.Text = "Admin";
                else
                {
                    lblVaiTro.Text = "Người dùng";
                    btnQuanLyND.Visible = false;
                }
                    

            }
        }

        private void HienThiSoDu()
        {
            try
            {
                List<NguonTien_DTO> lstNguonTien = NguonTien_BUS.LayNguonTien(_maNguoiDung);

                if (lstNguonTien == null || lstNguonTien.Count == 0)
                {
                    lbSoTienMat.Text = "0 VND";
                    lbSoTienTaiKhoan.Text = "0 VND";
                    lbTienVi.Text = "0 VND";
                    return;
                }

                decimal tienMat = 0;
                decimal taiKhoan = 0;
                decimal viDienTu = 0;

                foreach (var nt in lstNguonTien)
                {
                    if (nt.SLoaiNguonTien == "Tiền mặt  ")
                        tienMat += nt.SSoDuHienTai;
                    else if (nt.SLoaiNguonTien == "Ngân hàng ")
                        taiKhoan += nt.SSoDuHienTai;
                    else if (nt.SLoaiNguonTien == "Ví điện tử")
                        viDienTu += nt.SSoDuHienTai;
                }

                lbSoTienMat.Text = tienMat.ToString("N0") + " VND";
                lbSoTienTaiKhoan.Text = taiKhoan.ToString("N0") + " VND";
                lbTienVi.Text = viDienTu.ToString("N0") + " VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải số dư: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThuNhap_Click(object sender, EventArgs e)
        {
           
            frmThuNhap f = new frmThuNhap();

            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;

            scQuanLy.Panel2.Controls.Clear();
            scQuanLy.Panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnChiTieu_Click(object sender, EventArgs e)
        {
            frmChiTieu f = new frmChiTieu();

            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;

            scQuanLy.Panel2.Controls.Clear();
            scQuanLy.Panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnHangMuc_Click(object sender, EventArgs e)
        {
            frmHangMuc f = new frmHangMuc();

            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;

            scQuanLy.Panel2.Controls.Clear();
            scQuanLy.Panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnThongkeChitiêu_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();

            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;

            scQuanLy.Panel2.Controls.Clear();
            scQuanLy.Panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmdangnhap.TaiKhoanHienTai = null;
                frmdangnhap f = new frmdangnhap();
                f.Show();
                this.Close();
            }
        }

        private void btnNguonTien_Click(object sender, EventArgs e)
        {
            frmNguonTien f = new frmNguonTien();

            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;

            scQuanLy.Panel2.Controls.Clear();
            scQuanLy.Panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnQuanLyND_Click(object sender, EventArgs e)
        {
            frmQuanLyND f = new frmQuanLyND();

            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;

            scQuanLy.Panel2.Controls.Clear();
            scQuanLy.Panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }
    }
}
