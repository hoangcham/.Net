using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    public partial class frm_TKDT_DSDichVu_Cham : Form
    {
        public frm_TKDT_DSDichVu_Cham()
        {
            InitializeComponent();
        }
        DBAccess db = new DBAccess();
        private void frm_TKDT_DSDichVu_Cham_Load(object sender, EventArgs e)
        {
            Data();
        }

        void Data()
        {
            //lấy toàn bộ dữ liệu khách hàng ->Lưới
            DataTable dt = db.TraDanhSachDV();
            //Gán toàn bộ dữ liệu của dt vào lưới
            dtgv_DSDV_Cham.DataSource = dt;
        }

        private void btn_XuatExcel_Cham_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem DataGridView có dữ liệu hay không
            if (dtgv_DSDV_Cham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

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
                excelWorksheet.Name = "DoanhThuDichVu";

                // Duyệt qua DataGridView và xuất dữ liệu vào Excel
                for (int i = 0; i < dtgv_DSDV_Cham.Columns.Count; i++)
                {
                    // Ghi tiêu đề cột vào Excel
                    excelWorksheet.Cells[1, i + 1] = dtgv_DSDV_Cham.Columns[i].HeaderText;
                }

                // Ghi dữ liệu vào Excel
                for (int rowIndex = 0; rowIndex < dtgv_DSDV_Cham.Rows.Count; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < dtgv_DSDV_Cham.Columns.Count; colIndex++)
                    {
                        // Ghi từng cell vào Excel
                        excelWorksheet.Cells[rowIndex + 2, colIndex + 1] = dtgv_DSDV_Cham.Rows[rowIndex].Cells[colIndex].Value?.ToString();
                    }
                }

                // Mở cửa sổ Excel
                excelApp.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra Excel: " + ex.Message);
            }
        }

        private void btn_Thoat_Cham_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
