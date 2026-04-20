using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmHangMuc : Form
    {
        private int _maNguoiDung;
        public frmHangMuc()
        {
            InitializeComponent();
        }

        private void frmHangMuc_Load(object sender, EventArgs e)
        {
            _maNguoiDung = frmdangnhap.TaiKhoanHienTai.SMaNguoiDung;

            HienThiDSHangMuc();
        }
        private void HienThiDSHangMuc()
        {
            nbHangMuc.Enabled = false;

            List<HangMuc_DTO> lstHangMuc = HangMuc_BUS.LayHangMuc(_maNguoiDung);
            
            dgvDSHangMuc.DataSource = lstHangMuc;
            dgvDSHangMuc.Columns["STenHangMuc"].HeaderText = "Tên Hạng Mục";
            dgvDSHangMuc.Columns["SLoaiHangMuc"].HeaderText = "Loại";
            dgvDSHangMuc.Columns["SHanMuc"].HeaderText = "Hạn Mức";
            dgvDSHangMuc.Columns["SMaHangMuc"].Visible = false;
            dgvDSHangMuc.Columns["SMaNguoiDung"].Visible = false;
            dgvDSHangMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSHangMuc.RowTemplate.Height = 35;
        }
        private void dgvDSHangMuc_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();

            r = dgvDSHangMuc.SelectedRows[0];
            txtTenHangMuc.Text = r.Cells["STenHangMuc"].Value.ToString();
            if (r.Cells["SLoaiHangMuc"].Value.ToString() == "Thu")
            {
                radThu.Checked = true;
                nbHangMuc.Enabled = false;
            }
            else
            {
                radChi.Checked = true;
            }
            nbHangMuc.Value = decimal.Parse(r.Cells["SHanMuc"].Value.ToString());
        }

        private void radThu_CheckedChanged(object sender, EventArgs e)
        {
            nbHangMuc.Enabled = false;
        }

        private void radChi_CheckedChanged(object sender, EventArgs e)
        {
            nbHangMuc.Enabled = true;
        }

        private void btnThemThuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenHangMuc.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên hạng mục!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenHangMuc.Focus();
                    return;
                }

                HangMuc_DTO hm = new HangMuc_DTO();
                hm.STenHangMuc = txtTenHangMuc.Text.Trim();

                if (radThu.Checked)
                {
                    hm.SLoaiHangMuc = "Thu";
                    hm.SHanMuc = 0;
                }
                else
                {
                    hm.SLoaiHangMuc = "Chi";
                    hm.SHanMuc = nbHangMuc.Value;
                }

                if (HangMuc_BUS.ThemHangMuc(hm, _maNguoiDung))
                {
                    MessageBox.Show("Thêm hạng mục thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSHangMuc();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thêm thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaThuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSHangMuc.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hạng mục cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow r = dgvDSHangMuc.SelectedRows[0];
                int maHM = Convert.ToInt32(r.Cells["SMaHangMuc"].Value);
                string tenHM = r.Cells["STenHangMuc"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa hạng mục \"{tenHM}\"?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (HangMuc_BUS.XoaHangMuc(maHM))
                    {
                        MessageBox.Show("Xóa hạng mục thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDSHangMuc();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại! Có thể hạng mục đang được sử dụng.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Xóa thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaChiTieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSHangMuc.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hạng mục cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenHangMuc.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên hạng mục!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenHangMuc.Focus();
                    return;
                }

                DataGridViewRow r = dgvDSHangMuc.SelectedRows[0];

                HangMuc_DTO hm = new HangMuc_DTO();
                hm.SMaHangMuc = Convert.ToInt32(r.Cells["SMaHangMuc"].Value);
                hm.STenHangMuc = txtTenHangMuc.Text.Trim();

                if (radThu.Checked)
                {
                    hm.SLoaiHangMuc = "Thu";
                    hm.SHanMuc = 0;
                }
                else
                {
                    hm.SLoaiHangMuc = "Chi";
                    hm.SHanMuc = nbHangMuc.Value;
                }

                if (HangMuc_BUS.SuaHangMuc(hm, _maNguoiDung))
                {
                    MessageBox.Show("Sửa hạng mục thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSHangMuc();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Sửa thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHuyHM_Click(object sender, EventArgs e)
        {
            ResetForm();

        }
        private void ResetForm()
        {
            txtTenHangMuc.Clear();
            nbHangMuc.Value = 0;
            radThu.Checked = true;
            radChi.Checked = false;
            nbHangMuc.Enabled = false;
        }
    }
}
