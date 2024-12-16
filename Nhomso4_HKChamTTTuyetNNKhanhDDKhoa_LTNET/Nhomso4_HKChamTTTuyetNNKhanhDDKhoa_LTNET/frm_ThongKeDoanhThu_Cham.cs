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
    public partial class frm_ThongKeDoanhThu_Cham : Form
    {
        public frm_ThongKeDoanhThu_Cham()
        {
            InitializeComponent();
        }

        private void btn_XemDTTPhong_Cham_Click(object sender, EventArgs e)
        {
            frm_TKDT_DTTPhong_Cham frm = new frm_TKDT_DTTPhong_Cham();
            frm.ShowDialog();
        }

        private void btn_XemDTTNam_Cham_Click(object sender, EventArgs e)
        {
            frm_TKDT_DTTNam_Cham frm = new frm_TKDT_DTTNam_Cham();
            frm.ShowDialog();
        }

        private void btn_XemDSDichvu_Cham_Click(object sender, EventArgs e)
        {
            frm_TKDT_DSDichVu_Cham frm = new frm_TKDT_DSDichVu_Cham();
            frm.ShowDialog();
        }
    }
}
