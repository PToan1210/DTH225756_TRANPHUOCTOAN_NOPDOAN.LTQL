using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        // Khai báo connection string ở một chỗ để dễ quản lý
        private static string connectionString = @"Data Source=(local);Initial Catalog=QuanLyChiTieu;Integrated Security=True";

        // Phương thức mở kết nối trả về SqlConnection đã mở
        public static SqlConnection MoKetNoi()
        {
            SqlConnection KetNoi = new SqlConnection(connectionString);
            KetNoi.Open();
            return KetNoi;
        }

        // Phương thức đóng kết nối
        public static void DongKetNoi(SqlConnection KetNoi)
        {
            if (KetNoi != null && KetNoi.State == ConnectionState.Open)
            {
                KetNoi.Close();
                KetNoi.Dispose();
            }
        }

        // ========== PHƯƠNG THỨC MỚI - CÓ HỖ TRỢ PARAMETER ==========

        /// <summary>
        /// Thực thi truy vấn SELECT, trả về DataTable
        /// </summary>
        /// <param name="sTruyVan">Câu lệnh SQL (có thể chứa tham số @ten)</param>
        /// <param name="parameters">Mảng SqlParameter (có thể null)</param>
        /// <returns>DataTable chứa kết quả</returns>
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = MoKetNoi())
            {
                using (SqlCommand cmd = new SqlCommand(sTruyVan, con))
                {
                    // Thêm parameters nếu có
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// Thực thi truy vấn INSERT/UPDATE/DELETE
        /// </summary>
        /// <param name="sTruyVan">Câu lệnh SQL (có thể chứa tham số @ten)</param>
        /// <param name="parameters">Mảng SqlParameter (có thể null)</param>
        /// <returns>True nếu thành công, False nếu thất bại</returns>
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection con = MoKetNoi())
                {
                    using (SqlCommand cmd = new SqlCommand(sTruyVan, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi để debug (có thể thay bằng file log)
                System.Diagnostics.Debug.WriteLine("Lỗi SQL: " + ex.Message);
                return false;
            }
        }
    }
}