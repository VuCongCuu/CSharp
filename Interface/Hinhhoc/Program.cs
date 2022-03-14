using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinhhoc
{
    internal class Program
    {
        static void word(hinh hinh)
        {
            hinh.nhap();
            hinh.hienthi();
            Console.WriteLine("Dien tich : " + hinh.dienTich());
            Console.WriteLine("Chu vi : " + hinh.chuvi());
        }
        static void Main(string[] args)
        {
            HinhChuNhat hcn= new HinhChuNhat();
            Hinhtron htron= new Hinhtron();
            HinhVuong hV = new HinhVuong();
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                int i=Menu();
                switch (i)
                {
                    case 1:
                        word(hV);
                        break;
                    case 2:
                        word(htron);
                        break;
                    case 3:
                        word(hcn);
                        break;
                    default:
                        break;
                    
                }
                if (i > 3)
                {
                    break;
                }
            }

        }
        public static int Menu()
        {
            int chon;
            Console.WriteLine("1.Hinh Vuong");
            Console.WriteLine("2.Hinh Tròn");
            Console.WriteLine("3.Hinh Chữ nhật");
            Console.WriteLine("4.Thoat");
            Console.WriteLine("Nhập chọn:");
            chon= Convert.ToInt32(Console.ReadLine());
            return chon;
        }
    }
}
