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
    public partial class frm_QlPhong_Khanh : Form
    {
        public frm_QlPhong_Khanh()
        {
            InitializeComponent();
        }
        private readonly string path = @"Data Source=DESKTOP-8LMO6HU\KIMCHAM;Initial Catalog=QLKhachSan;Integrated Security=True; ";

        private void load()
        {
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string qr = " Select  Phong.MaPhong , LoaiPhong.TenLoaiPhong, Phong.TenPhong,LoaiPhong.GiaPhongMotNgay  ,Phong.TinhTrang ,LoaiPhong.MoTa FROM [QLKhachSan].[dbo].[LoaiPhong] Join [QLKhachSan].[dbo].[Phong]  ON LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qr, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvquanlyphong.DataSource = dataTable;
            {
                dgvquanlyphong.Columns[0].AutoSizeMode =
      DataGridViewAutoSizeColumnMode.AllCells;
                dgvquanlyphong.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                dgvquanlyphong.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                dgvquanlyphong.Columns[3].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                dgvquanlyphong.Columns[4].AutoSizeMode =
                   DataGridViewAutoSizeColumnMode.AllCells;
                dgvquanlyphong.Columns[5].AutoSizeMode =
                   DataGridViewAutoSizeColumnMode.Fill;





                dgvquanlyphong.Columns[0].HeaderText = "Mã Phòng ";
                dgvquanlyphong.Columns[1].HeaderText = "Tên Loại phòng ";
                dgvquanlyphong.Columns[2].HeaderText = "Tên Phòng ";
                dgvquanlyphong.Columns[3].HeaderText = "Giá Phòng Một Ngày ";
                dgvquanlyphong.Columns[4].HeaderText = " Tình Trạng";
                dgvquanlyphong.Columns[5].HeaderText = "Mô tả ";


                dgvquanlyphong.ReadOnly = true;
                dgvquanlyphong.MultiSelect = false;
                dgvquanlyphong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvquanlyphong.AllowUserToAddRows = false;
            }
        }
        private void frm_QlPhong_Khanh_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoaiPhong.Text) ||
                string.IsNullOrWhiteSpace(txtTenLoaiPhong.Text) ||
                string.IsNullOrWhiteSpace(txtMaPhong.Text) ||
                string.IsNullOrWhiteSpace(txtTenPhong.Text) ||
                string.IsNullOrWhiteSpace(txtGiaPhongMotNgay.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(path))
            {
                try
                {
                    con.Open();

                    // Kiểm tra mã loại phòng đã tồn tại chưa
                    string checkLoaiPhong = "SELECT COUNT(*) FROM LoaiPhong WHERE MaLoaiPhong = @MaLoaiPhong";
                    SqlCommand cmdCheckLoaiPhong = new SqlCommand(checkLoaiPhong, con);
                    cmdCheckLoaiPhong.Parameters.AddWithValue("@MaLoaiPhong", txtMaLoaiPhong.Text.Trim());
                    int loaiPhongExists = (int)cmdCheckLoaiPhong.ExecuteScalar();

                    if (loaiPhongExists == 0)
                    {
                        // Thêm vào bảng LoaiPhong nếu chưa tồn tại
                        string insertLoaiPhong = "INSERT INTO LoaiPhong (MaLoaiPhong, TenLoaiPhong, GiaPhongMotNgay, MoTa) VALUES (@MaLoaiPhong, @TenLoaiPhong, @GiaPhongMotNgay, @MoTa)";
                        SqlCommand cmdLoaiPhong = new SqlCommand(insertLoaiPhong, con);
                        cmdLoaiPhong.Parameters.AddWithValue("@MaLoaiPhong", txtMaLoaiPhong.Text.Trim());
                        cmdLoaiPhong.Parameters.AddWithValue("@TenLoaiPhong", txtTenLoaiPhong.Text.Trim());
                        cmdLoaiPhong.Parameters.AddWithValue("@GiaPhongMotNgay", decimal.Parse(txtGiaPhongMotNgay.Text.Trim()));
                        cmdLoaiPhong.Parameters.AddWithValue("@MoTa", txtMoTa.Text.Trim());
                        cmdLoaiPhong.ExecuteNonQuery();
                    }

                    // Thêm vào bảng Phong
                    string insertPhong = "INSERT INTO Phong (MaPhong, MaLoaiPhong, TenPhong, TinhTrang) " +
                                         "VALUES (@MaPhong, @MaLoaiPhong, @TenPhong, @TinhTrang)";
                    SqlCommand cmdPhong = new SqlCommand(insertPhong, con);
                    cmdPhong.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());
                    cmdPhong.Parameters.AddWithValue("@MaLoaiPhong", txtMaLoaiPhong.Text.Trim());
                    cmdPhong.Parameters.AddWithValue("@TenPhong", txtTenPhong.Text.Trim());
                    cmdPhong.Parameters.AddWithValue("@TinhTrang", chkTinhTrang.Checked);
                    cmdPhong.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi thêm thành công, tải lại dữ liệu
                    load();

                    // Xóa nội dung trong các TextBox
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm xóa nội dung trong các TextBox
        private void ClearInputFields()
        {
            txtMaLoaiPhong.Clear();
            txtTenLoaiPhong.Clear();
            txtMoTa.Clear();
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtGiaPhongMotNgay.Clear();
            chkTinhTrang.Checked = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra các TextBox không được để trống
            if (string.IsNullOrWhiteSpace(txtMaLoaiPhong.Text) ||
                string.IsNullOrWhiteSpace(txtTenLoaiPhong.Text) ||
                string.IsNullOrWhiteSpace(txtMaPhong.Text) ||
                string.IsNullOrWhiteSpace(txtTenPhong.Text) ||
                string.IsNullOrWhiteSpace(txtGiaPhongMotNgay.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(path))
            {
                try
                {
                    con.Open();

                    // Cập nhật bảng LoaiPhong
                    string updateLoaiPhong = "UPDATE LoaiPhong SET TenLoaiPhong = @TenLoaiPhong,GiaPhongMotNgay = @GiaPhongMotNgay, MoTa = @MoTa WHERE MaLoaiPhong = @MaLoaiPhong";
                    SqlCommand cmdLoaiPhong = new SqlCommand(updateLoaiPhong, con);
                    cmdLoaiPhong.Parameters.AddWithValue("@MaLoaiPhong", txtMaLoaiPhong.Text.Trim());
                    cmdLoaiPhong.Parameters.AddWithValue("@TenLoaiPhong", txtTenLoaiPhong.Text.Trim());
                    cmdLoaiPhong.Parameters.AddWithValue("@GiaPhongMotNgay", decimal.Parse(txtGiaPhongMotNgay.Text.Trim()));
                    cmdLoaiPhong.Parameters.AddWithValue("@MoTa", txtMoTa.Text.Trim());
                    cmdLoaiPhong.ExecuteNonQuery();

                    // Cập nhật bảng Phong
                    string updatePhong = "UPDATE Phong SET TenPhong = @TenPhong, TinhTrang = @TinhTrang " +
                                         "WHERE MaPhong = @MaPhong";
                    SqlCommand cmdPhong = new SqlCommand(updatePhong, con);
                    cmdPhong.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());
                    cmdPhong.Parameters.AddWithValue("@TenPhong", txtTenPhong.Text.Trim());
                    cmdPhong.Parameters.AddWithValue("@TinhTrang", chkTinhTrang.Checked);
                    cmdPhong.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi sửa thành công, tải lại dữ liệu
                    load();

                    // Xóa nội dung trong các TextBox
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvquanlyphong.SelectedRows.Count > 0)
            {
                var maPhong = dgvquanlyphong.SelectedRows[0].Cells["MaPhong"].Value.ToString();
                var maLoaiPhong = dgvquanlyphong.SelectedRows[0].Cells["TenLoaiPhong"].Value.ToString();

                DialogResult confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa phòng và loại phòng liên quan không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(path))
                    {
                        try
                        {
                            con.Open();

                            // Xóa bản ghi trong bảng Phong
                            string deletePhong = "DELETE FROM Phong WHERE MaPhong = @MaPhong";
                            SqlCommand cmdPhong = new SqlCommand(deletePhong, con);
                            cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
                            cmdPhong.ExecuteNonQuery();

                            // Xóa bản ghi trong bảng LoaiPhong
                            string deleteLoaiPhong = "DELETE FROM LoaiPhong WHERE TenLoaiPhong = @TenLoaiPhong";
                            SqlCommand cmdLoaiPhong = new SqlCommand(deleteLoaiPhong, con);
                            cmdLoaiPhong.Parameters.AddWithValue("@TenLoaiPhong", maLoaiPhong);
                            cmdLoaiPhong.ExecuteNonQuery();

                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                try
                {
                    con.Open();
                    string qr = "SELECT Phong.MaPhong, LoaiPhong.TenLoaiPhong, Phong.TenPhong, LoaiPhong.GiaPhongMotNgay, Phong.TinhTrang, LoaiPhong.MoTa " +
                                "FROM [Phong] " +
                                "JOIN [LoaiPhong] ON LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong " +
                                "WHERE Phong.TenPhong LIKE @TenPhong or Phong.MaPhong Like @MaPhong";
                    SqlDataAdapter da = new SqlDataAdapter(qr, con);
                    da.SelectCommand.Parameters.AddWithValue("@TenPhong", "%" + txttimkiem.Text.Trim() + "%");
                    da.SelectCommand.Parameters.AddWithValue("@MaPhong", "%" + txttimkiem.Text.Trim() + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvquanlyphong.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                }
            }
        }
    }
}
