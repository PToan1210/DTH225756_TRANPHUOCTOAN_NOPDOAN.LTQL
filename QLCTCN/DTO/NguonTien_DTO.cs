using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguonTien_DTO
    {
        private int sMaNguonTien;
        public int SMaNguonTien
        {
            get { return sMaNguonTien; }
            set { sMaNguonTien = value; }
        }

        private string sTenNguonTien;
        public string STenNguonTien
        {
            get { return sTenNguonTien; }
            set { sTenNguonTien = value; }
        }

        private decimal sSoDuHienTai;
        public decimal SSoDuHienTai
        {
            get { return sSoDuHienTai; }
            set { sSoDuHienTai = value; }
        }

        private string sLoaiNguonTien;
        public string SLoaiNguonTien
        {
            get { return sLoaiNguonTien; }
            set { sLoaiNguonTien = value; }
        }

        private int sMaNguoiDung;
        public int SMaNguoiDung
        {
            get { return sMaNguoiDung; }
            set { sMaNguoiDung = value; }
        }
    }
}