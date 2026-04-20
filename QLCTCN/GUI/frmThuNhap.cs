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
    public partial class frmThuNhap : Form
    {
        private int _maNguoiDung;
        public frmThuNhap()
        {
            InitializeComponent();
        }

        private void frmThuNhap_Load(object sender, EventArgs e)
        {
            _maNguoiDung = frmdangnhap.TaiKhoanHienTai.SMaNguoiDung;
            HienThiDSThuNhap();
            HienThiHangMuc();
            HienThiNguonTien();
        }
        private void HienThiDSThuNhap()
        {
            List<GiaoDich_DTO> lstThu = GiaoDich_BUS.LayThuNhap(_maNguoiDung);
            dgvDSThuNhap.DataSource = lstThu;

            dgvDSThuNhap.Columns["SNgayGiaoDich"].HeaderText = "Ngày Giao Dịch";
            dgvDSThuNhap.Columns["SNgayGiaoDich"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSThuNhap.Columns["SSoTien"].HeaderText = "Số Tiền";
            dgvDSThuNhap.Columns["SSoTien"].DefaultCellStyle.Format = "N0";
            dgvDSThuNhap.Columns["SMoTa"].HeaderText = "Mô Tả";
            dgvDSThuNhap.Columns["STenNguonTien"].HeaderText = "Nguồn Tiền";
            dgvDSThuNhap.Columns["STenHangMuc"].HeaderText = "Hạng mục";
            dgvDSThuNhap.Columns["SMaGiaoDich"].Visible = false;
            dgvDSThuNhap.Columns["SMaNguonTien"].Visible = false;
            dgvDSThuNhap.Columns["SMaNguoiDung"].Visible = false;
            dgvDSThuNhap.Columns["SMaHangMuc"].Visible = false;
            dgvDSThuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSThuNhap.RowTemplate.Height = 35;
        }

        private void dgvDSThuNhap_Click(object sender, EventArgs e)
        {
            if (dgvDSThuNhap.SelectedRows.Count == 0) return;

            DataGridViewRow r = dgvDSThuNhap.SelectedRows[0];

            cbbNTThuNhap.Text = r.Cells["STenNguonTien"].Value.ToString();
            cbbTenThuNhap.Text = r.Cells["STenHangMuc"].Value.ToString();
            txtMoTaThu.Text = r.Cells["SMoTa"].Value.ToString();
            nbThuNhap.Value = Convert.ToDecimal(r.Cells["SSoTien"].Value);
            dtpNgayThuNhap.Value = Convert.ToDateTime(r.Cells["SNgayGiaoDich"].Value);
        }
        private void HienThiHangMuc()
        {
            List<HangMuc_DTO> lstHanmuc = HangMuc_BUS.LayHangMuc(_maNguoiDung);
            var ThuList = lstHanmuc.Where(item => item.SLoaiHangMuc == "Thu").ToList();
            cbbTenThuNhap.DataSource = ThuList;
            cbbTenThuNhap.DisplayMember = "STenHangMuc";
            cbbTenThuNhap.ValueMember = "SMaHangMuc";
        }
        private void HienThiNguonTien()
        {
            List<NguonTien_DTO> lstNguonTien = NguonTien_BUS.LayNguonTien(_maNguoiDung);
            cbbNTThuNhap.DataSource = lstNguonTien;
            cbbNTThuNhap.DisplayMember = "STenNguonTien";
            cbbNTThuNhap.ValueMember = "SMaNguonTien";
        }
        private void btnThemThuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (nbThuNhap.Value <= 0)
                {
                    MessageBox.Show("Số tiền phải lớn hơn 0!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nbThuNhap.Focus();
                    return;
                }

                if (cbbTenThuNhap.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn hạng mục!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbbNTThuNhap.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn nguồn tiền!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GiaoDich_DTO gd = new GiaoDich_DTO();
                gd.SMaNguonTien = Convert.ToInt32(cbbNTThuNhap.SelectedValue);
                gd.SMaHangMuc = Convert.ToInt32(cbbTenThuNhap.SelectedValue);
                gd.SSoTien = nbThuNhap.Value;
                gd.SMoTa = txtMoTaThu.Text.Trim();
                gd.SNgayGiaoDich = dtpNgayThuNhap.Value;

                if (GiaoDich_BUS.ThemGiaoDich(gd, _maNguoiDung))
                {
                    MessageBox.Show("Thêm khoản thu thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSThuNhap();
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
                if (dgvDSThuNhap.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn khoản thu cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow r = dgvDSThuNhap.SelectedRows[0];
                int maGD = Convert.ToInt32(r.Cells["SMaGiaoDich"].Value);
                string soTien = string.Format("{0:N0}", Convert.ToDecimal(r.Cells["SSoTien"].Value));

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khoản thu {soTien} VND?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (GiaoDich_BUS.XoaGiaoDich(maGD))
                    {
                        MessageBox.Show("Xóa khoản thu thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDSThuNhap();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi",
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

        private void btnSuaThuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSThuNhap.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn khoản thu cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nbThuNhap.Value <= 0)
                {
                    MessageBox.Show("Số tiền phải lớn hơn 0!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nbThuNhap.Focus();
                    return;
                }

                DataGridViewRow r = dgvDSThuNhap.SelectedRows[0];

                GiaoDich_DTO gd = new GiaoDich_DTO();
                gd.SMaGiaoDich = Convert.ToInt32(r.Cells["SMaGiaoDich"].Value);
                gd.SMaNguonTien = Convert.ToInt32(cbbNTThuNhap.SelectedValue);
                gd.SMaHangMuc = Convert.ToInt32(cbbTenThuNhap.SelectedValue);
                gd.SSoTien = nbThuNhap.Value;
                gd.SMoTa = txtMoTaThu.Text.Trim();
                gd.SNgayGiaoDich = dtpNgayThuNhap.Value;

                if (GiaoDich_BUS.SuaGiaoDich(gd))
                {
                    MessageBox.Show("Sửa khoản thu thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSThuNhap();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Sửa thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyThuThap_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            txtMoTaThu.Clear();
            nbThuNhap.Value = 0;
            dtpNgayThuNhap.Value = DateTime.Now;

            if (cbbTenThuNhap.Items.Count > 0)
                cbbTenThuNhap.SelectedIndex = 0;

            if (cbbNTThuNhap.Items.Count > 0)
                cbbNTThuNhap.SelectedIndex = 0;
        }

    }
}
