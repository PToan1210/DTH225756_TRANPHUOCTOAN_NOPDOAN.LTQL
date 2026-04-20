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
    public partial class frmNguonTien : Form
    {
        private int _maNguoiDung;
        public frmNguonTien()
        {
            InitializeComponent();
        }

        private void frmNguonTien_Load(object sender, EventArgs e)
        {
            _maNguoiDung = frmdangnhap.TaiKhoanHienTai.SMaNguoiDung;
            HienThiDSNguonTien();
        }
        private void HienThiDSNguonTien()
        {
            List<NguonTien_DTO> lstNguonTien = NguonTien_BUS.LayNguonTien(_maNguoiDung);
            dgvDSNguonTien.DataSource = lstNguonTien;
            dgvDSNguonTien.Columns["STenNguonTien"].HeaderText = "Tên Nguồn Tiền";
            dgvDSNguonTien.Columns["SLoaiNguonTien"].HeaderText = "Loại";
            dgvDSNguonTien.Columns["SSoDuHienTai"].HeaderText = "Số tiền hiện tại";
            dgvDSNguonTien.Columns["SSoDuHienTai"].DefaultCellStyle.Format = "N0";
            dgvDSNguonTien.Columns["SMaNguonTien"].Visible = false;
            dgvDSNguonTien.Columns["SMaNguoiDung"].Visible = false;
            dgvDSNguonTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSNguonTien.RowTemplate.Height = 35;
        }

        private void dgvDSNguonTien_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();

            r = dgvDSNguonTien.SelectedRows[0];
            txtTenNguonTien.Text = r.Cells["STenNguonTien"].Value.ToString();
            if (r.Cells["SLoaiNguonTien"].Value.ToString() == "Tiền mặt  ")
            {
                radMat.Checked = true;
                
            }
            else if (r.Cells["SLoaiNguonTien"].Value.ToString()=="Ngân hàng ")
            {
                radHang.Checked = true;
            }
            else
            {
                radTu.Checked = true;
            }
        }

        private void btnThemNguonTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenNguonTien.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nguồn tiền!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNguonTien.Focus();
                    return;
                }

                NguonTien_DTO nt = new NguonTien_DTO();
                nt.STenNguonTien = txtTenNguonTien.Text.Trim();

                if (radMat.Checked)
                    nt.SLoaiNguonTien = "Tiền mặt";
                else if (radHang.Checked)
                    nt.SLoaiNguonTien = "Ngân hàng";
                else
                    nt.SLoaiNguonTien = "Ví điện tử";

                if (NguonTien_BUS.ThemNguonTien(nt, _maNguoiDung))
                {
                    MessageBox.Show("Thêm nguồn tiền thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSNguonTien();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thêm thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNguonTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSNguonTien.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn nguồn tiền cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow r = dgvDSNguonTien.SelectedRows[0];
                int maNT = Convert.ToInt32(r.Cells["SMaNguonTien"].Value);
                string tenNT = r.Cells["STenNguonTien"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nguồn tiền \"{tenNT}\"?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (NguonTien_BUS.XoaNguonTien(maNT))
                    {
                        MessageBox.Show("Xóa nguồn tiền thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDSNguonTien();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại! Có thể nguồn tiền đang được sử dụng.", "Lỗi",
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

        private void btnSuaNguonTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSNguonTien.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn nguồn tiền cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenNguonTien.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nguồn tiền!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNguonTien.Focus();
                    return;
                }

                DataGridViewRow r = dgvDSNguonTien.SelectedRows[0];

                NguonTien_DTO nt = new NguonTien_DTO();
                nt.SMaNguonTien = Convert.ToInt32(r.Cells["SMaNguonTien"].Value);
                nt.STenNguonTien = txtTenNguonTien.Text.Trim();

                if (radMat.Checked)
                    nt.SLoaiNguonTien = "Tiền mặt";
                else if (radHang.Checked)
                    nt.SLoaiNguonTien = "Ngân hàng";
                else
                    nt.SLoaiNguonTien = "Ví điện tử";

                if (NguonTien_BUS.SuaNguonTien(nt))
                {
                    MessageBox.Show("Sửa nguồn tiền thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSNguonTien();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Sửa thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyNguonTien_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            txtTenNguonTien.Clear();
            radMat.Checked = true;
        }
    }
}
