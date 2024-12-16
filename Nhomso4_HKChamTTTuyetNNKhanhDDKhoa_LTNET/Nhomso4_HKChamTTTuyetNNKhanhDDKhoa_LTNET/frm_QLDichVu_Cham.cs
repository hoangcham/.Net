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
    public partial class frm_QLDichVu_Cham : Form
    {
        public frm_QLDichVu_Cham()
        {
            InitializeComponent();
        }
        DBAccess db = new DBAccess();
        private void frm_QLDichVu_Cham_Load(object sender, EventArgs e)
        {
            Data();
        }

        void Data()
        {
            //lấy toàn bộ dữ liệu khách hàng ->Lưới
            DataTable dt = db.TraDanhSachDV();
            //Gán toàn bộ dữ liệu của dt vào lưới
            dtgv_qldv_Cham.DataSource = dt;
        }

        private void btn_Them_Cham_Click(object sender, EventArgs e)
        {
            // Nếu đang ở chế độ "Thêm"
            if (btn_Them_Cham.Text == "Thêm")
            {
                txt_MaDV_Cham.Focus();  // Đặt con trỏ chuột vào trường mã 
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
                    // Tạo đối tượng mới
                    Class_DichVu_Cham dv = new Class_DichVu_Cham(
                        txt_MaDV_Cham.Text,
                        txt_TenDV_Cham.Text,
                        txt_GiaDV_Cham.Text
                    );

                    // Kiểm tra trùng mã và thêm vào cơ sở dữ liệu
                    if (db.KiemTraMaDV(dv.MaDV))
                    {
                        MessageBox.Show("Trùng mã dịch vụ, vui lòng nhập mã khác");
                        txt_MaDV_Cham.Focus();  // Đặt con trỏ chuột vào trường mã 
                    }
                    else
                    {
                        // Gọi phương thức thêm và kiểm tra thành công
                        if (db.ThemDV(dv))
                        {
                            MessageBox.Show("Trùng dịch vụ, vui lòng nhập mã khác");
                            txt_MaDV_Cham.Focus();  // Đặt con trỏ chuột vào trường mã
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
            txt_MaDV_Cham.ResetText();
            txt_TenDV_Cham.ResetText();
            txt_GiaDV_Cham.ResetText();
        }
        bool ktradauvao()
        {
            if (string.IsNullOrWhiteSpace(txt_MaDV_Cham.Text) == true
                 || string.IsNullOrWhiteSpace(txt_TenDV_Cham.Text)
                 || string.IsNullOrWhiteSpace(txt_GiaDV_Cham.Text))
                return true;
            return false;
        }


        private void btn_Sua_Cham_Click(object sender, EventArgs e)
        {
            // kiểm tra xem người dùng đã chọn người cần sửa hay chưa?
            if (txt_MaDV_Cham.Text == "")
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
                // Kiểm tra dữ liệu "Giá dịch vụ" là số
                if (!decimal.TryParse(txt_GiaDV_Cham.Text, out decimal giaDV))
                {
                    MessageBox.Show("Giá dịch vụ phải là số hợp lệ.");
                    return; // Dừng nếu dữ liệu không hợp lệ
                }

                // Tạo đối tượng mới
                Class_DichVu_Cham dv = new Class_DichVu_Cham(
                    txt_MaDV_Cham.Text,
                    txt_TenDV_Cham.Text,
                    giaDV.ToString() // Truyền giá trị đã kiểm tra
                );

                try
                {
                    db.SuaDV(dv); // Thực hiện cập nhật trong CSDL

                    // Cập nhật giao diện
                    Data(); // Load lại dữ liệu
                    btn_Sua_Cham.Text = "Sửa"; // Đổi lại tên nút
                    xoaText(); // Xóa dữ liệu trong các trường
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}");
                }
            }
        }

        private void btn_Xoa_Cham_Click(object sender, EventArgs e)
        {
            if (txt_MaDV_Cham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn người cần xóa");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa hay không?", "Thông Báo xóa", MessageBoxButtons.YesNo))
                {
                    foreach (DataGridViewRow row in dtgv_qldv_Cham.SelectedRows)

                    {
                        string ma = row.Cells[0].Value.ToString();
                        db.XoaDV(ma);
                    }
                    xoaText();
                    Data();
                }
            }
        }

        private void btn_TimKiem_Cham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TKTTen_Cham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ cần tìm.");
            }
            else
            {
                // Gọi phương thức tìm kiếm và lấy kết quả
                DataTable dt = db.TimKiemTheoTenDV(txt_TKTTen_Cham.Text);

                if (dt.Rows.Count > 0)
                {
                    // Hiển thị kết quả tìm kiếm lên DataGridView
                    dtgv_qldv_Cham.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dịch vụ nào có tên này.");
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

        private void dtgv_qldv_Cham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgv_qldv_Cham.CurrentRow.Index;
            txt_MaDV_Cham.Text = dtgv_qldv_Cham.Rows[i].Cells[0].Value.ToString();
            txt_TenDV_Cham.Text = dtgv_qldv_Cham.Rows[i].Cells[1].Value.ToString();
            txt_GiaDV_Cham.Text = dtgv_qldv_Cham.Rows[i].Cells[2].Value.ToString();
        }
    }
}
