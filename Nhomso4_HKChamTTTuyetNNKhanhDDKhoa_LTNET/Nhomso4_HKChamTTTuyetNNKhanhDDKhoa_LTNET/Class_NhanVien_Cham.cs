using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    public class Class_NhanVien_Cham
    {
        private string maNV;
        private string hotenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string matKhau;
        private string loaiNguoiDung;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HotenNV { get => hotenNV; set => hotenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string LoaiNguoiDung { get => loaiNguoiDung; set => loaiNguoiDung = value; }

        public Class_NhanVien_Cham(string maNV, string hotenNV, DateTime ngaySinh, string gioiTinh, string matKhau, string loaiNguoiDung)
        {
            MaNV = maNV;
            HotenNV = hotenNV;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            MatKhau = matKhau;
            LoaiNguoiDung = loaiNguoiDung;
        }
    }
}
