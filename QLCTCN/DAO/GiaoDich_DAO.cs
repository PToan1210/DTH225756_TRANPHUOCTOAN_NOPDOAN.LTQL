using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class GiaoDich_DAO
    {
        // Lấy danh sách thu nhập (LoaiHangMuc = 'Thu')
        public static List<GiaoDich_DTO> LayThuNhap(int maNguoiDung)
        {
            string sTruyVan = @"
                SELECT gd.*, hm.TenHangMuc, nt.TenNguonTien, hm.HanMuc
                FROM GiaoDich gd 
                INNER JOIN HangMuc hm ON gd.MaHangMuc = hm.MaHangMuc 
                INNER JOIN NguonTien nt ON nt.MaNguonTien = gd.MaNguonTien 
                WHERE hm.LoaiHangMuc = N'Thu' AND gd.MaNguoiDung = @maND
                ORDER BY gd.NgayGiaoDich DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maND", maNguoiDung)
            };

            return LayDuLieu(sTruyVan, parameters);
        }

        // Lấy danh sách chi tiêu (LoaiHangMuc = 'Chi')
        public static List<GiaoDich_DTO> LayChiTieu(int maNguoiDung)
        {
            string sTruyVan = @"
                SELECT gd.*, hm.TenHangMuc, nt.TenNguonTien, hm.HanMuc
                FROM GiaoDich gd 
                INNER JOIN HangMuc hm ON gd.MaHangMuc = hm.MaHangMuc 
                INNER JOIN NguonTien nt ON nt.MaNguonTien = gd.MaNguonTien 
                WHERE hm.LoaiHangMuc = N'Chi' AND gd.MaNguoiDung = @maND
                ORDER BY gd.NgayGiaoDich DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maND", maNguoiDung)
            };

            return LayDuLieu(sTruyVan, parameters);
        }

        // Hàm xử lý chung
        private static List<GiaoDich_DTO> LayDuLieu(string sTruyVan, SqlParameter[] parameters)
        {
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            List<GiaoDich_DTO> list = new List<GiaoDich_DTO>();

            foreach (DataRow row in dt.Rows)
            {
                GiaoDich_DTO gd = new GiaoDich_DTO();
                gd.SMaGiaoDich = Convert.ToInt32(row["MaGiaoDich"]);
                gd.SNgayGiaoDich = Convert.ToDateTime(row["NgayGiaoDich"]);
                gd.SSoTien = Convert.ToDecimal(row["SoTien"]);
                gd.SMoTa = row["MoTa"] == DBNull.Value ? "" : row["MoTa"].ToString();
                gd.SMaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]);
                gd.SMaNguonTien = Convert.ToInt32(row["MaNguonTien"]);
                gd.SMaHangMuc = Convert.ToInt32(row["MaHangMuc"]);
                gd.STenHangMuc = row["TenHangMuc"].ToString();
                gd.STenNguonTien = row["TenNguonTien"].ToString();
                gd.SHanMuc = row["HanMuc"] == DBNull.Value ? 0 : Convert.ToDecimal(row["HanMuc"]);
                list.Add(gd);
            }

            return list;
        }

        // Thêm giao dịch
        public static bool ThemGiaoDich(GiaoDich_DTO gd)
        {
            string sTruyVan = @"
                INSERT INTO GiaoDich (NgayGiaoDich, SoTien, MoTa, MaNguoiDung, MaNguonTien, MaHangMuc) 
                VALUES (@ngay, @sotien, @mota, @maND, @maNT, @maHM)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ngay", gd.SNgayGiaoDich),
                new SqlParameter("@sotien", gd.SSoTien),
                new SqlParameter("@mota", string.IsNullOrEmpty(gd.SMoTa) ? "" : gd.SMoTa),
                new SqlParameter("@maND", gd.SMaNguoiDung),
                new SqlParameter("@maNT", gd.SMaNguonTien),
                new SqlParameter("@maHM", gd.SMaHangMuc)
            };

            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);

            if (result)
            {
                // Cập nhật số dư nguồn tiền
                // Lấy thông tin hạng mục để biết là Thu hay Chi
                HangMuc_DTO hm = HangMuc_DAO.LayHangMucTheoMa(gd.SMaHangMuc, gd.SMaNguoiDung);
                if (hm != null)
                {
                    if (hm.SLoaiHangMuc == "Thu")
                    {
                        // Thu: tăng số dư
                        NguonTien_DAO.CapNhatSoDu(gd.SMaNguonTien, gd.SSoTien);
                    }
                    else if (hm.SLoaiHangMuc == "Chi")
                    {
                        // Chi: giảm số dư
                        NguonTien_DAO.CapNhatSoDu(gd.SMaNguonTien, -gd.SSoTien);
                    }
                }
            }

            return result;
        }

        // Xóa giao dịch
        public static bool XoaGiaoDich(int maGiaoDich)
        {
            string sTruyVan = "DELETE FROM GiaoDich WHERE MaGiaoDich = @maGD";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maGD", maGiaoDich)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Sửa giao dịch
        public static bool SuaGiaoDich(GiaoDich_DTO gd)
        {
            string sTruyVan = @"
                UPDATE GiaoDich 
                SET NgayGiaoDich = @ngay, SoTien = @sotien, MoTa = @mota, 
                    MaNguonTien = @maNT, MaHangMuc = @maHM 
                WHERE MaGiaoDich = @maGD";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ngay", gd.SNgayGiaoDich),
                new SqlParameter("@sotien", gd.SSoTien),
                new SqlParameter("@mota", gd.SMoTa),
                new SqlParameter("@maNT", gd.SMaNguonTien),
                new SqlParameter("@maHM", gd.SMaHangMuc),
                new SqlParameter("@maGD", gd.SMaGiaoDich)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }
    }
}