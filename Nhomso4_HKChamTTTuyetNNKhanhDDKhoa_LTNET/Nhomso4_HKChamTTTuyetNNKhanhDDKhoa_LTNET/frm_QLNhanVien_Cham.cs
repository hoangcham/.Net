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
    public partial class frm_QLNhanVien_Cham : Form
    {
        public frm_QLNhanVien_Cham()
        {
            InitializeComponent();
        }

        DBAccess db = new DBAccess();
        private void frm_QLNhanVien_Cham_Load(object sender, EventArgs e)
        {
            Data();
        }

        void Data()
        {
            //lấy toàn bộ dữ liệu khách hàng ->Lưới
            DataTable dt = db.TraDanhSachNV();
            //Gán toàn bộ dữ liệu của dt vào lưới
            dtgv_qlnv_Cham.DataSource = dt;
        }

        private void btn_Them_Cham_Click(object sender, EventArgs e)
        {
            // Nếu đang ở chế độ "Thêm"
            if (btn_Them_Cham.Text == "Thêm")
            {
                txt_MaNV_Cham.Focus();  // Đặt con trỏ chuột vào trường mã khách hàng
                btn_Them_Cham.Text = "Lưu";  // Đổi tên nút thành "Lưu"
            }
            else  // Khi đang ở chế độ "Lưu"
            {
                if (ktradauvao())  // Kiểm tra nếu thiếu dữ liệu đầu vào
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu");
                }
                else
                {
                    // Tạo đối tượng nhân viên mới
                    DateTime ngaySinh = dt_Ngaysinh_Cham.Value;
                    Class_NhanVien_Cham nv = new Class_NhanVien_Cham(
                        txt_MaNV_Cham.Text,
                        txt_Hoten_Cham.Text,
                        ngaySinh,  // Sử dụng giá trị ngày sinh từ DateTimePicker
                        cb_Gioitinh_Cham.Text,
                        txt_Matkhau_Cham.Text,
                        txt_Loaind_Cham.Text
                    );

                    // Kiểm tra trùng mã và thêm vào cơ sở dữ liệu
                    if (db.KiemTraMaNV(nv.MaNV))
                    {
                        MessageBox.Show("Trùng mã nhân viên, vui lòng nhập mã khác");
                        txt_MaNV_Cham.Focus();  // Đặt con trỏ chuột vào trường mã nhân viên
                    }
                    else
                    {
                        // Gọi phương thức thêm nhân viên và kiểm tra thành công
                        if (db.ThemNV(nv))
                        {
                            MessageBox.Show("Trùng mã nhân viên, vui lòng nhập mã khác");
                            txt_MaNV_Cham.Focus();  // Đặt con trỏ chuột vào trường mã khách hàng
                        }
                        else
                        {
                            btn_Them_Cham.Text = "Thêm";  // Đổi lại nút thành "Thêm"
                            xoaText();  // Xóa dữ liệu trong các trường
                            Data();  // Tải lại dữ liệu vào DataGridView
                        }
                    }
                }
            }
        }
        void xoaText()
        {
            txt_MaNV_Cham.ResetText();
            txt_Hoten_Cham.ResetText();
            txt_Matkhau_Cham.ResetText();
            txt_Loaind_Cham.ResetText();
            cb_Gioitinh_Cham.ResetText();
            dt_Ngaysinh_Cham.ResetText();
        }
        bool ktradauvao()
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV_Cham.Text) == true
                 || string.IsNullOrWhiteSpace(txt_Hoten_Cham.Text)
                 || string.IsNullOrWhiteSpace(dt_Ngaysinh_Cham.Text)
                 || string.IsNullOrWhiteSpace(cb_Gioitinh_Cham.Text)
                 || string.IsNullOrWhiteSpace(txt_Matkhau_Cham.Text)
                 || string.IsNullOrWhiteSpace(txt_Loaind_Cham.Text))
                return true;
            return false;
        }
        private void dtgv_qlnv_Cham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgv_qlnv_Cham.CurrentRow.Index;
            txt_MaNV_Cham.Text = dtgv_qlnv_Cham.Rows[i].Cells[0].Value.ToString();
            txt_Hoten_Cham.Text = dtgv_qlnv_Cham.Rows[i].Cells[1].Value.ToString();
            dt_Ngaysinh_Cham.Value = DateTime.Parse(dtgv_qlnv_Cham.Rows[i].Cells[2].Value.ToString());
            cb_Gioitinh_Cham.Text = dtgv_qlnv_Cham.Rows[i].Cells[3].Value.ToString();
            txt_Matkhau_Cham.Text = dtgv_qlnv_Cham.Rows[i].Cells[4].Value.ToString();
            txt_Loaind_Cham.Text = dtgv_qlnv_Cham.Rows[i].Cells[5].Value.ToString();
        }

        private void btn_Sua_Cham_Click(object sender, EventArgs e)
        {
            // kiểm tra xem người dùng đã chọn người cần sửa hay chưa?
            if (txt_MaNV_Cham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn người cần sửa");
            }
            else if (btn_Sua_Cham.Text == "Sửa") // Nếu đang ở chế độ "Sửa"
            {
                btn_Sua_Cham.Text = "Cập nhật";  // Đổi tên nút thành "Cập nhật"
            }
            else if (ktradauvao() == true)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
                btn_Sua_Cham.Text = "Cập nhật";
            }
            else // Nếu tất cả thông tin hợp lệ, thực hiện cập nhật
            {
                // Tạo đối tượng nhân vien với thông tin mới
                DateTime ngaySinh = dt_Ngaysinh_Cham.Value;
                Class_NhanVien_Cham nv = new Class_NhanVien_Cham(
                    txt_MaNV_Cham.Text,
                    txt_Hoten_Cham.Text,
                    ngaySinh,  // Sử dụng giá trị ngày sinh từ DateTimePicker
                    cb_Gioitinh_Cham.Text,
                    txt_Matkhau_Cham.Text,
                    txt_Loaind_Cham.Text
                );
                // Gọi phương thức sửa khách hàng
                db.SuaNV(nv);  // Đảm bảo rằng phương thức này cập nhật thông tin trong CSDL

                // Cập nhật lại giao diện
                Data();  // Tải lại dữ liệu vào DataGridView
                btn_Sua_Cham.Text = "Sửa";  // Đổi lại tên nút thành "Sửa"
                xoaText();  // Xóa các trường dữ liệu sau khi cập nhật
            }
        }

        private void btn_Xoa_Cham_Click(object sender, EventArgs e)
        {
            if (txt_MaNV_Cham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn người cần xóa");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa hay không?", "Thông Báo xóa", MessageBoxButtons.YesNo))
                {
                    foreach (DataGridViewRow row in dtgv_qlnv_Cham.SelectedRows)

                    {
                        string ma = row.Cells[0].Value.ToString();
                        db.XoaNV(ma);
                    }
                    xoaText();
                    Data();
                }
            }
        }

        private void btn_TimKiem_Cham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Hoten_Cham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm.");
            }
            else
            {
                // Gọi phương thức tìm kiếm và lấy kết quả
                DataTable dt = db.TimKiemTheoTenNV(txt_Hoten_Cham.Text);

                if (dt.Rows.Count > 0)
                {
                    // Hiển thị kết quả tìm kiếm lên DataGridView
                    dtgv_qlnv_Cham.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào có tên này.");
                }
            }
        }

        private void btn_Thoat_Cham_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra phản hồi của người dùng
            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes", đóng form
                this.Close();
            }
        }
    }
}
