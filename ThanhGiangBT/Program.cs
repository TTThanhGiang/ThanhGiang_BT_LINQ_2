using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhGiangBT
{
    class Program
    {

        static void Main(string[] args)
        {
            var listjoin = NhanVien.getListNhanVien()
                                .Join(PhongBan.getListPhongBan(), nv => nv.maPhongBan, pb => pb.maPhongBan,
                                (nv, pb) => new { nv, pb })
                                .Join(ChucVu.getListChucVu(), l => l.nv.maChucVu, cv => cv.maChucVu,
                                (l, cv) => new {
                                    tenNhanVien = l.nv.hoTen,
                                    Tuoi = l.nv.Tuoi,
                                    gioiTinh = l.nv.gioiTinh,
                                    diaChi = l.nv.diaChi,
                                    sdt = l.nv.dienThoai,
                                    email = l.nv.email,
                                    phongBan = l.pb.tenPhongBan,
                                    moTaPhongBan = l.pb.moTa,
                                    chucVu = cv.tenChucVu,
                                    moTaChucVu = cv.moTa
                                });
            foreach (var n in listjoin)
            {
                Console.WriteLine($"{n.tenNhanVien} - {n.Tuoi} - {n.gioiTinh} - {n.diaChi} - {n.sdt} - {n.email} - {n.phongBan} - {n.chucVu}");
            }
            char e = 'y';
            while (e == 'Y' || e == 'y')
            {
                Console.WriteLine("Nhap noi dung tim kiem: ");
                string text = Console.ReadLine();
                Console.WriteLine("Nhap do tuoi tim kiem");
                Console.WriteLine("Tu: ");
                string strFrom = Console.ReadLine();
                int? ageFrom_ = string.IsNullOrEmpty(strFrom) ? (int?)null : Convert.ToInt32(strFrom);
                string strTo = "";
                int? ageTo_ = null;
                if (!strFrom.Equals(""))
                {
                    Console.WriteLine("Den: ");
                    strTo = Console.ReadLine();
                    ageTo_ = string.IsNullOrEmpty(strTo) ? (int?)null : Convert.ToInt32(strTo);
                }
                Console.WriteLine("Nhap ten vi tri: ");
                string namePos = Console.ReadLine();
                Console.WriteLine("Nhap ten phong ban: ");
                string nameDep = Console.ReadLine();
                text = text.ToLower();

                var listsearch = listjoin.Where(l => (l.Tuoi > ageFrom_ && l.Tuoi < ageTo_ ) && l.chucVu.ToLower().Contains(namePos) 
                                                        && l.phongBan.ToLower().Contains(nameDep) && (l.tenNhanVien.ToLower().Contains(text)
                                                        || l.phongBan.ToLower().Contains(text) || l.chucVu.ToLower().Contains(text) 
                                                        || l.moTaChucVu.Contains(text) || l.moTaPhongBan.Contains(text))) ;
                if (listsearch != null)
                {
                    foreach (var n in listsearch)
                    {
                        Console.WriteLine($"{n.tenNhanVien} - {n.Tuoi} - {n.gioiTinh} - {n.diaChi} - {n.sdt} - {n.email} - {n.phongBan} - {n.chucVu}");
                    }
                }

                Console.WriteLine("Nhap y/Y de tro ve Menu va phim bat ky de ket thuc");
                e = Convert.ToChar(Console.ReadLine());
            }

            Console.ReadLine();

        }
        
    } 
    }
