using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    public partial class frm_TKDT_DTTNam_Cham : Form
    {
        public frm_TKDT_DTTNam_Cham()
        {
            InitializeComponent();
        }
        DBAccess db = new DBAccess();

        private void frm_TKDT_DTTNam_Cham_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu doanh thu theo năm và hiển thị lên DataGridView
            DataTable dt = GetDoanhThuTheoNam();
            if (dt.Rows.Count > 0)
            {
                dtgv_DTTN_Cham.DataSource = dt; // Gán dữ liệu cho DataGridView
            }
            else
            {
                MessageBox.Show("Không có dữ liệu doanh thu.");
            }
        }

        // Phương thức để lấy doanh thu theo năm
        private DataTable GetDoanhThuTheoNam()
        {
            DataTable dt = new DataTable();

            string query = @"
            DECLARE @NamList AS TABLE (Nam INT);
                INSERT INTO @NamList (Nam) VALUES (2023), (2024), (2025);
                SELECT MONTH(NgayTraPhong) AS Thang, 
                       SUM(ThanhTien) AS DoanhThu
                FROM HoaDon
                WHERE DaThanhToan = 1 
                      AND YEAR(NgayTraPhong) IN (SELECT Nam FROM @NamList)
                GROUP BY MONTH(NgayTraPhong)
                ORDER BY Thang;
                ";

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                db.MoCSDL();

                // Sử dụng SqlDataAdapter để thực thi truy vấn
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetConnection());

                // Điền dữ liệu vào DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy xuất dữ liệu: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối cơ sở dữ liệu
                db.DongCSDL();
            }

            return dt;
        }

        private void btn_XuatExcel_Cham_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu doanh thu theo năm và hiển thị lên DataGridView
            DataTable dt = GetDoanhThuTheoNam();
            if (dt.Rows.Count > 0)
            {
                dtgv_DTTN_Cham.DataSource = dt; // Gán dữ liệu cho DataGridView
            }
            else
            {
                MessageBox.Show("Không có dữ liệu doanh thu.");
            }
            // Kiểm tra xem DataGridView có dữ liệu hay không
            if (dtgv_DTTN_Cham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }
            // Đặt DataTable vào DataGridView
            dtgv_DTTN_Cham.DataSource = dt;

            // Tạo đối tượng Excel Application
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel không được cài đặt trên hệ thống này.");
                return;
            }

            try
            {
                // Tạo một Workbook mới
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                // Đặt tên cho worksheet
                excelWorksheet.Name = "DoanhThuPhong";

                // Duyệt qua DataGridView và xuất dữ liệu vào Excel
                for (int i = 0; i < dtgv_DTTN_Cham.Columns.Count; i++)
                {
                    // Ghi tiêu đề cột vào Excel
                    excelWorksheet.Cells[1, i + 1] = dtgv_DTTN_Cham.Columns[i].HeaderText;
                }

                // Ghi dữ liệu vào Excel
                for (int rowIndex = 0; rowIndex < dtgv_DTTN_Cham.Rows.Count; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < dtgv_DTTN_Cham.Columns.Count; colIndex++)
                    {
                        // Ghi từng cell vào Excel
                        excelWorksheet.Cells[rowIndex + 2, colIndex + 1] = dtgv_DTTN_Cham.Rows[rowIndex].Cells[colIndex].Value?.ToString();
                    }
                }

                // Mở cửa sổ Excel
                excelApp.Visible = true;

                // Lưu file Excel (có thể thay đổi đường dẫn và tên file theo ý muốn)
                // string filePath = @"C:\DoanhThuPhong.xlsx"; // Ví dụ đường dẫn
                // excelWorkbook.SaveAs(filePath); // Lưu file
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra Excel: " + ex.Message);
            }
            finally
            {
                // Giải phóng tài nguyên
                // excelApp.Quit();
            }

        }

        private void btn_Thoat_Cham_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
