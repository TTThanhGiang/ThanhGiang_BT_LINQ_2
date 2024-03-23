using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhGiangBT
{
    class PhongBan
    {
        public int maPhongBan { get; set; }
        public string tenPhongBan { get; set; }
        public string moTa { get; set; }
        public PhongBan()
        {
        }

        public PhongBan(int maPhongBan, string tenPhongBan, string moTa)
        {
            this.maPhongBan = maPhongBan;
            this.tenPhongBan = tenPhongBan;
            this.moTa = moTa;
        }

        public static List<PhongBan> getListPhongBan()
        {
            return new List<PhongBan>()
            {
                new PhongBan(1,"Ke toan","Phong ban phu trach ke toan tai chinh" ),
                new PhongBan(2, "Nhan su","Phong ban phu trach tuyen dung va quan ly nhan su" ),
                new PhongBan(3, "Ky thuat","Phong ban phu trach phat trien và van hanh he thong" )
            };
        }
    }
}
