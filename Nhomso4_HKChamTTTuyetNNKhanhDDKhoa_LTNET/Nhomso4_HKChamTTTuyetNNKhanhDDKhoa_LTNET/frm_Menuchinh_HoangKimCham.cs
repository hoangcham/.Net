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
    public partial class frm_Menuchinh_HoangKimCham : Form
    {
        private string userRole; 
        public frm_Menuchinh_HoangKimCham(string role)
        {
            InitializeComponent();
            userRole = role; // Gán vai trò nhận từ form đăng nhập
        }

        private void ConfigureMenuByRole()
        {
            if (userRole == "Nhân viên")
            {
                // Ẩn hoặc vô hiệu hóa các tính năng dành cho quản lý
                btn_qlNhanVien_Cham.Enabled = false; //  Ẩn chức năng quản lý nhân viên
                btn_QLDichVu_Cham.Enabled = false;
                btn_QLPhong_Cham.Enabled = false;
            }
            else if (userRole == "Quản lý")
            {
                // Hiển thị đầy đủ các tính năng cho quản lý
                btn_qlNhanVien_Cham.Enabled = true;
                btn_QLDichVu_Cham.Enabled = true;
                btn_QLPhong_Cham.Enabled = true;
            }
        }

        

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DangNhap_Cham frm = new frm_DangNhap_Cham();
            frm.ShowDialog();
        }

        private void btn_Thoat_Cham_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btn_qlNhanVien_Cham_Click(object sender, EventArgs e)
        {
            if (userRole != "Quản lý")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frm_QLNhanVien_Cham frm = new frm_QLNhanVien_Cham();
            frm.ShowDialog(); // Mở form quản lý nhân viên
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_qlNhanVien_Cham_Click(sender, e);
        }

        private void btn_QLKH_Cham_Click(object sender, EventArgs e)
        {
            frm_QLKhachHang_Tuyet frm = new frm_QLKhachHang_Tuyet();
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_QLKH_Cham_Click(sender, e);
        }

        private void btn_XNV_Cham_Click(object sender, EventArgs e)
        {
            btn_qlNhanVien_Cham_Click(sender, e);
        }

        private void btn_XP_Cham_Click(object sender, EventArgs e)
        {
            btn_QLPhong_Cham_Click(sender, e);
        }

        private void btn_QLDichVu_Cham_Click(object sender, EventArgs e)
        {
            if (userRole != "Quản lý")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frm_QLDichVu_Cham frm = new frm_QLDichVu_Cham();
            frm.ShowDialog();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_QLDichVu_Cham_Click(sender, e);
        }

        private void frm_Menuchinh_HoangKimCham_Load(object sender, EventArgs e)
        {
            ConfigureMenuByRole(); // Thiết lập quyền dựa trên vai trò
        }

        private void btn_QLPhong_Cham_Click(object sender, EventArgs e)
        {
            if (userRole != "Quản lý")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frm_QlPhong_Khanh frm = new frm_QlPhong_Khanh();
            frm.ShowDialog();
        }

        private void btn_TKDT_Cham_Click(object sender, EventArgs e)
        {
            frm_ThongKeDoanhThu_Cham frm = new frm_ThongKeDoanhThu_Cham();
            frm.ShowDialog();
        }

        private void doanhThuTheoPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TKDT_DTTPhong_Cham frm = new frm_TKDT_DTTPhong_Cham();
            frm.ShowDialog();
        }

        private void doanhThuTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TKDT_DTTNam_Cham frm =new frm_TKDT_DTTNam_Cham();
            frm.ShowDialog();
        }

        private void danhSáchDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TKDT_DSDichVu_Cham frm = new frm_TKDT_DSDichVu_Cham();
            frm.ShowDialog();
        }

        private void btn_XBC_Cham_Click(object sender, EventArgs e)
        {
            btn_TKDT_Cham_Click(sender, e);
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_QLPhong_Cham_Click(sender, e);
        }

        private void ĐổiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau_Cham frm  = new frm_DoiMatKhau_Cham();
            frm.ShowDialog();
        }

        private void btn_CTPhong_Cham_Click(object sender, EventArgs e)
        {
            frm_ChoThuePhong_Khoa frm = new frm_ChoThuePhong_Khoa();
            frm.ShowDialog();
        }

        private void btn_TraPhong__Click(object sender, EventArgs e)
        {
            frm_TraPhong_Long frm = new frm_TraPhong_Long();
            frm.ShowDialog();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_CTPhong_Cham_Click(sender, e);
        }

        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dichvu_Long frm = new dichvu_Long();
            frm.ShowDialog();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_TraPhong__Click(sender,e);
        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btn_Thoat_Cham_Click(sender, e);
        }

        private void btn_Dangxuat_Cham_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn đăng xuất không?",
                                 "Xác nhận đăng xuất",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hiển thị lại Form Đăng nhập
                frm_DangNhap_Cham frmDangNhap = new frm_DangNhap_Cham();
                frmDangNhap.Show();

                // Ẩn Form Menu chính
                this.Hide();
            }

        }
        
    }
}
