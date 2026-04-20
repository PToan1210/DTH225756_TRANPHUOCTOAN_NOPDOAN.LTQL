using DTO;
using DAO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class HangMuc_BUS
    {
        public static List<HangMuc_DTO> LayHangMuc(int maNguoiDung)
        {
            return HangMuc_DAO.LayHangMuc(maNguoiDung);
        }

        public static List<HangMuc_DTO> LayHangMucTheoLoai(int maNguoiDung, string loai)
        {
            var list = HangMuc_DAO.LayHangMuc(maNguoiDung);
            if (list == null) return new List<HangMuc_DTO>();
            return list.FindAll(h => h.SLoaiHangMuc == loai);
        }

        public static bool ThemHangMuc(HangMuc_DTO hm, int maNguoiDung)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(hm.STenHangMuc))
                throw new Exception("Tên hạng mục không được để trống!");

            if (hm.SLoaiHangMuc != "Thu" && hm.SLoaiHangMuc != "Chi")
                throw new Exception("Loại hạng mục không hợp lệ!");

            if (hm.SLoaiHangMuc == "Chi" && hm.SHanMuc <= 0)
                throw new Exception("Hạn mức phải lớn hơn 0 đối với hạng mục Chi tiêu!");

            // Kiểm tra trùng tên
            if (TimHangMucTheoTen(hm.STenHangMuc, maNguoiDung) != null)
                throw new Exception("Tên hạng mục đã tồn tại!");

            hm.SMaNguoiDung = maNguoiDung;

            return HangMuc_DAO.ThemHangMuc(hm);
        }

        public static bool XoaHangMuc(int maHangMuc)
        {
            return HangMuc_DAO.XoaHangMuc(maHangMuc);
        }

        public static bool SuaHangMuc(HangMuc_DTO hm, int maNguoiDung)
        {
            if (string.IsNullOrWhiteSpace(hm.STenHangMuc))
                throw new Exception("Tên hạng mục không được để trống!");

            hm.SMaNguoiDung = maNguoiDung;

            return HangMuc_DAO.SuaHangMuc(hm);
        }

        public static HangMuc_DTO TimHangMucTheoTen(string ten, int maNguoiDung)
        {
            if (string.IsNullOrWhiteSpace(ten)) return null;
            return HangMuc_DAO.TimHangMucTheoTen(ten, maNguoiDung);
        }
    }
}