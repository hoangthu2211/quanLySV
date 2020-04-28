using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoangThiThu_chuong3._1_bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            //SinhVien sinhVien1 = new SinhVien();
            //sinhVien1.NhapSV();
            //sinhVien1.TinhDiem();
            //sinhVien1.XuatSV();
            //Console.Read();
            DanhSach danhSach1 = new DanhSach();
            danhSach1.NhapDS();
            danhSach1.XuatDS();
            


            Console.WriteLine("sinh vien co diem tren 8.5");
            danhSach1.DSSV();
            danhSach1.SapXep();
            Console.Read(); ;
        }
    }
}
