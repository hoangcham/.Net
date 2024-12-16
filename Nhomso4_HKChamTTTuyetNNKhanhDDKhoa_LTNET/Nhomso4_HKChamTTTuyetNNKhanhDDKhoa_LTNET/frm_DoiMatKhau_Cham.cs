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
    public partial class frm_DoiMatKhau_Cham : Form
    {
        DBAccess db = new DBAccess();
        public frm_DoiMatKhau_Cham()
        {
            InitializeComponent();

            // Ẩn mật khẩu ban đầu
            txt_MKC_Cham.PasswordChar = '*';
            txt_MKM_Cham.PasswordChar = '*';
            txt_NLMKM_Cham.PasswordChar = '*';
        }
        private void btn_XN_Cham_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string username = txt_TenDN_Cham.Text.Trim();
            string oldPassword = txt_MKC_Cham.Text.Trim();
            string newPassword = txt_MKM_Cham.Text.Trim();
            string confirmPassword = txt_NLMKM_Cham.Text.Trim();

            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra thông tin đăng nhập
            if (db.KiemTraTTDN(username, oldPassword) != null)
            {
                // Đổi mật khẩu
                bool isUpdated = db.DoiMatKhau(username, newPassword);

                if (isUpdated)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form đổi mật khẩu
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_NhapLai_Cham_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các TextBox
            txt_TenDN_Cham.Clear();
            txt_MKC_Cham.Clear();
            txt_MKM_Cham.Clear();
            txt_NLMKM_Cham.Clear();
            txt_TenDN_Cham.Focus();
        }

        private void btb_Thoat_Cham_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_anhien_cham_CheckedChanged(object sender, EventArgs e)
        {
            // Hiện/Ẩn mật khẩu
            char passwordChar = chk_anhien_cham.Checked ? '\0' : '*';
            txt_MKC_Cham.PasswordChar = passwordChar;
            txt_MKM_Cham.PasswordChar = passwordChar;
            txt_NLMKM_Cham.PasswordChar = passwordChar;
        }
    }
}
