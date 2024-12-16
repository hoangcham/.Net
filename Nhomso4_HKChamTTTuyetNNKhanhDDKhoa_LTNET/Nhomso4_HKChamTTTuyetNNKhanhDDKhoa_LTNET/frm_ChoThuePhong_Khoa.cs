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

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    public partial class frm_ChoThuePhong_Khoa : Form
    {
        public static int maDH = 0;
        public frm_ChoThuePhong_Khoa()
        {
            InitializeComponent();
        }

        private readonly string path = @"Data Source=DESKTOP-8LMO6HU\KIMCHAM;Initial Catalog=QLKhachSan;Integrated Security=True; ";
        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                try
                {
                    con.Open();


                    string sql = "SELECT COUNT(*) FROM KhachHang WHERE SoChungMinhThu = @SoChungMinhThu";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@SoChungMinhThu", txtcmnd.Text.Trim());


                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {

                        frm_QLKhachHang_Tuyet frmQLKH = new frm_QLKhachHang_Tuyet();
                        frmQLKH.Show();

                    }
                    else
                    {
                        // Nếu tồn tại, lấy mã khách hàng và đưa vào ComboBox
                        string sqlGetMaKH = "SELECT MaKhachHang FROM KhachHang WHERE SoChungMinhThu = @SoChungMinhThu";
                        SqlCommand cmdGetMaKH = new SqlCommand(sqlGetMaKH, con);
                        cmdGetMaKH.Parameters.AddWithValue("@SoChungMinhThu", txtcmnd.Text.Trim());

                        SqlDataReader reader = cmdGetMaKH.ExecuteReader();
                        cbkh.Items.Clear(); // Xóa dữ liệu cũ trong ComboBox

                        while (reader.Read())
                        {
                            cbkh.Items.Add(reader["MaKhachHang"].ToString());
                        }

                        reader.Close();

                        // Hiển thị phòng trống nếu cần
                        HienThiPhongTrong();

                        // Đặt giá trị mặc định cho ComboBox nếu có dữ liệu
                        if (cbkh.Items.Count > 0)
                        {
                            cbkh.SelectedIndex = 0;
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
            private void HienThiPhongTrong()
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    try
                    {
                        con.Open();

                        string sql = @"
                SELECT 
                    Phong.MaPhong, 
                    Phong.TenPhong, 
                    LoaiPhong.TenLoaiPhong, 
                    LoaiPhong.GiaPhongMotNgay, 
                    LoaiPhong.MoTa 
                FROM 
                    Phong 
                JOIN 
                    LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong 
                WHERE 
                    Phong.TinhTrang = 0";

                        SqlDataAdapter da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Hiển thị lên DataGridView
                        dgvphong.DataSource = dt;

                        // Định dạng DataGridView nếu cần
                        dgvphong.Columns[0].HeaderText = "Mã Phòng";
                        dgvphong.Columns[1].HeaderText = "Tên Phòng";
                        dgvphong.Columns[2].HeaderText = "Loại Phòng";
                        dgvphong.Columns[3].HeaderText = "Giá Phòng Một Ngày";
                        dgvphong.Columns[4].HeaderText = "Mô Tả";

                        dgvphong.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dgvphong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dgvphong.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dgvphong.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dgvphong.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        dgvphong.ReadOnly = true;
                        dgvphong.MultiSelect = false;
                        dgvphong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvphong.AllowUserToAddRows = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi hiển thị phòng trống: " + ex.Message);
                    }
                }
            }

        

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            maDH = int.Parse(txtMahd.Text.Trim());
            if (dgvphong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvphong.SelectedRows[0];
                string maPhong = selectedRow.Cells["MaPhong"].Value.ToString();
                string giaPhong = selectedRow.Cells["GiaPhongMotNgay"].Value.ToString();
                DateTime Thue = DateTime.Now;
                bool thanhtoan = false;

                using (SqlConnection con = new SqlConnection(path))
                {
                    try
                    {
                        con.Open();
                        string sqlhoadon = "INSERT INTO [dbo].[HoaDon] (MaHoaDon, MaKhachHang, MaNhanVien, GiaPhongMotNgay, MaPhong, NgayThuePhong, DaThanhToan) " +
                                           "VALUES (@MaHoaDon, @MaKhachHang, @MaNhanVien, @GiaPhongMotNgay, @MaPhong, @NgayThuePhong, @DaThanhToan)";
                        SqlCommand cmd = new SqlCommand(sqlhoadon, con);
                        cmd.Parameters.AddWithValue("@MaHoaDon", txtMahd.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaKhachHang", cbkh.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaNhanVien", txtmanhanvien.Text.Trim());
                        cmd.Parameters.AddWithValue("@GiaPhongMotNgay", giaPhong);
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.Parameters.AddWithValue("@NgayThuePhong", Thue);
                        cmd.Parameters.AddWithValue("@DaThanhToan", thanhtoan);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Mở form dichvu
                            dichvu_Long dichVuForm = new dichvu_Long();
                            dichVuForm.Show();
                            this.Close();  // Đóng form ChoThuePhong

                        }
                        else
                        {
                            MessageBox.Show("Không thêm được hóa đơn. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
