using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace GUI
{
    public class ExportExcelHelper
    {
        public static void XuatExcel(DataTable dt, string tenFile, string tieuDe = "")
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.Title = "Xuất báo cáo Excel";
                sfd.DefaultExt = "xlsx";
                sfd.FileName = $"{tenFile}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Báo cáo");

                            int currentRow = 1;

                            // ========== TIÊU ĐỀ ==========
                            if (!string.IsNullOrEmpty(tieuDe))
                            {
                                string[] lines = tieuDe.Split('\n');
                                for (int i = 0; i < lines.Length; i++)
                                {
                                    worksheet.Cells[currentRow, 1].Value = lines[i];
                                    worksheet.Cells[currentRow, 1, currentRow, dt.Columns.Count].Merge = true;
                                    worksheet.Cells[currentRow, 1, currentRow, dt.Columns.Count].Style.Font.Size = 14;
                                    worksheet.Cells[currentRow, 1, currentRow, dt.Columns.Count].Style.Font.Bold = true;
                                    worksheet.Cells[currentRow, 1, currentRow, dt.Columns.Count].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                    currentRow++;
                                }
                                currentRow++; // Dòng trống
                            }

                            // ========== HEADER ==========
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                worksheet.Cells[currentRow, i + 1].Value = dt.Columns[i].ColumnName;
                                worksheet.Cells[currentRow, i + 1].Style.Font.Bold = true;
                                worksheet.Cells[currentRow, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                worksheet.Cells[currentRow, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                                worksheet.Cells[currentRow, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                worksheet.Cells[currentRow, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }
                            currentRow++;

                            // ========== DỮ LIỆU ==========
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    object value = dt.Rows[i][j];
                                    string stringValue = value?.ToString() ?? "";

                                    worksheet.Cells[currentRow + i, j + 1].Value = stringValue;
                                    worksheet.Cells[currentRow + i, j + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);

                                    // Căn phải cho cột số tiền
                                    if (dt.Columns[j].ColumnName.Contains("tiền") ||
                                        dt.Columns[j].ColumnName.Contains("Tiền") ||
                                        dt.Columns[j].ColumnName.Contains("thu") ||
                                        dt.Columns[j].ColumnName.Contains("chi") ||
                                        dt.Columns[j].ColumnName.Contains("THU") ||
                                        dt.Columns[j].ColumnName.Contains("CHI"))
                                    {
                                        worksheet.Cells[currentRow + i, j + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                                    }
                                }
                            }

                            // ========== TỰ ĐỘNG RESIZE ==========
                            worksheet.Cells.AutoFitColumns();

                            // ========== ĐÓNG BĂNG (FREEZE) DÒNG TIÊU ĐỀ ==========
                            worksheet.View.FreezePanes(currentRow, 1);

                            // Lưu file
                            FileInfo excelFile = new FileInfo(sfd.FileName);
                            package.SaveAs(excelFile);
                        }

                        MessageBox.Show($"Xuất Excel thành công!\nĐường dẫn: {sfd.FileName}",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi xuất Excel: {ex.Message}", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}