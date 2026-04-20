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
    public partial class frmThongKe : Form
    {
        private int _maNguoiDung;
        private List<ChiTietGiaoDich_DTO> _duLieuHienTai;
        private DateTime _tuNgayHienTai;
        private DateTime _denNgayHienTai;
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            if (frmdangnhap.TaiKhoanHienTai != null)
            {
                _maNguoiDung = frmdangnhap.TaiKhoanHienTai.SMaNguoiDung;
            }

            cbbTimKim.SelectedIndex = 1; 
            dtpTu.Value = DateTime.Now;
            dtpDen.Value = DateTime.Now;

            HienThiDateTimePickerTheoLoai();

            LoadThongKe();

            cbbTimKim.SelectedIndexChanged += CbbTimKim_SelectedIndexChanged; 
            btnTim.Click += BtnTim_Click;
            btnXuat.Click += BtnXuat_Click;
            dtpTu.ValueChanged += DtpTu_ValueChanged;
            dtpDen.ValueChanged += DtpDen_ValueChanged;
        }

        private void DtpDen_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void DtpTu_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnXuat_Click(object sender, EventArgs e)
        {
            
        }

        private void CbbTimKim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
           
        }

        private void HienThiDateTimePickerTheoLoai()
        {
            string loai = cbbTimKim.SelectedItem?.ToString();

            if (loai == "Từ ngày đến ngày")
            {
                dtpTu.Visible = true;
                dtpDen.Visible = true;
                dtpTu.Location = new System.Drawing.Point(183, 54);
                dtpDen.Location = new System.Drawing.Point(317, 54);
            }
            else
            {
                dtpTu.Visible = true;
                dtpDen.Visible = false;
                dtpTu.Location = new System.Drawing.Point(250, 54);
            }
        }

       
        private (DateTime tuNgay, DateTime denNgay) LayKhoangThoiGian()
        {
            string loai = cbbTimKim.SelectedItem?.ToString();
            DateTime moc = dtpTu.Value;

            if (loai == "Từ ngày đến ngày")
            {
                DateTime tu = dtpTu.Value.Date;
                DateTime den = dtpDen.Value.Date;
                if (tu > den)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return (den, den);
                }
                return (tu, den);
            }

            return ThongKe_BUS.LayKhoangThoiGianTheoLoai(loai, moc);
        }
        
        private void LoadThongKe()
        {
            try
            {
                if (_maNguoiDung <= 0)
                {
                    MessageBox.Show("Vui lòng đăng nhập lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var (tuNgay, denNgay) = LayKhoangThoiGian();

                var tongHop = ThongKe_BUS.ThongKeTheoKhoangThoiGian(_maNguoiDung, tuNgay, denNgay);

                lbTongThu.Text = tongHop.TongThu.ToString("N0") + " VND";
                lbTongChi.Text = tongHop.TongChi.ToString("N0") + " VND";

                decimal chenhLech = tongHop.ChenhLech;
                lbLech.Text = chenhLech.ToString("N0") + " VND";
                lbLech.ForeColor = chenhLech >= 0 ? System.Drawing.Color.Green : System.Drawing.Color.Red;

  
                List<ChiTietGiaoDich_DTO> dsChiTiet = ThongKe_BUS.LayChiTietGiaoDich(_maNguoiDung, tuNgay, denNgay);

                dgvThongKe.DataSource = dsChiTiet;
                DinhDangDataGridView();

                _duLieuHienTai = dsChiTiet;
                _tuNgayHienTai = tuNgay;
                _denNgayHienTai = denNgay;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void DinhDangDataGridView()
        {
            if (dgvThongKe.Columns.Contains("NgayGiaoDich"))
            {
                dgvThongKe.Columns["NgayGiaoDich"].HeaderText = "Ngày Giao Dịch";
                dgvThongKe.Columns["NgayGiaoDich"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvThongKe.Columns["NgayGiaoDich"].Width = 120;
            }

            if (dgvThongKe.Columns.Contains("TenHangMuc"))
            {
                dgvThongKe.Columns["TenHangMuc"].HeaderText = "Hạng Mục";
                dgvThongKe.Columns["TenHangMuc"].Width = 150;
            }

            if (dgvThongKe.Columns.Contains("TenNguonTien"))
            {
                dgvThongKe.Columns["TenNguonTien"].HeaderText = "Nguồn Tiền";
                dgvThongKe.Columns["TenNguonTien"].Width = 150;
            }

            if (dgvThongKe.Columns.Contains("SoTienThu"))
            {
                dgvThongKe.Columns["SoTienThu"].HeaderText = "Số Tiền Thu";
                dgvThongKe.Columns["SoTienThu"].DefaultCellStyle.Format = "N0";
                dgvThongKe.Columns["SoTienThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvThongKe.Columns["SoTienThu"].Width = 130;
            }

            if (dgvThongKe.Columns.Contains("SoTienChi"))
            {
                dgvThongKe.Columns["SoTienChi"].HeaderText = "Số Tiền Chi";
                dgvThongKe.Columns["SoTienChi"].DefaultCellStyle.Format = "N0";
                dgvThongKe.Columns["SoTienChi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvThongKe.Columns["SoTienChi"].Width = 130;
            }

            if (dgvThongKe.Columns.Contains("MoTa"))
            {
                dgvThongKe.Columns["MoTa"].HeaderText = "Mô Tả";
                dgvThongKe.Columns["MoTa"].Width = 200;
            }

            if (dgvThongKe.Columns.Contains("Loai"))
            {
                dgvThongKe.Columns["Loai"].HeaderText = "Loại";
                dgvThongKe.Columns["Loai"].Width = 80;
            }

            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvThongKe.RowTemplate.Height = 35;
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.ReadOnly = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                if (_duLieuHienTai == null || _duLieuHienTai.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo DataTable
                DataTable dt = new DataTable();

                // Thêm cột với kiểu object để tránh lỗi (sau đó Excel sẽ tự hiểu)
                dt.Columns.Add("Ngày giao dịch", typeof(string));
                dt.Columns.Add("Hạng mục", typeof(string));
                dt.Columns.Add("Nguồn tiền", typeof(string));
                dt.Columns.Add("Số tiền thu", typeof(object));  // ⭐ Đổi thành object
                dt.Columns.Add("Số tiền chi", typeof(object));  // ⭐ Đổi thành object
                dt.Columns.Add("Mô tả", typeof(string));
                dt.Columns.Add("Loại", typeof(string));

                foreach (var item in _duLieuHienTai)
                {
                    // ⭐ Xử lý giá trị: nếu bằng 0 hoặc null thì để trống
                    string soTienThu = item.SoTienThu > 0 ? item.SoTienThu.ToString("N0") : "";
                    string soTienChi = item.SoTienChi > 0 ? item.SoTienChi.ToString("N0") : "";

                    dt.Rows.Add(
                        item.NgayGiaoDich.ToString("dd/MM/yyyy"),
                        string.IsNullOrEmpty(item.TenHangMuc) ? "" : item.TenHangMuc,
                        string.IsNullOrEmpty(item.TenNguonTien) ? "" : item.TenNguonTien,
                        soTienThu,  // ⭐ Lưu dưới dạng string
                        soTienChi,  // ⭐ Lưu dưới dạng string
                        string.IsNullOrEmpty(item.MoTa) ? "" : item.MoTa,
                        string.IsNullOrEmpty(item.Loai) ? "" : item.Loai
                    );
                }

                // Tính tổng (từ dữ liệu gốc, không từ DataTable)
                decimal tongThu = _duLieuHienTai.Sum(x => x.SoTienThu);
                decimal tongChi = _duLieuHienTai.Sum(x => x.SoTienChi);

                // Thêm dòng tổng kết
                dt.Rows.Add("", "", "TỔNG KẾT", tongThu.ToString("N0"), tongChi.ToString("N0"), "", "");
                dt.Rows.Add("", "", "CHÊNH LỆCH", (tongThu - tongChi).ToString("N0"), "", "", "");

                string tieuDe = $"BÁO CÁO THỐNG KÊ THU CHI\nTừ ngày: {_tuNgayHienTai:dd/MM/yyyy} - Đến ngày: {_denNgayHienTai:dd/MM/yyyy}\nNgười dùng: {frmdangnhap.TaiKhoanHienTai?.SHoTen}";

                ExportExcelHelper.XuatExcel(dt, "ThongKeThuChi", tieuDe);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất Excel: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void cbbTimKim_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDateTimePickerTheoLoai();
            LoadThongKe();
        }

        private void dtpTu_ValueChanged(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void dtpDen_ValueChanged(object sender, EventArgs e)
        {
            LoadThongKe();
        }
    }
}
