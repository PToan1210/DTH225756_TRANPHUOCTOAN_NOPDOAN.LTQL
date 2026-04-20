using DTO;
using DAO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class ThongKe_BUS
    {
        // 1. Thống kê theo hạng mục
        public static List<ThongKeHangMuc_DTO> ThongKeTheoHangMuc(int maNguoiDung, int thang, int nam)
        {
            if (maNguoiDung <= 0) return new List<ThongKeHangMuc_DTO>();
            if (thang < 1 || thang > 12) thang = DateTime.Now.Month;
            if (nam < 2000 || nam > 2100) nam = DateTime.Now.Year;

            return ThongKe_DAO.ThongKeTheoHangMuc(maNguoiDung, thang, nam);
        }

        // 2. Thống kê theo tháng trong năm
        public static List<ThongKeTheoThang_DTO> ThongKeTheoThangTrongNam(int maNguoiDung, int nam)
        {
            if (maNguoiDung <= 0) return new List<ThongKeTheoThang_DTO>();
            if (nam < 2000 || nam > 2100) nam = DateTime.Now.Year;

            return ThongKe_DAO.ThongKeTheoThangTrongNam(maNguoiDung, nam);
        }

        // 3. Thống kê theo khoảng thời gian
        public static ThongKeKhoangThoiGian_DTO ThongKeTheoKhoangThoiGian(int maNguoiDung, DateTime tuNgay, DateTime denNgay)
        {
            if (maNguoiDung <= 0) return new ThongKeKhoangThoiGian_DTO();
            if (tuNgay > denNgay)
            {
                DateTime temp = tuNgay;
                tuNgay = denNgay;
                denNgay = temp;
            }

            return ThongKe_DAO.ThongKeTheoKhoangThoiGian(maNguoiDung, tuNgay, denNgay);
        }

        // 4. Lấy chi tiết giao dịch theo khoảng thời gian
        public static List<ChiTietGiaoDich_DTO> LayChiTietGiaoDich(int maNguoiDung, DateTime tuNgay, DateTime denNgay)
        {
            if (maNguoiDung <= 0) return new List<ChiTietGiaoDich_DTO>();
            if (tuNgay > denNgay)
            {
                DateTime temp = tuNgay;
                tuNgay = denNgay;
                denNgay = temp;
            }

            return ThongKe_DAO.LayChiTietGiaoDichTheoKhoangThoiGian(maNguoiDung, tuNgay, denNgay);
        }

        // 5. Lấy chi tiết giao dịch theo tháng
        public static List<ChiTietGiaoDich_DTO> LayChiTietGiaoDichTheoThang(int maNguoiDung, int thang, int nam)
        {
            if (maNguoiDung <= 0) return new List<ChiTietGiaoDich_DTO>();
            if (thang < 1 || thang > 12) thang = DateTime.Now.Month;
            if (nam < 2000 || nam > 2100) nam = DateTime.Now.Year;

            return ThongKe_DAO.LayChiTietGiaoDichTheoThang(maNguoiDung, thang, nam);
        }

        // 6. Lấy chi tiết giao dịch theo năm
        public static List<ChiTietGiaoDich_DTO> LayChiTietGiaoDichTheoNam(int maNguoiDung, int nam)
        {
            if (maNguoiDung <= 0) return new List<ChiTietGiaoDich_DTO>();
            if (nam < 2000 || nam > 2100) nam = DateTime.Now.Year;

            return ThongKe_DAO.LayChiTietGiaoDichTheoNam(maNguoiDung, nam);
        }

        // 7. Lấy chi tiết giao dịch theo tuần
        public static List<ChiTietGiaoDich_DTO> LayChiTietGiaoDichTheoTuan(int maNguoiDung, DateTime ngayTrongTuan)
        {
            if (maNguoiDung <= 0) return new List<ChiTietGiaoDich_DTO>();

            return ThongKe_DAO.LayChiTietGiaoDichTheoTuan(maNguoiDung, ngayTrongTuan);
        }

        // 8. Helper: Lấy khoảng thời gian theo loại
        public static (DateTime tuNgay, DateTime denNgay) LayKhoangThoiGianTheoLoai(string loai, DateTime mocThoiGian)
        {
            DateTime tuNgay, denNgay;

            switch (loai)
            {
                case "Theo Tuần":
                    int diff = (7 + (mocThoiGian.DayOfWeek - DayOfWeek.Monday)) % 7;
                    tuNgay = mocThoiGian.AddDays(-diff).Date;
                    denNgay = tuNgay.AddDays(6);
                    break;

                case "Theo Tháng":
                    tuNgay = new DateTime(mocThoiGian.Year, mocThoiGian.Month, 1);
                    denNgay = tuNgay.AddMonths(1).AddDays(-1);
                    break;

                case "Theo Năm":
                    tuNgay = new DateTime(mocThoiGian.Year, 1, 1);
                    denNgay = new DateTime(mocThoiGian.Year, 12, 31);
                    break;

                default:
                    tuNgay = mocThoiGian;
                    denNgay = mocThoiGian;
                    break;
            }

            return (tuNgay, denNgay);
        }
    }
}