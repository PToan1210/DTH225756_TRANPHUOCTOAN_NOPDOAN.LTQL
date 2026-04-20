using DTO;
using DAO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class NguonTien_BUS
    {
        public static List<NguonTien_DTO> LayNguonTien(int maNguoiDung)
        {
            return NguonTien_DAO.LayNguonTien(maNguoiDung);
        }

        public static bool ThemNguonTien(NguonTien_DTO nt, int maNguoiDung)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(nt.STenNguonTien))
                throw new Exception("Tên nguồn tiền không được để trống!");

            if (string.IsNullOrWhiteSpace(nt.SLoaiNguonTien))
                throw new Exception("Vui lòng chọn loại nguồn tiền!");

            // Kiểm tra trùng tên
            if (TimNguonTienTheoTen(nt.STenNguonTien, maNguoiDung) != null)
                throw new Exception("Tên nguồn tiền đã tồn tại!");

            nt.SMaNguoiDung = maNguoiDung;
            nt.SSoDuHienTai = 0; // Số dư ban đầu = 0

            return NguonTien_DAO.ThemNguonTien(nt);
        }

        public static bool XoaNguonTien(int maNguonTien)
        {
            return NguonTien_DAO.XoaNguonTien(maNguonTien);
        }

        public static bool SuaNguonTien(NguonTien_DTO nt)
        {
            if (string.IsNullOrWhiteSpace(nt.STenNguonTien))
                throw new Exception("Tên nguồn tiền không được để trống!");

            return NguonTien_DAO.SuaNguonTien(nt);
        }

        public static NguonTien_DTO TimNguonTienTheoTen(string ten, int maNguoiDung)
        {
            if (string.IsNullOrWhiteSpace(ten)) return null;
            return NguonTien_DAO.TimNguonTienTheoTen(ten, maNguoiDung);
        }

        public static bool CapNhatSoDu(int maNguonTien, decimal soTienThayDoi)
        {
            return NguonTien_DAO.CapNhatSoDu(maNguonTien, soTienThayDoi);
        }
    }
}