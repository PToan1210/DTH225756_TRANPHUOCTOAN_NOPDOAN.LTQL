using DTO;
using DAO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        
        public static List<TaiKhoan_DTO> LayDanhSachNguoiDung()
        {
            return TaiKhoan_DAO.LayDanhSachNguoiDung();
        }


        public static TaiKhoan_DTO LayNguoiDungTheoMa(int maNguoiDung)
        {
            if (maNguoiDung <= 0) return null;
            return TaiKhoan_DAO.LayNguoiDungTheoMa(maNguoiDung);
        }

     
        public static TaiKhoan_DTO KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
                return null;
            return TaiKhoan_DAO.KiemTraDangNhap(tenDangNhap, matKhau);
        }
        public static bool DangKy(TaiKhoan_DTO tk, string matKhau, string xacNhanMatKhau)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(tk.SHoTen))
                throw new Exception("Vui lòng nhập họ tên!");

            if (string.IsNullOrWhiteSpace(tk.STenDangNhap))
                throw new Exception("Vui lòng nhập tên đăng nhập!");

            if (string.IsNullOrWhiteSpace(matKhau))
                throw new Exception("Vui lòng nhập mật khẩu!");

            if (matKhau.Length < 6)
                throw new Exception("Mật khẩu phải có ít nhất 6 ký tự!");

            if (matKhau != xacNhanMatKhau)
                throw new Exception("Mật khẩu xác nhận không khớp!");


            if (TaiKhoan_DAO.KiemTraTonTaiTenDangNhap(tk.STenDangNhap))
                throw new Exception("Tên đăng nhập đã tồn tại!");

            return TaiKhoan_DAO.DangKy(tk, matKhau);
        }
        public static bool ThemNguoiDung(TaiKhoan_DTO tk, string matKhau)
        {

            if (string.IsNullOrWhiteSpace(tk.SHoTen))
                throw new Exception("Họ tên không được để trống!");

            if (string.IsNullOrWhiteSpace(tk.STenDangNhap))
                throw new Exception("Tên đăng nhập không được để trống!");

            if (string.IsNullOrWhiteSpace(matKhau))
                throw new Exception("Mật khẩu không được để trống!");

            if (matKhau.Length < 6)
                throw new Exception("Mật khẩu phải có ít nhất 6 ký tự!");

            if (TaiKhoan_DAO.KiemTraTonTaiTenDangNhap(tk.STenDangNhap))
                throw new Exception("Tên đăng nhập đã tồn tại!");

            return TaiKhoan_DAO.ThemNguoiDung(tk, matKhau);
        }

        public static bool SuaNguoiDung(TaiKhoan_DTO tk)
        {
            if (string.IsNullOrWhiteSpace(tk.SHoTen))
                throw new Exception("Họ tên không được để trống!");

            if (TaiKhoan_DAO.KiemTraTonTaiTenDangNhap(tk.STenDangNhap, tk.SMaNguoiDung))
                throw new Exception("Tên đăng nhập đã tồn tại!");

            return TaiKhoan_DAO.SuaNguoiDung(tk);
        }

        public static bool DoiMatKhau(int maNguoiDung, string matKhauCu, string matKhauMoi, string xacNhanMatKhau)
        {
            if (string.IsNullOrWhiteSpace(matKhauCu))
                throw new Exception("Vui lòng nhập mật khẩu cũ!");

            if (string.IsNullOrWhiteSpace(matKhauMoi))
                throw new Exception("Vui lòng nhập mật khẩu mới!");

            if (matKhauMoi.Length < 6)
                throw new Exception("Mật khẩu mới phải có ít nhất 6 ký tự!");

            if (matKhauMoi != xacNhanMatKhau)
                throw new Exception("Xác nhận mật khẩu không khớp!");

            var tk = TaiKhoan_DAO.LayNguoiDungTheoMa(maNguoiDung);
            if (tk == null || tk.SMatKhau != matKhauCu)
                throw new Exception("Mật khẩu cũ không đúng!");

            return TaiKhoan_DAO.DoiMatKhau(maNguoiDung, matKhauMoi);
        }

        public static bool XoaNguoiDung(int maNguoiDung)
        {
            return TaiKhoan_DAO.XoaNguoiDung(maNguoiDung);
        }


        public static List<TaiKhoan_DTO> TimKiemNguoiDung(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
                return LayDanhSachNguoiDung();
            return TaiKhoan_DAO.TimKiemNguoiDung(tuKhoa);
        }
    }
}