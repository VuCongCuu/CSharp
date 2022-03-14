using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinhhoc
{
    public class HinhChuNhat: hinh
    {
        private double dai;
        private double rong;

        public double Dai { get => dai; set => dai = value; }
        public double Rong { get => rong; set => rong = value; }
        public HinhChuNhat() { }
        public HinhChuNhat(double dai,double rong) 
        {
            this.dai = dai;
            this.rong = rong;
        }

        public virtual double chuvi()
        {
            return (dai+rong)*2;
        }
        public virtual void nhap()
        {
            Console.WriteLine("Chiều dài:");
            this.dai = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Chiều rộng:");
            this.rong = Convert.ToDouble(Console.ReadLine());
        }
        public virtual double dienTich()
        {
            return dai * rong;
        }

        public virtual void hienthi()
        {
            Console.WriteLine("Hinh chữ nhật : Chiều dài:" +dai+ " | Chiều rộng" + rong);
        }

    }
}
