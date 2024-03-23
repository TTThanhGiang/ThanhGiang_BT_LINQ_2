using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhGiangBT
{
    class NhanVien
    {
        public int maNhanVien { get; set; }
        public string hoTen { get; set; }
        public int  Tuoi { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string dienThoai { get; set; }
        public string email { get; set; }
        public int maPhongBan { get; set; }
        public int maChucVu { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(int maNhanVien, string hoTen, int tuoi, string gioiTinh, string diaChi, string dienThoai, string email, int maPhongBan, int maChucVu)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.Tuoi = tuoi;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.email = email;
            this.maPhongBan = maPhongBan;
            this.maChucVu = maChucVu;
        }
        public static List<NhanVien> getListNhanVien()
        {
            return new List<NhanVien>()
            {
                new NhanVien(1, "Nguyen Van A", 25, "Nam", "Ha Noi", "0123456789", "abc@gmail.com", 1,1),
                new NhanVien(2, "Le Thi B", 35, "Nu", "TP. Ho Chi Minh", "0987654321", "def@gmail.com",1,2),
                new NhanVien(3, "Tran Van C", 43, "Nam", "Đa Nang", "0123456789", "ghi@gmail.com", 2,3),
                new NhanVien(4, "Pham Thi D", 29, "Nu", "Can Tho", "0987654321", "jkl@gmail.com", 2,4),
                new NhanVien(5, "Dinh Van E", 33, "Nam", "Hai Phong", "0123456789", "mno@gmail.com", 3,5),
                new NhanVien(6, "Bui Thi F",27, "Nu", "Bien Hoa", "0987654321", "pq@gmail.com", 3,6)
            };
        }

    }
}
