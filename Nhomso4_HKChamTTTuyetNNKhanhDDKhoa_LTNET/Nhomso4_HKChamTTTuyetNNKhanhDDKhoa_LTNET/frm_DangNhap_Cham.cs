using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    public partial class frm_DangNhap_Cham : Form
    {
        public frm_DangNhap_Cham()
        {
            InitializeComponent();
            txt_MK_Cham.PasswordChar = '*';
        }
        DBAccess db = new DBAccess();
        private void btn_DN_Cham_Click(object sender, EventArgs e)
        {
            string username = txt_TenDN_Cham.Text.Trim();
            string password = txt_MK_Cham.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Bạn phải nhập username vào!", "Đăng nhập");
                txt_TenDN_Cham.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Bạn phải nhập Password vào!", "Đăng nhập");
                txt_MK_Cham.Focus();
                return;
            }

            // Kiểm tra thông tin đăng nhập và lấy vai trò người dùng
            string loaiNguoiDung = db.KiemTraTTDN(username, password);
            if (!string.IsNullOrEmpty(loaiNguoiDung))
            {
                // Thông báo đăng nhập thành công
                MessageBox.Show($"Đăng nhập thành công! Vai trò của bạn là: {loaiNguoiDung}",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form dựa trên quyền
                OpenFormBasedOnRole(loaiNguoiDung);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btb_Thoat_Cham_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_NhapLai_Cham_Click(object sender, EventArgs e)
        {
                txt_MK_Cham.Text = "";
                txt_TenDN_Cham.Clear();
                txt_TenDN_Cham.Focus();
        }

        private void chk_anhien_cham_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_anhien_cham.Checked)
            {
                // Hiện mật khẩu
                txt_MK_Cham.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu bằng dấu '*'
                txt_MK_Cham.PasswordChar = '*';
            }
        }
        private void OpenFormBasedOnRole(string loaiNguoiDung)
        {
            // Chỉ mở Menu chính và truyền vai trò vào
            frm_Menuchinh_HoangKimCham frm = new frm_Menuchinh_HoangKimCham(loaiNguoiDung);
            frm.FormClosed += (s, args) => this.Close(); // Đóng ứng dụng khi menu chính đóng
            frm.Show(); // Hiển thị menu chính
            this.Hide();      // Ẩn form đăng nhập
        }

        private void frm_DangNhap_Cham_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
