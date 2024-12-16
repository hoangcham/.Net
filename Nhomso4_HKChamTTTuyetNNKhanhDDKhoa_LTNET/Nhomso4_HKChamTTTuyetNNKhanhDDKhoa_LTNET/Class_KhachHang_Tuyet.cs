using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    public class Class_KhachHang_Tuyet
    {
        private string maKH;
        private string hotenKH;
        private string soCMT;
        private string gioiTinh;
        private string quocTich;
        private string soDT;

        public Class_KhachHang_Tuyet(string maKH, string hotenKH, string soCMT, string gioiTinh, string quocTich, string soDT)
        {
            this.maKH = maKH;
            this.hotenKH = hotenKH;
            this.soCMT = soCMT;
            this.gioiTinh = gioiTinh;
            this.quocTich = quocTich;
            this.soDT = soDT;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HotenKH { get => hotenKH; set => hotenKH = value; }
        public string SoCMT { get => soCMT; set => soCMT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
