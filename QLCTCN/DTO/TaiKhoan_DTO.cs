using System;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private int sMaNguoiDung;
        public int SMaNguoiDung
        {
            get { return sMaNguoiDung; }
            set { sMaNguoiDung = value; }
        }

        private string sHoTen;
        public string SHoTen
        {
            get { return sHoTen; }
            set { sHoTen = value; }
        }

        private string sTenDangNhap;
        public string STenDangNhap
        {
            get { return sTenDangNhap; }
            set { sTenDangNhap = value; }
        }

        private string sMatKhau;
        public string SMatKhau
        {
            get { return sMatKhau; }
            set { sMatKhau = value; }
        }

        private string sEmail;
        public string SEmail
        {
            get { return sEmail; }
            set { sEmail = value; }
        }

        private bool sVaiTro; // true: Admin, false: User
        public bool SVaiTro
        {
            get { return sVaiTro; }
            set { sVaiTro = value; }
        }

        private DateTime sNgayTao;
        public DateTime SNgayTao
        {
            get { return sNgayTao; }
            set { sNgayTao = value; }
        }

        // Hỗ trợ hiển thị
        public string TenVaiTro
        {
            get { return sVaiTro ? "Admin" : "Người dùng"; }
        }
    }
}