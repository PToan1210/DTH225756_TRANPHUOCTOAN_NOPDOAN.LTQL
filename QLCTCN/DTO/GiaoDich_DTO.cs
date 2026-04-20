using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoDich_DTO
    {
        private int sMaGiaoDich;
        public int SMaGiaoDich
        {
            get { return sMaGiaoDich; }
            set { sMaGiaoDich = value; }
        }

        private DateTime sNgayGiaoDich;
        public DateTime SNgayGiaoDich
        {
            get { return sNgayGiaoDich; }
            set { sNgayGiaoDich = value; }
        }

        private decimal sSoTien;
        public decimal SSoTien
        {
            get { return sSoTien; }
            set { sSoTien = value; }
        }

        private string sMoTa;
        public string SMoTa
        {
            get { return sMoTa; }
            set { sMoTa = value; }
        }

        private int sMaNguoiDung;
        public int SMaNguoiDung
        {
            get { return sMaNguoiDung; }
            set { sMaNguoiDung = value; }
        }

        private int sMaNguonTien;
        public int SMaNguonTien
        {
            get { return sMaNguonTien; }
            set { sMaNguonTien = value; }
        }

        private int sMaHangMuc;
        public int SMaHangMuc
        {
            get { return sMaHangMuc; }
            set { sMaHangMuc = value; }
        }

        // Các trường hỗ trợ hiển thị (từ JOIN)
        private string sTenHangMuc;
        public string STenHangMuc
        {
            get { return sTenHangMuc; }
            set { sTenHangMuc = value; }
        }

        private string sTenNguonTien;
        public string STenNguonTien
        {
            get { return sTenNguonTien; }
            set { sTenNguonTien = value; }
        }

        private decimal sHanMuc;
        public decimal SHanMuc
        {
            get { return sHanMuc; }
            set { sHanMuc = value; }
        }
    }
}