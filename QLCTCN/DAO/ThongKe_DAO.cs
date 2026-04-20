using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ThongKe_DAO
    {
        // 1. Thống kê theo hạng mục trong tháng/năm
        public static List<ThongKeHangMuc_DTO> ThongKeTheoHangMuc(int maNguoiDung, int thang, int nam)
        {
            string sTruyVan = @"
                SELECT 
                    hm.TenHangMuc,
                    hm.LoaiHangMuc,
                    SUM(CASE WHEN hm.LoaiHangMuc = N'Thu' THEN gd.SoTien ELSE 0 END) AS TongThu,
                    SUM(CASE WHEN hm.LoaiHangMuc = N'Chi' THEN gd.SoTien ELSE 0 END) AS TongChi,
                    COUNT(gd.MaGiaoDich) AS SoLuongGiaoDich
                FROM HangMuc hm
                LEFT JOIN GiaoDich gd ON hm.MaHangMuc = gd.MaHangMuc 
                    AND gd.MaNguoiDung = @maND
                    AND MONTH(gd.NgayGiaoDich) = @thang 
                    AND YEAR(gd.NgayGiaoDich) = @nam
                WHERE hm.MaNguoiDung = @maND
                GROUP BY hm.TenHangMuc, hm.LoaiHangMuc
                ORDER BY TongChi DESC, TongThu DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maND", maNguoiDung),
                new SqlParameter("@thang", thang),
                new SqlParameter("@nam", nam)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);
            List<ThongKeHangMuc_DTO> list = new List<ThongKeHangMuc_DTO>();

            foreach (DataRow row in dt.Rows)
            {
                ThongKeHangMuc_DTO item = new ThongKeHangMuc_DTO();
                item.TenHangMuc = row["TenHangMuc"].ToString();
                item.LoaiHangMuc = row["LoaiHangMuc"].ToString();
                item.TongThu = row["TongThu"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TongThu"]);
                item.TongChi = row["TongChi"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TongChi"]);
                item.SoLuongGiaoDich = row["SoLuongGiaoDich"] == DBNull.Value ? 0 : Convert.ToInt32(row["SoLuongGiaoDich"]);
                list.Add(item);
            }

            return list;
        }

        // 2. Thống kê theo tháng trong năm
        public static List<ThongKeTheoThang_DTO> ThongKeTheoThangTrongNam(int maNguoiDung, int nam)
        {
            string sTruyVan = @"
                SELECT 
                    MONTH(gd.NgayGiaoDich) AS Thang,
                    YEAR(gd.NgayGiaoDich) AS Nam,
                    SUM(CASE WHEN hm.LoaiHangMuc = N'Thu' THEN gd.SoTien ELSE 0 END) AS TongThu,
                    SUM(CASE WHEN hm.LoaiHangMuc = N'Chi' THEN gd.SoTien ELSE 0 END) AS TongChi
                FROM GiaoDich gd
                INNER JOIN HangMuc hm ON gd.MaHangMuc = hm.MaHangMuc
                WHERE gd.MaNguoiDung = @maND AND YEAR(gd.NgayGiaoDich) = @nam
                GROUP BY MONTH(gd.NgayGiaoDich), YEAR(gd.NgayGiaoDich)
                ORDER BY Thang";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maND", maNguoiDung),
                new SqlParameter("@nam", nam)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);
            List<ThongKeTheoThang_DTO> list = new List<ThongKeTheoThang_DTO>();

            // Tạo đủ 12 tháng (kể cả tháng không có dữ liệu)
            for (int i = 1; i <= 12; i++)
            {
                ThongKeTheoThang_DTO item = new ThongKeTheoThang_DTO();
                item.Thang = i;
                item.Nam = nam;
                item.TongThu = 0;
                item.TongChi = 0;
                item.ChenhLech = 0;
                list.Add(item);
            }

            // Cập nhật dữ liệu từ database
            foreach (DataRow row in dt.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                ThongKeTheoThang_DTO item = list.Find(x => x.Thang == thang);
                if (item != null)
                {
                    item.TongThu = row["TongThu"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TongThu"]);
                    item.TongChi = row["TongChi"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TongChi"]);
                    item.ChenhLech = item.TongThu - item.TongChi;
                }
            }

            return list;
        }

        // 3. Thống kê theo khoảng thời gian (tổng hợp)
        public static ThongKeKhoangThoiGian_DTO ThongKeTheoKhoangThoiGian(int maNguoiDung, DateTime tuNgay, DateTime denNgay)
        {
            string sTruyVan = @"
                SELECT 
                    SUM(CASE WHEN hm.LoaiHangMuc = N'Thu' THEN gd.SoTien ELSE 0 END) AS TongThu,
                    SUM(CASE WHEN hm.LoaiHangMuc = N'Chi' THEN gd.SoTien ELSE 0 END) AS TongChi
                FROM GiaoDich gd
                INNER JOIN HangMuc hm ON gd.MaHangMuc = hm.MaHangMuc
                WHERE gd.MaNguoiDung = @maND 
                    AND gd.NgayGiaoDich >= @tuNgay 
                    AND gd.NgayGiaoDich <= @denNgay";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maND", maNguoiDung),
                new SqlParameter("@tuNgay", tuNgay),
                new SqlParameter("@denNgay", denNgay)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            ThongKeKhoangThoiGian_DTO result = new ThongKeKhoangThoiGian_DTO();
            result.TuNgay = tuNgay;
            result.DenNgay = denNgay;

            if (dt.Rows.Count > 0 && dt.Rows[0]["TongThu"] != DBNull.Value)
            {
                result.TongThu = Convert.ToDecimal(dt.Rows[0]["TongThu"]);
                result.TongChi = Convert.ToDecimal(dt.Rows[0]["TongChi"]);
            }
            else
            {
                result.TongThu = 0;
                result.TongChi = 0;
            }

            return result;
        }

        // 4. Lấy chi tiết giao dịch theo khoảng thời gian
        public static List<ChiTietGiaoDich_DTO> LayChiTietGiaoDichTheoKhoangThoiGian(int maNguoiDung, DateTime tuNgay, DateTime denNgay)
        {
            string sTruyVan = @"
                SELECT 
                    gd.NgayGiaoDich,
                    hm.TenHangMuc,
                    nt.TenNguonTien,
                    gd.SoTien,
                    gd.MoTa,
                    hm.LoaiHangMuc
                FROM GiaoDich gd
                INNER JOIN HangMuc hm ON gd.MaHangMuc = hm.MaHangMuc
                INNER JOIN NguonTien nt ON gd.MaNguonTien = nt.MaNguonTien
                WHERE gd.MaNguoiDung = @maND 
                    AND gd.NgayGiaoDich >= @tuNgay 
                    AND gd.NgayGiaoDich <= @denNgay
                ORDER BY gd.NgayGiaoDich DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maND", maNguoiDung),
                new SqlParameter("@tuNgay", tuNgay),
                new SqlParameter("@denNgay", denNgay)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);
            List<ChiTietGiaoDich_DTO> list = new List<ChiTietGiaoDich_DTO>();

            foreach (DataRow row in dt.Rows)
            {
                ChiTietGiaoDich_DTO item = new ChiTietGiaoDich_DTO();
                item.NgayGiaoDich = Convert.ToDateTime(row["NgayGiaoDich"]);
                item.TenHangMuc = row["TenHangMuc"].ToString();
                item.TenNguonTien = row["TenNguonTien"].ToString();
                item.MoTa = row["MoTa"] == DBNull.Value ? "" : row["MoTa"].ToString();
                item.Loai = row["LoaiHangMuc"].ToString();

                if (item.Loai == "Thu")
                {
                    item.SoTienThu = Convert.ToDecimal(row["SoTien"]);
                    item.SoTienChi = 0;
                }
                else
                {
                    item.SoTienThu = 0;
                    item.SoTienChi = Convert.ToDecimal(row["SoTien"]);
                }

                list.Add(item);
            }

            return list;
        }

        // 5. Lấy chi tiết giao dịch theo tháng
        public static List<ChiTietGiaoDich_DTO> LayChiTietGiaoDichTheoThang(int maNguoiDung, int thang, int nam)
        {
            DateTime tuNgay = new DateTime(nam, thang, 1);
            DateTime denNgay = tuNgay.AddMonths(1).AddDays(-1);
            return LayChiTietGiaoDichTheoKhoangThoiGian(maNguoiDung, tuNgay, denNgay);
        }

        // 6. Lấy chi tiết giao dịch theo năm
        public static List<ChiTietGiaoDich_DTO> LayChiTietGiaoDichTheoNam(int maNguoiDung, int nam)
        {
            DateTime tuNgay = new DateTime(nam, 1, 1);
            DateTime denNgay = new DateTime(nam, 12, 31);
            return LayChiTietGiaoDichTheoKhoangThoiGian(maNguoiDung, tuNgay, denNgay);
        }

        // 7. Lấy chi tiết giao dịch theo tuần
        public static List<ChiTietGiaoDich_DTO> LayChiTietGiaoDichTheoTuan(int maNguoiDung, DateTime ngayTrongTuan)
        {
            // Tuần bắt đầu từ thứ 2
            int diff = (7 + (ngayTrongTuan.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime tuNgay = ngayTrongTuan.AddDays(-diff).Date;
            DateTime denNgay = tuNgay.AddDays(6);
            return LayChiTietGiaoDichTheoKhoangThoiGian(maNguoiDung, tuNgay, denNgay);
        }
    }
}