using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class HangMuc_DAO
    {
        // Lấy danh sách hạng mục theo người dùng
        public static List<HangMuc_DTO> LayHangMuc(int maNguoiDung)
        {
            string sTruyVan = "SELECT * FROM HangMuc WHERE MaNguoiDung = @maND";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maND", maNguoiDung)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            List<HangMuc_DTO> list = new List<HangMuc_DTO>();

            foreach (DataRow row in dt.Rows)
            {
                HangMuc_DTO hm = new HangMuc_DTO();
                hm.SMaHangMuc = Convert.ToInt32(row["MaHangMuc"]);
                hm.STenHangMuc = row["TenHangMuc"].ToString();
                hm.SLoaiHangMuc = row["LoaiHangMuc"].ToString();
                hm.SHanMuc = row["HanMuc"] == DBNull.Value ? 0 : Convert.ToDecimal(row["HanMuc"]);
                hm.SMaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]);
                list.Add(hm);
            }

            return list;
        }

        // Lấy hạng mục theo mã
        public static HangMuc_DTO LayHangMucTheoMa(int maHangMuc, int maNguoiDung)
        {
            string sTruyVan = "SELECT * FROM HangMuc WHERE MaHangMuc = @maHM AND MaNguoiDung = @maND";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maHM", maHangMuc),
                new SqlParameter("@maND", maNguoiDung)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            if (dt.Rows.Count == 0) return null;

            HangMuc_DTO hm = new HangMuc_DTO();
            hm.SMaHangMuc = Convert.ToInt32(dt.Rows[0]["MaHangMuc"]);
            hm.STenHangMuc = dt.Rows[0]["TenHangMuc"].ToString();
            hm.SLoaiHangMuc = dt.Rows[0]["LoaiHangMuc"].ToString();
            hm.SHanMuc = dt.Rows[0]["HanMuc"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[0]["HanMuc"]);
            hm.SMaNguoiDung = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);

            return hm;
        }

        // Thêm hạng mục
        public static bool ThemHangMuc(HangMuc_DTO hm)
        {
            string sTruyVan = @"
                INSERT INTO HangMuc (TenHangMuc, LoaiHangMuc, HanMuc, MaNguoiDung) 
                VALUES (@ten, @loai, @hanmuc, @maND)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ten", hm.STenHangMuc),
                new SqlParameter("@loai", hm.SLoaiHangMuc),
                new SqlParameter("@hanmuc", hm.SHanMuc),
                new SqlParameter("@maND", hm.SMaNguoiDung)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Xóa hạng mục
        public static bool XoaHangMuc(int maHangMuc)
        {
            string sTruyVan = "DELETE FROM HangMuc WHERE MaHangMuc = @maHM";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maHM", maHangMuc)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Sửa hạng mục
        public static bool SuaHangMuc(HangMuc_DTO hm)
        {
            string sTruyVan = @"
                UPDATE HangMuc 
                SET TenHangMuc = @ten, LoaiHangMuc = @loai, HanMuc = @hanmuc 
                WHERE MaHangMuc = @maHM";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ten", hm.STenHangMuc),
                new SqlParameter("@loai", hm.SLoaiHangMuc),
                new SqlParameter("@hanmuc", hm.SHanMuc),
                new SqlParameter("@maHM", hm.SMaHangMuc)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Tìm hạng mục theo tên
        public static HangMuc_DTO TimHangMucTheoTen(string tenHangMuc, int maNguoiDung)
        {
            string sTruyVan = "SELECT TOP 1 * FROM HangMuc WHERE TenHangMuc = @ten AND MaNguoiDung = @maND";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ten", tenHangMuc),
                new SqlParameter("@maND", maNguoiDung)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            if (dt.Rows.Count == 0) return null;

            HangMuc_DTO hm = new HangMuc_DTO();
            hm.SMaHangMuc = Convert.ToInt32(dt.Rows[0]["MaHangMuc"]);
            hm.STenHangMuc = dt.Rows[0]["TenHangMuc"].ToString();
            hm.SLoaiHangMuc = dt.Rows[0]["LoaiHangMuc"].ToString();
            hm.SHanMuc = dt.Rows[0]["HanMuc"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[0]["HanMuc"]);
            hm.SMaNguoiDung = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);

            return hm;
        }
    }
}