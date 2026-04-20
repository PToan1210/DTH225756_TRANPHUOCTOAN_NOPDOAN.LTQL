using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangMuc_DTO
    {
        private int sMaHangMuc;
        public int SMaHangMuc
        {
            get { return sMaHangMuc; }
            set { sMaHangMuc = value; }
        }

        private string sTenHangMuc;
        public string STenHangMuc
        {
            get { return sTenHangMuc; }
            set { sTenHangMuc = value; }
        }

        private string sLoaiHangMuc; // "Thu" hoặc "Chi"
        public string SLoaiHangMuc
        {
            get { return sLoaiHangMuc; }
            set { sLoaiHangMuc = value; }
        }

        private decimal sHanMuc;
        public decimal SHanMuc
        {
            get { return sHanMuc; }
            set { sHanMuc = value; }
        }

        private int sMaNguoiDung;
        public int SMaNguoiDung
        {
            get { return sMaNguoiDung; }
            set { sMaNguoiDung = value; }
        }
    }
}