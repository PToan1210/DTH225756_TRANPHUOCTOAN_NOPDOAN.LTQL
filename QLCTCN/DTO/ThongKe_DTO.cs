using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Thống kê theo hạng mục
    public class ThongKeHangMuc_DTO
    {
        public string TenHangMuc { get; set; }
        public decimal TongThu { get; set; }
        public decimal TongChi { get; set; }
        public int SoLuongGiaoDich { get; set; }
        public string LoaiHangMuc { get; set; } // "Thu" hoặc "Chi"
    }

    // Thống kê theo tháng trong năm
    public class ThongKeTheoThang_DTO
    {
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal TongThu { get; set; }
        public decimal TongChi { get; set; }
        public decimal ChenhLech { get; set; }
    }

    // Thống kê theo khoảng thời gian
    public class ThongKeKhoangThoiGian_DTO
    {
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public decimal TongThu { get; set; }
        public decimal TongChi { get; set; }
        public decimal ChenhLech => TongThu - TongChi;
    }

    // Chi tiết giao dịch hiển thị trên DataGridView
    public class ChiTietGiaoDich_DTO
    {
        public DateTime NgayGiaoDich { get; set; }
        public string TenHangMuc { get; set; }
        public string TenNguonTien { get; set; }
        public decimal SoTienThu { get; set; }
        public decimal SoTienChi { get; set; }
        public string MoTa { get; set; }
        public string Loai { get; set; } // "Thu" hoặc "Chi"
    }
}