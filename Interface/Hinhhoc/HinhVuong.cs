using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinhhoc
{
    public class HinhVuong : HinhChuNhat
    {
        public HinhVuong():base()
        { 
        }
        public HinhVuong(double dai) :base(dai,dai)
        {
          
        }
        public override void nhap()
        {
            Console.WriteLine("Nhập cạnh:");
            Rong=Dai = Convert.ToDouble(Console.ReadLine());
            
        }
        public override double dienTich()
        {
            return Dai * Rong;
        }

        public override void hienthi()
        {
            Console.WriteLine("Hinh Vuông : Cạnh:" + Dai);
        }
        public override double chuvi()
        {
            return 4 * Rong;
        }
    }
}
