using Microsoft.Reporting.WinForms;
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
    public partial class frmXemBaoCao : Form
    {
        private DataTable _duLieu;
        private decimal _tongThu;
        private decimal _tongChi;
        private DateTime _tuNgay;
        private DateTime _denNgay;
        public frmXemBaoCao(DataTable duLieu, decimal tongThu, decimal tongChi, DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            _duLieu = duLieu;
            _tongThu = tongThu;
            _tongChi = tongChi;
            _tuNgay = tuNgay;
            _denNgay = denNgay;
        }

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                string tenNguoiDung = frmdangnhap.TaiKhoanHienTai?.SHoTen ?? "Người dùng";

                if (_duLieu == null || _duLieu.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị báo cáo!", "Thông báo");
                    return;
                }

                string reportPath = System.IO.Path.Combine(Application.StartupPath, "rptBaoCaoThuChi.rdlc");

                if (!System.IO.File.Exists(reportPath))
                {
                    reportPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\rptBaoCaoThuChi.rdlc");
                }

                if (!System.IO.File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath, "Lỗi");
                    return;
                }

                reportViewer1.LocalReport.ReportPath = reportPath;

                reportViewer1.LocalReport.SetParameters(new ReportParameter[]
                {
                    new ReportParameter("NguoiDung", tenNguoiDung),
                    new ReportParameter("TuNgay", _tuNgay.ToString("dd/MM/yyyy")),
                    new ReportParameter("DenNgay", _denNgay.ToString("dd/MM/yyyy")),
                    new ReportParameter("NgayIn", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")),
                    new ReportParameter("TongThu", _tongThu.ToString("N0")),
                    new ReportParameter("TongChi", _tongChi.ToString("N0")),
                    new ReportParameter("ChenhLech", (_tongThu - _tongChi).ToString("N0"))
                });

                ReportDataSource rds = new ReportDataSource("DataSetBaoCao", _duLieu);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải báo cáo: {ex.Message}", "Lỗi");
            }
        }
    }  
    
}
    
 
