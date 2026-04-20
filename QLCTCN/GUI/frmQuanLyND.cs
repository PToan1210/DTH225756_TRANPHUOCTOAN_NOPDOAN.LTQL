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
    public partial class frmQuanLyND : Form
    {
        private int _maNguoiDungHienTai;
        private TaiKhoan_DTO _nguoiDungDangChon;

        public frmQuanLyND()
        {
            InitializeComponent();
        }

        private void frmQuanLyND_Load(object sender, EventArgs e)
        {
            if (frmdangnhap.TaiKhoanHienTai != null)
            {
                _maNguoiDungHienTai = frmdangnhap.TaiKhoanHienTai.SMaNguoiDung;
            }
            radND.Checked = true;

            LoadDanhSachNguoiDung();
            ResetForm();
        }
        private void LoadDanhSachNguoiDung()
        {
            List<TaiKhoan_DTO> list = TaiKhoan_BUS.LayDanhSachNguoiDung();
            dgvDSND.DataSource = list;

            if (dgvDSND.Columns.Contains("SMaNguoiDung"))
            {
                dgvDSND.Columns["SMaNguoiDung"].HeaderText = "Mã";
                dgvDSND.Columns["SMaNguoiDung"].Width = 60;
            }

            if (dgvDSND.Columns.Contains("SHoTen"))
            {
                dgvDSND.Columns["SHoTen"].HeaderText = "Họ tên";
                dgvDSND.Columns["SHoTen"].Width = 180;
            }

            if (dgvDSND.Columns.Contains("STenDangNhap"))
            {
                dgvDSND.Columns["STenDangNhap"].HeaderText = "Tên đăng nhập";
                dgvDSND.Columns["STenDangNhap"].Width = 150;
            }

            if (dgvDSND.Columns.Contains("SEmail"))
            {
                dgvDSND.Columns["SEmail"].HeaderText = "Email";
                dgvDSND.Columns["SEmail"].Width = 180;
            }

            if (dgvDSND.Columns.Contains("TenVaiTro"))
            {
                dgvDSND.Columns["TenVaiTro"].HeaderText = "Vai trò";
                dgvDSND.Columns["TenVaiTro"].Width = 100;
            }

            if (dgvDSND.Columns.Contains("SNgayTao"))
            {
                dgvDSND.Columns["SNgayTao"].HeaderText = "Ngày tạo";
                dgvDSND.Columns["SNgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDSND.Columns["SNgayTao"].Width = 120;
            }


            if (dgvDSND.Columns.Contains("SMatKhau"))
                dgvDSND.Columns["SMatKhau"].Visible = false;
            dgvDSND.Columns["SVaiTro"].Visible = false;
            dgvDSND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSND.RowTemplate.Height = 35;
        }

        private void dgvDSND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _nguoiDungDangChon = (TaiKhoan_DTO)dgvDSND.Rows[e.RowIndex].DataBoundItem;
                HienThiThongTinNguoiDung();
            }
        }
        private void HienThiThongTinNguoiDung()
        {
            if (_nguoiDungDangChon != null)
            {
                txtTenND.Text = _nguoiDungDangChon.SHoTen;
                txtTenDN.Text = _nguoiDungDangChon.STenDangNhap;
                txtEmail.Text = _nguoiDungDangChon.SEmail;

                if (_nguoiDungDangChon.SVaiTro)
                    radAdmin.Checked = true;
                else
                    radND.Checked = true;

              
                txtTenDN.Enabled = false;
            }
        }


        private void ResetForm()
        {
            txtTenND.Clear();
            txtTenDN.Clear();
            txtMatKhauDN.Clear();
            txtEmail.Clear();
            radND.Checked = true;
            txtTenDN.Enabled = true;
            _nguoiDungDangChon = null;
        }

        private void btnThemND_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtTenND.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên người dùng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenND.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenDN.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDN.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMatKhauDN.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhauDN.Focus();
                    return;
                }

                if (txtMatKhauDN.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhauDN.Focus();
                    return;
                }

                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.SHoTen = txtTenND.Text.Trim();
                tk.STenDangNhap = txtTenDN.Text.Trim();
                tk.SEmail = txtEmail.Text.Trim();
                tk.SVaiTro = radAdmin.Checked;


                if (TaiKhoan_BUS.ThemNguoiDung(tk, txtMatKhauDN.Text))
                {
                    MessageBox.Show("Thêm người dùng thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNguoiDung();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaND_Click(object sender, EventArgs e)
        {
            try
            {
                if (_nguoiDungDangChon == null)
                {
                    MessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (_nguoiDungDangChon.SMaNguoiDung == _maNguoiDungHienTai)
                {
                    MessageBox.Show("Bạn không thể xóa tài khoản đang đăng nhập!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa người dùng \"{_nguoiDungDangChon.SHoTen}\"?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (TaiKhoan_BUS.XoaNguoiDung(_nguoiDungDangChon.SMaNguoiDung))
                    {
                        MessageBox.Show("Xóa người dùng thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachNguoiDung();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa người dùng thất bại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaND_Click(object sender, EventArgs e)
        {
            try
            {
                if (_nguoiDungDangChon == null)
                {
                    MessageBox.Show("Vui lòng chọn người dùng cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenND.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên người dùng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenND.Focus();
                    return;
                }

                _nguoiDungDangChon.SHoTen = txtTenND.Text.Trim();
                _nguoiDungDangChon.SEmail = txtEmail.Text.Trim();
                _nguoiDungDangChon.SVaiTro = radAdmin.Checked;

                if (TaiKhoan_BUS.SuaNguoiDung(_nguoiDungDangChon))
                {
                    MessageBox.Show("Sửa người dùng thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNguoiDung();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Sửa người dùng thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyND_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
        }
    }

}
