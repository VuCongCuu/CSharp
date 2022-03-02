using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT
{
    internal class PhuongTrinhBac2
    {
       static void Main()
        {
            float a,b,c,d;
            while (true)
            {
            nhap(out a, out b, out c);
            d = (b * b) - (4 * a * c);

            hienthi(a, b, c, d);
                Console.WriteLine("Ban co muon tiep tuc khong(n_No/y_Yes):");
                string check =Console.ReadLine();
                Console.WriteLine("======================================");
                if (check.Contains("n"))
                {
                    break;
                }

            }
            
        }
        public static void nhap(out float a,out float b,out float c)
        {
            Console.WriteLine("Giai phuong trinh: ax^2+bx+c=0");
            Console.WriteLine("Nhap a");
            a =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap b");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap c");
            c = Convert.ToSingle(Console.ReadLine());

        }
        public static void hienthi1(float a, float b, float c, float d)
        {
           // Console.WriteLine("Phuong trinh : " +(d<0)?"Vo ngiem":((d==0)?"co 1 nghiem trung x1 = x2 =" + (-b / (2 * a)):(d>0)?(d>0)?"co 2 nghiem x1= "+ (-b - Math.Sqrt(d)) / (2 * a) +"x2 = "+ (-b + Math.Sqrt(d)) / (2 * a)));
           // Console.WriteLine("Phuong trinh : " + (d < 0) ? "Vo ngiem":(d == 0)? "co 1 nghiem trung x1 = x2 =" + (-b / (2 * a)): (d > 0) ? "co 2 nghiem x1= " + (-b - Math.Sqrt(d)) / (2 * a) + "x2 = " + (-b + Math.Sqrt(d)) / (2 * a)) );
        }
        public static void hienthi(float a,float b,float c,float d)
        {
            if (d < 0)
            {
                Console.WriteLine("Phương trinh vo nghiem");
            }
            else if (d == 0)
            {
                Console.WriteLine("Phuong trinh co 1 nghiem: x1=x2=" + (-b / (2 * a)));
            }
            else
            {
                Console.WriteLine($"Phuong trinh co 2 nghiem: x1 = {(-b - Math.Sqrt(d)) / (2 * a)} | x2 = {(-b + Math.Sqrt(d)) / (2 * a)}");
            }
        }
    }
}

