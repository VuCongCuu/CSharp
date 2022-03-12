using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    internal class SinhVien
    {
        private string maSV ;
        private string name ;
        private double diem ;

        public string MaSV { get => maSV; set => maSV = value; }
        public string Name { get => name; set => name = value; }
        public double Diem { get => diem; set => diem = value; }

        public SinhVien() { }
        public SinhVien(string masv,string name,double diem)
        {
            this.maSV = masv;
            this.name = name;
            this.diem = diem;
        }
       
        public void nhap()
        {
            Console.WriteLine("Nhập mã sinh viên :");
            this.maSV = Console.ReadLine();
            Console.WriteLine("Nhập tên sinh viên :");
            this.name = Console.ReadLine();
            Console.WriteLine("Nhập điểm sinh viên :");
            this.diem = Convert.ToDouble(Console.ReadLine());

        }
        public void hienthi()
        {
            Console.WriteLine("Tên sinh viên: {0} | Mã sinh viên : {1} | Điểm : {2}",Name,MaSV,Diem );
        }
        
    }
}
