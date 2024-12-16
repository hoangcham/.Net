using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    public class Class_Phong_Tuyet
    {
        private string maPhong;
        private string tenPhong;
        private string maLoaiPhong;
        private string tinhTrang;

        public Class_Phong_Tuyet(string maPhong, string tenPhong, string maLoaiPhong, string tinhTrang)
        {
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
            this.maLoaiPhong = maLoaiPhong;
            this.tinhTrang = tinhTrang;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
