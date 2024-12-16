using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    public class Class_DichVu_Cham
    {
        private string maDV;
        private string tenDV;
        private string giaDV;

        public Class_DichVu_Cham(string maDV, string tenDV, string giaDV)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
            this.giaDV = giaDV;
        }

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string GiaDV { get => giaDV; set => giaDV = value; }
    }
}
