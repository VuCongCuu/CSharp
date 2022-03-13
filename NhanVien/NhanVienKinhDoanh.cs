using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    internal class NhanVienKinhDoanh : NhanVien
    {
        private double doanhThu;

        public double DoanhThu { get => doanhThu; set => doanhThu = value; }

        public NhanVienKinhDoanh() { }
        public NhanVienKinhDoanh(string name, double luongcoban, double doanhThu)
            : base(name, luongcoban)
        {
            this.doanhThu = doanhThu;
        }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Doanh thu : ");
            this.doanhThu = Convert.ToDouble(Console.ReadLine());
        }

        public override void hienthi()
        {
            base.hienthi();
            Console.WriteLine("Doanh Thu : " + DoanhThu);
            Console.WriteLine("Lương thực lĩnh : " + TinhLuong());
            Console.WriteLine("===================================");

        }
        public override double TinhLuong()
        {
            return this.LuongCoBan + (this.doanhThu * 10)/100;
        }

    }
}
