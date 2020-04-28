using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoangThiThu_chuong3._1_bai6
{
    class SinhVien
    {
        /*Các thành phần dữ liệu:

Mã sinh viên, Họ tên, Năm sinh, Điểm lập trình, Điểm
CSDL, Điểm TB(trong đó: Điểm TB = Điểm Lập trình +
Điểm CSDL)/2*/

        public string MSV;
        private string HoTen;
        private int NamSinh;
        private double DiemLT;
        private double DiemCSDL;
        private double DiemTB;

        public SinhVien()
        {
            MSV = "";
            HoTen = "";
            NamSinh = 2000;
            DiemCSDL = DiemLT = DiemTB = 0;
        }
        public SinhVien(string MSV, string HoTen, int NamSinh, double DiemLT, double DiemCSDL)
        {
            this.MSV = MSV;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = (DiemCSDL + DiemLT);
        }
        public void NhapSV()
        {
            Console.WriteLine("nhap thong tin sinh vien");
            Console.WriteLine("nhap ho ten");
            HoTen = Console.ReadLine();
            Console.WriteLine("nhap ma sinh vien");
            MSV = Console.ReadLine();
            Console.WriteLine("nhap nam sinh");
            NamSinh = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem lap trinh");
            DiemLT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap diem co so du lieu");
            DiemCSDL = Convert.ToDouble(Console.ReadLine());

        }

        public void TinhDiem()
        {
            DiemTB = (0.5 * (DiemCSDL + DiemLT));
        }
        public void XuatSV()
        {
            Console.WriteLine("thong tin sinh vien la \n ma sinh vien   {0} \n ho ten   {1}\n nam sinh   {2} \n diem lap trinh   {3} \n diem co so du lieu    {4}\n diem trung binh    {5} ", MSV, HoTen, NamSinh, DiemLT, DiemCSDL, DiemTB);


        }
        public bool CheckDiem()
        {
            bool Diem = false;
            if (DiemTB > 8.5) Diem = true;
            return Diem;
               

        }
        



    }
}

