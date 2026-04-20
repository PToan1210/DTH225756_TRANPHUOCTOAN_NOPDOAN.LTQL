using DTO;
using DAO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class GiaoDich_BUS
    {
        // Thu nhập
        public static List<GiaoDich_DTO> LayThuNhap(int maNguoiDung)
        {
            return GiaoDich_DAO.LayThuNhap(maNguoiDung);
        }

        // Chi tiêu
        public static List<GiaoDich_DTO> LayChiTieu(int maNguoiDung)
        {
            return GiaoDich_DAO.LayChiTieu(maNguoiDung);
        }

        // Thêm giao dịch
        public static bool ThemGiaoDich(GiaoDich_DTO gd, int maNguoiDung)
        {
            // Validation
            if (gd.SSoTien <= 0)
                throw new Exception("Số tiền phải lớn hơn 0!");

            if (gd.SMaHangMuc <= 0)
                throw new Exception("Vui lòng chọn hạng mục!");

            if (gd.SMaNguonTien <= 0)
                throw new Exception("Vui lòng chọn nguồn tiền!");

            // Kiểm tra hạn mức nếu là chi tiêu
            HangMuc_DTO hm = HangMuc_DAO.LayHangMucTheoMa(gd.SMaHangMuc, maNguoiDung);
            if (hm != null && hm.SLoaiHangMuc == "Chi")
            {
                // Lấy tổng chi tiêu trong tháng của hạng mục này
                var dsChi = LayChiTieu(maNguoiDung);
                decimal tongChi = 0;
                foreach (var item in dsChi)
                {
                    if (item.SMaHangMuc == gd.SMaHangMuc &&
                        item.SNgayGiaoDich.Month == DateTime.Now.Month &&
                        item.SNgayGiaoDich.Year == DateTime.Now.Year)
                    {
                        tongChi += item.SSoTien;
                    }
                }

                if (tongChi + gd.SSoTien > hm.SHanMuc && hm.SHanMuc > 0)
                {
                    throw new Exception($"Vượt quá hạn mức! Hạn mức còn lại: {(hm.SHanMuc - tongChi):N0} VND");
                }
            }

            gd.SMaNguoiDung = maNguoiDung;
            gd.SNgayGiaoDich = DateTime.Now;

            return GiaoDich_DAO.ThemGiaoDich(gd);
        }

        // Xóa giao dịch
        public static bool XoaGiaoDich(int maGiaoDich)
        {
            return GiaoDich_DAO.XoaGiaoDich(maGiaoDich);
        }

        // Sửa giao dịch
        public static bool SuaGiaoDich(GiaoDich_DTO gd)
        {
            if (gd.SSoTien <= 0)
                throw new Exception("Số tiền phải lớn hơn 0!");

            return GiaoDich_DAO.SuaGiaoDich(gd);
        }
    }
}