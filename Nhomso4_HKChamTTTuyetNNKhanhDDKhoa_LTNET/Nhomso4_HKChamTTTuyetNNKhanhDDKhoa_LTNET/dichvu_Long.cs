using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    public partial class dichvu_Long : Form
    {
        private int maHoaDon;
        public dichvu_Long()
        {
            InitializeComponent();
        }
        private readonly string path = @"Data Source=DESKTOP-8LMO6HU\KIMCHAM;Initial Catalog=QLKhachSan;Integrated Security=True; ";
        private void dichvu_Long_Load(object sender, EventArgs e)
        {
            load();
            using (SqlConnection con = new SqlConnection(path))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY MaHoaDon DESC";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        maHoaDon = Convert.ToInt32(reader["MaHoaDon"]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy MaHoaDon: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void load()
        {

            SqlConnection con = new SqlConnection(path);
            con.Open();
            string qr = " SELECT * FROM DichVu";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qr, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgv1.DataSource = dataTable;
            {
                dgv1.Columns[0].AutoSizeMode =
      DataGridViewAutoSizeColumnMode.AllCells;
                dgv1.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                dgv1.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;

                dgv1.Columns[0].HeaderText = "Mã Dịch Vụ ";
                dgv1.Columns[1].HeaderText = "Tên Dịch vụ";
                dgv1.Columns[2].HeaderText = "Giá Dịch Vụ";


                dgv1.ReadOnly = true;
                dgv1.MultiSelect = false;
                dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv1.AllowUserToAddRows = false;
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong dgv1 không
            if (dgv1.SelectedRows.Count > 0)
            {
                if (dgvgiodichvu.Columns.Count == 0)
                {
                    dgvgiodichvu.Columns.Add("MaDichVu", "Mã Dịch Vụ");
                    dgvgiodichvu.Columns.Add("TenDichVu", "Tên Dịch Vụ");
                    dgvgiodichvu.Columns.Add("DonGia", "Đơn Giá");
                    dgvgiodichvu.Columns.Add("SoLuong", "Số Lượng");
                }
                // Lấy thông tin từ hàng được chọn trong dgv1
                var selectedRow = dgv1.SelectedRows[0];

                // Kiểm tra xem các ô trong dgv1 có giá trị hợp lệ không
                if (selectedRow.Cells[0].Value == null || selectedRow.Cells[1].Value == null || selectedRow.Cells[2].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Nếu có ô null, không tiếp tục
                }

                string maDichVu1 = selectedRow.Cells[0].Value.ToString();
                string tenDichVu = selectedRow.Cells[1].Value.ToString();
                string giaDichVu = selectedRow.Cells[2].Value.ToString();

                // Kiểm tra xem maDichVu1 đã có trong dgv2 chưa
                bool isExist = false;

                foreach (DataGridViewRow row in dgvgiodichvu.Rows)
                {
                    // Kiểm tra giá trị của maDichVu trong dgv2
                    if (row.Cells[0].Value == null) continue; // Bỏ qua các dòng có giá trị null

                    string maDichVu2 = row.Cells[0].Value.ToString();

                    // Nếu maDichVu1 đã có trong dgv2, tăng số lượng
                    if (maDichVu1 == maDichVu2)
                    {
                        // Kiểm tra số lượng
                        if (row.Cells[3].Value != null)
                        {
                            int currentQuantity = Convert.ToInt32(row.Cells[3].Value);
                            row.Cells[3].Value = currentQuantity + 1; // Tăng số lượng lên 1
                        }
                        else
                        {
                            // Nếu không có số lượng, gán mặc định là 1
                            row.Cells[3].Value = 1;
                        }
                        isExist = true;
                        break; // Thoát khỏi vòng lặp khi tìm thấy mã dịch vụ
                    }
                }

                // Nếu maDichVu1 chưa có trong dgv2, thêm mới vào dgv2 với số lượng là 1
                if (!isExist)
                {
                    dgvgiodichvu.Rows.Add(maDichVu1, tenDichVu, giaDichVu, 1); // Thêm hàng mới với số lượng ban đầu là 1
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ để thêm vào giỏ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnsd_Click(object sender, EventArgs e)
        {
            if (dgvgiodichvu.Rows.Count > 0)
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    foreach (DataGridViewRow row in dgvgiodichvu.Rows)
                    {
                        if (row.Cells[0].Value == null) continue; // Bỏ qua các dòng rỗng

                        string maDichVu = row.Cells[0].Value.ToString();
                        string donGia = row.Cells[2].Value.ToString();
                        int soLuong = row.Cells[3].Value != null ? Convert.ToInt32(row.Cells[3].Value) : 0;

                        string query = "INSERT INTO ChiTietHoaDon (MaHoaDon, MaDichVu, DonGia, SoLuong) " +
                                       "VALUES (@MaHoaDon, @MaDichVu, @DonGia, @SoLuong)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);  // Dùng MaHoaDon đã lấy từ bảng tạm
                            cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);
                            cmd.Parameters.AddWithValue("@DonGia", donGia);
                            cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Có lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    MessageBox.Show("Dịch vụ đã được lưu vào chi tiết hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ trong giỏ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoadv_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong dgvgiodichvu không
            if (dgvgiodichvu.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc chắn muốn xóa không
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Lấy hàng đã chọn và xóa nó
                    foreach (DataGridViewRow row in dgvgiodichvu.SelectedRows)
                    {
                        // Xóa dòng đang chọn
                        dgvgiodichvu.Rows.Remove(row);
                    }
                }
            }
            else
            {
                // Thông báo nếu không có dịch vụ nào được chọn
                MessageBox.Show("Vui lòng chọn dịch vụ để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
