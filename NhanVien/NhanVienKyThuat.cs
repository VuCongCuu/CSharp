using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    public class NhanVienKyThuat : NhanVien
    {
        public int ngayCong;
        public int NgayCong { get => ngayCong; set => ngayCong = value; }
        public NhanVienKyThuat() { }
        public NhanVienKyThuat(string name, double luongcoban,int ngayCong)
            :base(name, luongcoban) 
        {
            this.ngayCong = ngayCong;
        }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Ngay Công:");
            this.ngayCong = Convert.ToInt32(Console.ReadLine());
        }
      
        public override void hienthi()
        {
            base.hienthi();
            Console.WriteLine("Ngày Công : " + NgayCong);
            Console.WriteLine("Lương thực lĩnh : " + TinhLuong());
            Console.WriteLine("===================================");

        }
        public override double TinhLuong()
        {
            return this.LuongCoBan + this.ngayCong*1000000;
        }
    }
}
