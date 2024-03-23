using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhGiangBT
{
    class ChucVu
    {
        public int maChucVu { get; set; }
        public string tenChucVu { get; set; }
        public string moTa { get; set; }
        public int maPhongBan { get; set; }

        public ChucVu()
        {
        }

        public ChucVu(int maChucVu, string tenChucVu, string moTa, int maPhongBan)
        {
            this.maChucVu = maChucVu;
            this.tenChucVu = tenChucVu;
            this.moTa = moTa;
            this.maPhongBan = maPhongBan;
        }

        public static List<ChucVu> getListChucVu()
        {
            return new List<ChucVu>()
            {
                new ChucVu(1,"Ke toan truong", "Phu trach quan ly tai chinh",1),
                new ChucVu(2,"Nhan vien ke toan","Phu trach cac cong viec ke toan", 1),
                new ChucVu(3,"Chuyen vien nhan su","Phu trach tuyen dung va dao tao nhan su", 2),
                new ChucVu(4,"Quan ly nhan su","Phu trach quan ly nhan vien",2),
                new ChucVu(5,"Lap trinh vien","Phu trach phat trien he thong", 3),
                new ChucVu(6,"Ky su he thong","Phu trach van hanh he thong", 3)
            };
        }
    }
}
