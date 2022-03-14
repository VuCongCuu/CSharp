using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinhhoc
{
    public class Hinhtron : hinh
    {
        private double bankinh;

        public double Bankinh { get => bankinh; set => bankinh = value; }

        double hinh.chuvi()
        {
            return 2*Math.PI*bankinh;
        }
        void hinh.nhap()
        {
            Console.WriteLine("Bán kính:");
            this.bankinh = Convert.ToDouble(Console.ReadLine());
        }
        double hinh.dienTich()
        {
            return Math.PI*Math.Pow(bankinh,2);
        }

        void hinh.hienthi()
        {
            Console.WriteLine("Hinh tròn : Bán kính:" + bankinh);
        }
    }
}
