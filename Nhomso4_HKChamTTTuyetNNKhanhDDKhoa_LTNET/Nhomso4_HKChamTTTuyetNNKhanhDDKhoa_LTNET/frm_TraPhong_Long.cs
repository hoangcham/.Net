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
    public partial class frm_TraPhong_Long : Form
    {
        public frm_TraPhong_Long()
        {
            InitializeComponent();
        }
        private readonly string path = @"Data Source=DESKTOP-8LMO6HU\KIMCHAM;Initial Catalog=QLKhachSan;Integrated Security=True; ";
        private void frm_TraPhong_Long_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            // Chỉ lấy các phòng có DaThanhToan = 1 (hoặc TRUE)
            string qr = "SELECT [MaHoaDon], [MaKhachHang], [MaNhanVien], [GiaPhongMotNgay], [MaPhong], [NgayThuePhong], [NgayTraPhong], [ThanhTien], [DaThanhToan] FROM HoaDon WHERE DaThanhToan = 0";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qr, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvtraphong.DataSource = dataTable;
            con.Close();
            {
                dgvtraphong.Columns[0].AutoSizeMode =
      DataGridViewAutoSizeColumnMode.AllCells;
                dgvtraphong.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                dgvtraphong.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                dgvtraphong.Columns[3].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                dgvtraphong.Columns[4].AutoSizeMode =
                   DataGridViewAutoSizeColumnMode.AllCells;
                dgvtraphong.Columns[5].AutoSizeMode =
                  DataGridViewAutoSizeColumnMode.AllCells;
                dgvtraphong.Columns[6].AutoSizeMode =
                  DataGridViewAutoSizeColumnMode.AllCells;
                dgvtraphong.Columns[7].AutoSizeMode =
                  DataGridViewAutoSizeColumnMode.AllCells;
                dgvtraphong.Columns[8].AutoSizeMode =
                   DataGridViewAutoSizeColumnMode.Fill;




                dgvtraphong.Columns[0].HeaderText = "Mã Hóa Đơn ";
                dgvtraphong.Columns[1].HeaderText = "Mã Khách Hàng ";
                dgvtraphong.Columns[2].HeaderText = "Nhân Viên ";
                dgvtraphong.Columns[3].HeaderText = "Giá Phòng một Ngày";
                dgvtraphong.Columns[4].HeaderText = "Mã Phòng ";
                dgvtraphong.Columns[5].HeaderText = " Ngày Thuê phòng";
                dgvtraphong.Columns[6].HeaderText = "Ngày Trả Phòng ";
                dgvtraphong.Columns[7].HeaderText = "Thành Tiền ";
                dgvtraphong.Columns[8].HeaderText = "Đã Thanh Toán ";


                dgvtraphong.ReadOnly = true;
                dgvtraphong.MultiSelect = false;
                dgvtraphong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvtraphong.AllowUserToAddRows = false;
            }
        }
        private decimal TinhTongTienDichVu(int maHoaDon)
        {
            decimal tongTienDichVu = 0;

            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                // Tính tổng tiền dịch vụ cho hóa đơn được chọn
                string query = "SELECT SUM(SoLuong * DonGia) AS TongTienDichVu FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                // Thực thi truy vấn và lấy kết quả
                var result = cmd.ExecuteScalar();
                tongTienDichVu = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }

            return tongTienDichVu;
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (dgvtraphong.SelectedRows.Count > 0)
            {
                // Lấy thông tin từ DataGridView
                int maHoaDon = Convert.ToInt32(dgvtraphong.SelectedRows[0].Cells["MaHoaDon"].Value);
                DateTime ngayThuePhong = Convert.ToDateTime(dgvtraphong.SelectedRows[0].Cells["NgayThuePhong"].Value);
                decimal giaPhongMotNgay = Convert.ToDecimal(dgvtraphong.SelectedRows[0].Cells["GiaPhongMotNgay"].Value);

                // Lấy ngày trả phòng từ hệ thống (ngày hiện tại)
                DateTime ngayTraPhong = DateTime.Now;

                // Kiểm tra ngày trả phòng hợp lệ
                if (ngayTraPhong < ngayThuePhong)
                {
                    MessageBox.Show("Ngày trả phòng không hợp lệ (trước ngày thuê phòng).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tính số ngày thuê: Ngày trả - Ngày thuê + 1
                int soNgayThue = (int)(ngayTraPhong - ngayThuePhong).TotalDays + 1;

                // Tính tổng tiền thuê phòng
                decimal tongTienThuePhong = giaPhongMotNgay * soNgayThue;

                // Tính tổng tiền dịch vụ
                decimal tongTienDichVu = TinhTongTienDichVu(maHoaDon);

                // Tính tổng thành tiền
                decimal thanhTien = tongTienThuePhong + tongTienDichVu;

                // Xác nhận thanh toán
                var confirmResult = MessageBox.Show($"Tổng tiền cần thanh toán: {thanhTien:C2}\nBạn có chắc chắn muốn thanh toán không?",
                    "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Cập nhật trạng thái hóa đơn trong cơ sở dữ liệu
                    using (SqlConnection con = new SqlConnection(path))
                    {
                        con.Open();
                        string queryUpdate = "UPDATE HoaDon SET NgayTraPhong = @NgayTraPhong, ThanhTien = @ThanhTien, DaThanhToan = 1 WHERE MaHoaDon = @MaHoaDon";
                        SqlCommand cmd = new SqlCommand(queryUpdate, con);
                        cmd.Parameters.AddWithValue("@NgayTraPhong", ngayTraPhong);
                        cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                        cmd.ExecuteNonQuery();
                    }

                    // Thông báo thành công
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu
                    load();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txttimkiem.Text.Trim(); // Lấy từ khóa từ TextBox

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    // Truy vấn tìm kiếm
                    string query = @"SELECT [MaHoaDon], [MaKhachHang], [MaNhanVien], [GiaPhongMotNgay], [MaPhong], 
                                    [NgayThuePhong], [NgayTraPhong], [ThanhTien], [DaThanhToan] 
                             FROM HoaDon 
                             WHERE (MaHoaDon LIKE @Keyword OR MaKhachHang LIKE @Keyword OR MaNhanVien LIKE @Keyword) 
                             AND DaThanhToan = 0";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Gán dữ liệu tìm kiếm vào DataGridView
                    dgvtraphong.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
