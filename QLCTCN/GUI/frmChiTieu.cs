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
    public partial class frmChiTieu : Form
    {
        private int _maNguoiDung;
        public frmChiTieu()
        {
            InitializeComponent();
        }

        private void frmChiTieu_Load(object sender, EventArgs e)
        {
            _maNguoiDung = frmdangnhap.TaiKhoanHienTai.SMaNguoiDung;
            HienThiDSChiTieu();
            HienThiHangMuc();
            HienThiNguonTien();
        }
        private void HienThiDSChiTieu()
        {
            List<GiaoDich_DTO> lstThu = GiaoDich_BUS.LayChiTieu(_maNguoiDung);
            dgvDSChiTieu.DataSource = lstThu;
           
            dgvDSChiTieu.Columns["SNgayGiaoDich"].HeaderText = "Ngày Giao Dịch";
            dgvDSChiTieu.Columns["SNgayGiaoDich"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSChiTieu.Columns["SSoTien"].HeaderText = "Số Tiền";
            dgvDSChiTieu.Columns["SSoTien"].DefaultCellStyle.Format = "N0";
            dgvDSChiTieu.Columns["SMoTa"].HeaderText = "Mô Tả";
            dgvDSChiTieu.Columns["STenNguonTien"].HeaderText = "Nguồn Tiền";
            dgvDSChiTieu.Columns["STenHangMuc"].HeaderText = "Hạng mục";
            dgvDSChiTieu.Columns["SHanMuc"].HeaderText = "Hạn mức";
            dgvDSChiTieu.Columns["SMaGiaoDich"].Visible = false;
            dgvDSChiTieu.Columns["SMaNguonTien"].Visible = false;
            dgvDSChiTieu.Columns["SMaNguoiDung"].Visible = false;
            dgvDSChiTieu.Columns["SMaHangMuc"].Visible = false;
            dgvDSChiTieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSChiTieu.RowTemplate.Height = 35;
        }
        private void HienThiHangMuc()
        {
            List<HangMuc_DTO> lstHanmuc = HangMuc_BUS.LayHangMuc(_maNguoiDung);
            var ThuList = lstHanmuc.Where(item => item.SLoaiHangMuc == "Chi").ToList();
            cbbTenChiTieu.DataSource = ThuList;
            cbbTenChiTieu.DisplayMember = "STenHangMuc";
            cbbTenChiTieu.ValueMember = "SMaHangMuc";
        }
        private void HienThiNguonTien()
        {
            List<NguonTien_DTO> lstNguonTien = NguonTien_BUS.LayNguonTien(_maNguoiDung);
            cbbNTChiTieu.DataSource = lstNguonTien;
            cbbNTChiTieu.DisplayMember = "STenNguonTien";
            cbbNTChiTieu.ValueMember = "SMaNguonTien";
        }

        private void dgvDSChiTieu_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();

            r = dgvDSChiTieu.SelectedRows[0];
            cbbNTChiTieu.Text = r.Cells["STenNguonTien"].Value.ToString();
            cbbTenChiTieu.Text = r.Cells["STenHangMuc"].Value.ToString();
            txtMoTaChiTieu.Text = r.Cells["SMoTa"].Value.ToString();
            nbChiTieu.Value = decimal.Parse(r.Cells["SSoTien"].Value.ToString());
            lbHanMucChiTieu.Text= r.Cells["SHanMuc"].Value.ToString();

        }

        private void btnThemChiTieu_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (nbChiTieu.Value <= 0)
                {
                    MessageBox.Show("Số tiền phải lớn hơn 0!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nbChiTieu.Focus();
                    return;
                }

                if (cbbTenChiTieu.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn hạng mục!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbbNTChiTieu.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn nguồn tiền!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maNguonTien = Convert.ToInt32(cbbNTChiTieu.SelectedValue);
                NguonTien_DTO nt = NguonTien_BUS.LayNguonTien(_maNguoiDung)
                    .FirstOrDefault(x => x.SMaNguonTien == maNguonTien);

                if (nt != null && nt.SSoDuHienTai < nbChiTieu.Value)
                {
                    MessageBox.Show($"Số dư không đủ! Số dư hiện tại: {nt.SSoDuHienTai:N0} VND",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GiaoDich_DTO gd = new GiaoDich_DTO();
                gd.SMaNguonTien = Convert.ToInt32(cbbNTChiTieu.SelectedValue);
                gd.SMaHangMuc = Convert.ToInt32(cbbTenChiTieu.SelectedValue);
                gd.SSoTien = nbChiTieu.Value;
                gd.SMoTa = txtMoTaChiTieu.Text.Trim();
                gd.SNgayGiaoDich = dtpNgayChiTieu.Value;

                if (GiaoDich_BUS.ThemGiaoDich(gd, _maNguoiDung))
                {
                    MessageBox.Show("Thêm khoản chi thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSChiTieu();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thêm thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaChiTieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSChiTieu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn khoản chi cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow r = dgvDSChiTieu.SelectedRows[0];
                int maGD = Convert.ToInt32(r.Cells["SMaGiaoDich"].Value);
                string soTien = string.Format("{0:N0}", Convert.ToDecimal(r.Cells["SSoTien"].Value));

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khoản chi {soTien} VND?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (GiaoDich_BUS.XoaGiaoDich(maGD))
                    {
                        MessageBox.Show("Xóa khoản chi thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDSChiTieu();
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

        private void btnSuaChiTieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSChiTieu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn khoản chi cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nbChiTieu.Value <= 0)
                {
                    MessageBox.Show("Số tiền phải lớn hơn 0!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nbChiTieu.Focus();
                    return;
                }

                DataGridViewRow r = dgvDSChiTieu.SelectedRows[0];

                GiaoDich_DTO gd = new GiaoDich_DTO();
                gd.SMaGiaoDich = Convert.ToInt32(r.Cells["SMaGiaoDich"].Value);
                gd.SMaNguonTien = Convert.ToInt32(cbbNTChiTieu.SelectedValue);
                gd.SMaHangMuc = Convert.ToInt32(cbbTenChiTieu.SelectedValue);
                gd.SSoTien = nbChiTieu.Value;
                gd.SMoTa = txtMoTaChiTieu.Text.Trim();
                gd.SNgayGiaoDich = dtpNgayChiTieu.Value;

                if (GiaoDich_BUS.SuaGiaoDich(gd))
                {
                    MessageBox.Show("Sửa khoản chi thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSChiTieu();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Sửa thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyChiTieu_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            txtMoTaChiTieu.Clear();
            nbChiTieu.Value = 0;
            dtpNgayChiTieu.Value = DateTime.Now;
            lbHanMucChiTieu.Visible = false;

            if (cbbTenChiTieu.Items.Count > 0)
                cbbTenChiTieu.SelectedIndex = 0;

            if (cbbNTChiTieu.Items.Count > 0)
                cbbNTChiTieu.SelectedIndex = 0;
        }

        private void cbbTenChiTieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenChiTieu.SelectedValue == null) return;

            try
            {
                int maHangMuc = Convert.ToInt32(cbbTenChiTieu.SelectedValue);
                HangMuc_DTO hm = HangMuc_BUS.LayHangMuc(_maNguoiDung)
                    .FirstOrDefault(x => x.SMaHangMuc == maHangMuc);

                if (hm != null && hm.SLoaiHangMuc == "Chi" && hm.SHanMuc > 0)
                {
                    var dsChi = GiaoDich_BUS.LayChiTieu(_maNguoiDung);
                    decimal tongChiThang = 0;

                    foreach (var item in dsChi)
                    {
                        if (item.SMaHangMuc == maHangMuc &&
                            item.SNgayGiaoDich.Month == DateTime.Now.Month &&
                            item.SNgayGiaoDich.Year == DateTime.Now.Year)
                        {
                            tongChiThang += item.SSoTien;
                        }
                    }

                    decimal hanMucConLai = hm.SHanMuc - tongChiThang;

                    lbHanMucChiTieu.Visible = true;
                    if (hanMucConLai < 0)
                        hanMucConLai = 0;

                    lbHanMucChiTieu.Text = $"Hạn mức còn lại: {hanMucConLai:N0} VND";

                    if (hanMucConLai <= hm.SHanMuc * 0.2m && hanMucConLai > 0)
                    {
                        lbHanMucChiTieu.ForeColor = System.Drawing.Color.Orange;
                    }
                    else if (hanMucConLai <= 0)
                    {
                        lbHanMucChiTieu.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        lbHanMucChiTieu.ForeColor = System.Drawing.Color.Green;
                    }
                }
                else
                {
                    lbHanMucChiTieu.Visible = false;
                }
            }
            catch (Exception)
            {
                lbHanMucChiTieu.Visible = false;
            }
        }
    }
}
