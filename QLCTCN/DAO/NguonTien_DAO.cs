using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class NguonTien_DAO
    {
        // Lấy danh sách nguồn tiền theo người dùng
        public static List<NguonTien_DTO> LayNguonTien(int maNguoiDung)
        {
            string sTruyVan = "SELECT * FROM NguonTien WHERE MaNguoiDung = @maND";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maND", maNguoiDung)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            List<NguonTien_DTO> list = new List<NguonTien_DTO>();

            foreach (DataRow row in dt.Rows)
            {
                NguonTien_DTO nt = new NguonTien_DTO();
                nt.SMaNguonTien = Convert.ToInt32(row["MaNguonTien"]);
                nt.STenNguonTien = row["TenNguonTien"].ToString();
                nt.SSoDuHienTai = row["SoDuHienTai"] == DBNull.Value ? 0 : Convert.ToDecimal(row["SoDuHienTai"]);
                nt.SLoaiNguonTien = row["LoaiNguonTien"] == DBNull.Value ? "" : row["LoaiNguonTien"].ToString();
                nt.SMaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]);
                list.Add(nt);
            }

            return list;
        }

        // Lấy nguồn tiền theo mã
        public static NguonTien_DTO LayNguonTienTheoMa(int maNguonTien, int maNguoiDung)
        {
            string sTruyVan = "SELECT * FROM NguonTien WHERE MaNguonTien = @maNT AND MaNguoiDung = @maND";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maNT", maNguonTien),
                new SqlParameter("@maND", maNguoiDung)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            if (dt.Rows.Count == 0) return null;

            NguonTien_DTO nt = new NguonTien_DTO();
            nt.SMaNguonTien = Convert.ToInt32(dt.Rows[0]["MaNguonTien"]);
            nt.STenNguonTien = dt.Rows[0]["TenNguonTien"].ToString();
            nt.SSoDuHienTai = dt.Rows[0]["SoDuHienTai"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[0]["SoDuHienTai"]);
            nt.SLoaiNguonTien = dt.Rows[0]["LoaiNguonTien"] == DBNull.Value ? "" : dt.Rows[0]["LoaiNguonTien"].ToString();
            nt.SMaNguoiDung = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);

            return nt;
        }

        // Thêm nguồn tiền
        public static bool ThemNguonTien(NguonTien_DTO nt)
        {
            string sTruyVan = @"
                INSERT INTO NguonTien (TenNguonTien, SoDuHienTai, LoaiNguonTien, MaNguoiDung) 
                VALUES (@ten, @sodu, @loai, @maND)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ten", nt.STenNguonTien),
                new SqlParameter("@sodu", nt.SSoDuHienTai),
                new SqlParameter("@loai", string.IsNullOrEmpty(nt.SLoaiNguonTien) ? (object)DBNull.Value : nt.SLoaiNguonTien),
                new SqlParameter("@maND", nt.SMaNguoiDung)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Xóa nguồn tiền
        public static bool XoaNguonTien(int maNguonTien)
        {
            string sTruyVan = "DELETE FROM NguonTien WHERE MaNguonTien = @maNT";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maNT", maNguonTien)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Sửa nguồn tiền
        public static bool SuaNguonTien(NguonTien_DTO nt)
        {
            string sTruyVan = @"
                UPDATE NguonTien 
                SET TenNguonTien = @ten, LoaiNguonTien = @loai 
                WHERE MaNguonTien = @maNT";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ten", nt.STenNguonTien),
                new SqlParameter("@loai", string.IsNullOrEmpty(nt.SLoaiNguonTien) ? (object)DBNull.Value : nt.SLoaiNguonTien),
                new SqlParameter("@maNT", nt.SMaNguonTien)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Cập nhật số dư (cộng/trừ)
        public static bool CapNhatSoDu(int maNguonTien, decimal soTienThayDoi)
        {
            string sTruyVan = "UPDATE NguonTien SET SoDuHienTai = SoDuHienTai + @sotien WHERE MaNguonTien = @maNT";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@sotien", soTienThayDoi),
                new SqlParameter("@maNT", maNguonTien)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Tìm nguồn tiền theo tên
        public static NguonTien_DTO TimNguonTienTheoTen(string tenNguonTien, int maNguoiDung)
        {
            string sTruyVan = "SELECT TOP 1 * FROM NguonTien WHERE TenNguonTien = @ten AND MaNguoiDung = @maND";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ten", tenNguonTien),
                new SqlParameter("@maND", maNguoiDung)
            };

            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            if (dt.Rows.Count == 0) return null;

            NguonTien_DTO nt = new NguonTien_DTO();
            nt.SMaNguonTien = Convert.ToInt32(dt.Rows[0]["MaNguonTien"]);
            nt.STenNguonTien = dt.Rows[0]["TenNguonTien"].ToString();
            nt.SSoDuHienTai = dt.Rows[0]["SoDuHienTai"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[0]["SoDuHienTai"]);
            nt.SLoaiNguonTien = dt.Rows[0]["LoaiNguonTien"] == DBNull.Value ? "" : dt.Rows[0]["LoaiNguonTien"].ToString();
            nt.SMaNguoiDung = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);

            return nt;
        }
    }
}