using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    public partial class frm_QLKhachHang_Tuyet : Form
    {
        public frm_QLKhachHang_Tuyet()
        {
            InitializeComponent();
        }
        DBAccess db = new DBAccess();
        private void frm_QLKhachHang_Tuyet_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            //lấy toàn bộ dữ liệu khách hàng ->Lưới
            DataTable dt = db.TraDanhSachKH();
            //Gán toàn bộ dữ liệu của dt vào lưới
            dtgv_qlkh_Tuyet.DataSource = dt;
        }

        private void btn_Them_Tuyet_Click(object sender, EventArgs e)
        {
            // Nếu đang ở chế độ "Thêm"
            if (btn_Them_Tuyet.Text == "Thêm")
            {
                txt_MaKH_Tuyet.Focus();  // Đặt con trỏ chuột vào trường mã khách hàng
                btn_Them_Tuyet.Text = "Lưu";  // Đổi tên nút thành "Lưu"
            }
            else  // Khi đang ở chế độ "Lưu"
            {
                if (ktradauvao())  // Kiểm tra nếu thiếu dữ liệu đầu vào
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu");
                }
                else if (kiemtrasdt(txt_SDT_Tuyet.Text.Trim()))  // Kiểm tra số điện thoại
                {
                    MessageBox.Show("Nhập sai số điện thoại");
                    txt_SDT_Tuyet.Focus();  // Đặt con trỏ chuột vào trường số điện thoại
                }
                else
                {
                    // Tạo đối tượng KhachHang mới
                    Class_KhachHang_Tuyet kh = new Class_KhachHang_Tuyet(
                        txt_MaKH_Tuyet.Text, txt_Hoten_Tuyet.Text, cb_Gioitinh_Tuyet.Text, txt_Qtich_Tuyet.Text, txt_SoCMT_Tuyet.Text, txt_SDT_Tuyet.Text);

                    // Gọi phương thức thêm khách hàng trong lớp cơ sở dữ liệu
                    if (db.ThemKH(kh))
                    {
                        MessageBox.Show("Trùng mã khách hàng, vui lòng nhập mã khác");
                        txt_MaKH_Tuyet.Focus();  // Đặt con trỏ chuột vào trường mã khách hàng
                    }
                    else
                    {
                        btn_Them_Tuyet.Text = "Thêm";  // Đổi lại nút thành "Thêm"
                        xoaText();  // Xóa dữ liệu trong các trường
                        LoadData();  // Tải lại dữ liệu vào DataGridView
                    }
                }
            }
        }

        void xoaText()
        {
            txt_MaKH_Tuyet.ResetText();
            txt_Hoten_Tuyet.ResetText();
            txt_SoCMT_Tuyet.ResetText();
            txt_Qtich_Tuyet.ResetText();
            txt_SDT_Tuyet.ResetText();
            cb_Gioitinh_Tuyet.ResetText();
        }

        bool ktradauvao()
        {
            if (string.IsNullOrWhiteSpace(txt_MaKH_Tuyet.Text) == true
                 || string.IsNullOrWhiteSpace(txt_Hoten_Tuyet.Text) ||
                 string.IsNullOrWhiteSpace(txt_SoCMT_Tuyet.Text) ||
                 string.IsNullOrWhiteSpace(cb_Gioitinh_Tuyet.Text) ||
                 string.IsNullOrWhiteSpace(txt_Qtich_Tuyet.Text) ||
                string.IsNullOrWhiteSpace(txt_SDT_Tuyet.Text))
                return true;
            return false;
        }

        bool kiemtrasdt(string sdt)
        {
            if (sdt.Length < 10 || sdt.Length > 10) return true;
            for (int i = 0; i < sdt.Length; i++)
                if (sdt[i] < '0' || sdt[i] > '9') return true;
            if (sdt[0] != '0') return true;
            return false;
        }

        private void dtgv_qlkh_Tuyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgv_qlkh_Tuyet.CurrentRow.Index;
            txt_MaKH_Tuyet.Text = dtgv_qlkh_Tuyet.Rows[i].Cells[0].Value.ToString();
            txt_Hoten_Tuyet.Text = dtgv_qlkh_Tuyet.Rows[i].Cells[1].Value.ToString();
            txt_SoCMT_Tuyet.Text = dtgv_qlkh_Tuyet.Rows[i].Cells[2].Value.ToString();
            txt_Qtich_Tuyet.Text = dtgv_qlkh_Tuyet.Rows[i].Cells[3].Value.ToString();
            cb_Gioitinh_Tuyet.Text = dtgv_qlkh_Tuyet.Rows[i].Cells[4].Value.ToString();
            txt_SDT_Tuyet.Text = dtgv_qlkh_Tuyet.Rows[i].Cells[5].Value.ToString();
        }

        private void btn_Sua_Tuyet_Click(object sender, EventArgs e)
        {
            // kiểm tra xem người dùng đã chọn người cần sửa hay chưa?
            if (txt_MaKH_Tuyet.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn người cần sửa");
            }
            else if (btn_Sua_Tuyet.Text == "Sửa") // Nếu đang ở chế độ "Sửa"
            {
                btn_Sua_Tuyet.Text = "Cập nhật";  // Đổi tên nút thành "Cập nhật"
                txt_MaKH_Tuyet.Enabled = false;  // Không cho phép sửa mã khách hàng
            }
            else if (ktradauvao() == true)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
                btn_Sua_Tuyet.Text = "Cập nhật";
            }
            else if (kiemtrasdt(txt_SDT_Tuyet.Text) == true)
            {
                MessageBox.Show("Sai số điện thoại");
                btn_Sua_Tuyet.Text = "Cập nhật";
                txt_SDT_Tuyet.Focus();
            }
            else // Nếu tất cả thông tin hợp lệ, thực hiện cập nhật
            {
                // Tạo đối tượng khách hàng với thông tin mới
                Class_KhachHang_Tuyet kh = new Class_KhachHang_Tuyet(
                        txt_MaKH_Tuyet.Text, txt_Hoten_Tuyet.Text, txt_SoCMT_Tuyet.Text, txt_Qtich_Tuyet.Text, cb_Gioitinh_Tuyet.Text, txt_SDT_Tuyet.Text);

                // Gọi phương thức sửa khách hàng
                db.SuaKH(kh);  // Đảm bảo rằng phương thức này cập nhật thông tin trong CSDL

                // Cập nhật lại giao diện
                LoadData();  // Tải lại dữ liệu vào DataGridView
                btn_Sua_Tuyet.Text = "Sửa";  // Đổi lại tên nút thành "Sửa"
                xoaText();  // Xóa các trường dữ liệu sau khi cập nhật
            }
        }

        private void btn_Xoa_Tuyet_Click(object sender, EventArgs e)
        {
            if (txt_MaKH_Tuyet.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn người cần xóa");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa hay không?", "TB xoa", MessageBoxButtons.YesNo))
                {
                    foreach (DataGridViewRow row in dtgv_qlkh_Tuyet.SelectedRows)

                    {
                        string ma = row.Cells[0].Value.ToString();
                        db.XoaKH(ma);
                    }
                    xoaText();
                    LoadData();
                }
            }
        }

        private void btn_TimKiem_Tuyet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Hoten_Tuyet.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm.");
            }
            else
            {
                // Gọi phương thức tìm kiếm và lấy kết quả
                DataTable dt = db.TimKiemTheoTenKH(txt_Hoten_Tuyet.Text);

                if (dt.Rows.Count > 0)
                {
                    // Hiển thị kết quả tìm kiếm lên DataGridView (giả sử bạn có một DataGridView tên là dgvKhachHang)
                    dtgv_qlkh_Tuyet.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào có tên này.");
                }
            }
        }

        private void btn_Thoat_Tuyet_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại hỏi người dùng có muốn thoát hay không
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra phản hồi của người dùng
            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes", đóng form
                this.Close();
            }
            // Nếu người dùng chọn "No", không làm gì cả
        }
    }
}
