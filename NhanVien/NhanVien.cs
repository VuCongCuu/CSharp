using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    public abstract class NhanVien
    {
        public string name;
        public double luongCoBan;

        public string Name { get => name; set => name = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public NhanVien() { }
        public NhanVien(string name,double luongcoban)
        {
            this.name = name;
            this.luongCoBan = luongcoban;
        }

        public virtual void nhap()
        {
            Console.WriteLine("Tên nhân viên:");
            this.name = Console.ReadLine();
            do
            {
            Console.WriteLine("lương cơ bản");
            this.luongCoBan = Convert.ToDouble(Console.ReadLine());
            } while (this.luongCoBan<=0); 
        }
        public virtual void hienthi()
        {
            Console.WriteLine("Tên nhân viên : " +Name );
            Console.WriteLine("Lương cơ bản : " +LuongCoBan);
        }
        public abstract double TinhLuong();
    }
}
