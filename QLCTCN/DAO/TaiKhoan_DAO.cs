using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TaiKhoan_DAO
    {
        // Lấy danh sách tất cả người dùng
        public static List<TaiKhoan_DTO> LayDanhSachNguoiDung()
        {
            string sTruyVan = "SELECT * FROM TaiKhoan ORDER BY MaNguoiDung";
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, null);

            List<TaiKhoan_DTO> list = new List<TaiKhoan_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.SMaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]);
                tk.SHoTen = row["HoTen"].ToString();
                tk.STenDangNhap = row["TenDangNhap"].ToString();
                tk.SMatKhau = row["MatKhau"].ToString();
                tk.SEmail = row["Email"] == DBNull.Value ? "" : row["Email"].ToString();
                tk.SVaiTro = Convert.ToBoolean(row["VaiTro"]);
                tk.SNgayTao = Convert.ToDateTime(row["NgayTao"]);
                list.Add(tk);
            }
            return list;
        }

        // Lấy thông tin người dùng theo mã
        public static TaiKhoan_DTO LayNguoiDungTheoMa(int maNguoiDung)
        {
            string sTruyVan = "SELECT * FROM TaiKhoan WHERE MaNguoiDung = @maND";
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@maND", maNguoiDung) };
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            if (dt.Rows.Count == 0) return null;

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.SMaNguoiDung = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);
            tk.SHoTen = dt.Rows[0]["HoTen"].ToString();
            tk.STenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            tk.SMatKhau = dt.Rows[0]["MatKhau"].ToString();
            tk.SEmail = dt.Rows[0]["Email"] == DBNull.Value ? "" : dt.Rows[0]["Email"].ToString();
            tk.SVaiTro = Convert.ToBoolean(dt.Rows[0]["VaiTro"]);
            tk.SNgayTao = Convert.ToDateTime(dt.Rows[0]["NgayTao"]);
            return tk;
        }

        // Kiểm tra đăng nhập
        public static TaiKhoan_DTO KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string sTruyVan = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @tenDN AND MatKhau = @mk";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenDN", tenDangNhap),
                new SqlParameter("@mk", matKhau)
            };
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            if (dt.Rows.Count == 0) return null;

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.SMaNguoiDung = Convert.ToInt32(dt.Rows[0]["MaNguoiDung"]);
            tk.SHoTen = dt.Rows[0]["HoTen"].ToString();
            tk.STenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            tk.SMatKhau = dt.Rows[0]["MatKhau"].ToString();
            tk.SEmail = dt.Rows[0]["Email"] == DBNull.Value ? "" : dt.Rows[0]["Email"].ToString();
            tk.SVaiTro = Convert.ToBoolean(dt.Rows[0]["VaiTro"]);
            tk.SNgayTao = Convert.ToDateTime(dt.Rows[0]["NgayTao"]);
            return tk;
        }

        // Thêm người dùng mới
        public static bool ThemNguoiDung(TaiKhoan_DTO tk, string matKhau)
        {
            string sTruyVan = @"
                INSERT INTO TaiKhoan (HoTen, TenDangNhap, MatKhau, Email, VaiTro) 
                VALUES (@hoten, @tendn, @mk, @email, @vaitro)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@hoten", tk.SHoTen),
                new SqlParameter("@tendn", tk.STenDangNhap),
                new SqlParameter("@mk", matKhau),
                new SqlParameter("@email", string.IsNullOrEmpty(tk.SEmail) ? (object)DBNull.Value : tk.SEmail),
                new SqlParameter("@vaitro", tk.SVaiTro)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Cập nhật thông tin người dùng
        public static bool SuaNguoiDung(TaiKhoan_DTO tk)
        {
            string sTruyVan = @"
                UPDATE TaiKhoan 
                SET HoTen = @hoten, Email = @email, VaiTro = @vaitro 
                WHERE MaNguoiDung = @maND";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@hoten", tk.SHoTen),
                new SqlParameter("@email", string.IsNullOrEmpty(tk.SEmail) ? (object)DBNull.Value : tk.SEmail),
                new SqlParameter("@vaitro", tk.SVaiTro),
                new SqlParameter("@maND", tk.SMaNguoiDung)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Đổi mật khẩu
        public static bool DoiMatKhau(int maNguoiDung, string matKhauMoi)
        {
            string sTruyVan = "UPDATE TaiKhoan SET MatKhau = @mk WHERE MaNguoiDung = @maND";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@mk", matKhauMoi),
                new SqlParameter("@maND", maNguoiDung)
            };
            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Xóa người dùng
        public static bool XoaNguoiDung(int maNguoiDung)
        {
            string sTruyVan = "DELETE FROM TaiKhoan WHERE MaNguoiDung = @maND";
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@maND", maNguoiDung) };
            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Tìm kiếm người dùng
        public static List<TaiKhoan_DTO> TimKiemNguoiDung(string tuKhoa)
        {
            string sTruyVan = @"
                SELECT * FROM TaiKhoan 
                WHERE HoTen LIKE @tuKhoa OR TenDangNhap LIKE @tuKhoa OR Email LIKE @tuKhoa";
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@tuKhoa", "%" + tuKhoa + "%") };
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, parameters);

            List<TaiKhoan_DTO> list = new List<TaiKhoan_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.SMaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]);
                tk.SHoTen = row["HoTen"].ToString();
                tk.STenDangNhap = row["TenDangNhap"].ToString();
                tk.SMatKhau = row["MatKhau"].ToString();
                tk.SEmail = row["Email"] == DBNull.Value ? "" : row["Email"].ToString();
                tk.SVaiTro = Convert.ToBoolean(row["VaiTro"]);
                tk.SNgayTao = Convert.ToDateTime(row["NgayTao"]);
                list.Add(tk);
            }
            return list;
        }
        public static bool DangKy(TaiKhoan_DTO tk, string matKhau)
        {
            string sTruyVan = @"
        INSERT INTO TaiKhoan (HoTen, TenDangNhap, MatKhau, Email, VaiTro) 
        VALUES (@hoten, @tendn, @mk, @email, 0)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@hoten", tk.SHoTen),
        new SqlParameter("@tendn", tk.STenDangNhap),
        new SqlParameter("@mk", matKhau),
        new SqlParameter("@email", string.IsNullOrEmpty(tk.SEmail) ? (object)DBNull.Value : tk.SEmail)
            };

            return DataProvider.TruyVanKhongLayDuLieu(sTruyVan, parameters);
        }

        // Kiểm tra tồn tại tên đăng nhập
        public static bool KiemTraTonTaiTenDangNhap(string tenDangNhap, int? maNguoiDung = null)
        {
            string sTruyVan;
            SqlParameter[] parameters;

            if (maNguoiDung.HasValue)
            {
                sTruyVan = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @tendn AND MaNguoiDung != @maND";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@tendn", tenDangNhap),
                    new SqlParameter("@maND", maNguoiDung.Value)
                };
            }
            else
            {
                sTruyVan = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @tendn";
                parameters = new SqlParameter[] { new SqlParameter("@tendn", tenDangNhap) };
            }

            using (SqlConnection con = DataProvider.MoKetNoi())
            using (SqlCommand cmd = new SqlCommand(sTruyVan, con))
            {
                cmd.Parameters.AddRange(parameters);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}