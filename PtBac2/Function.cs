using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtBac2
{
    internal class Function
    {
        public static void nhap(out double a, out double b, out double c)
        {
            Console.WriteLine("Nhập a:");
            a= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập c:");
            c = Convert.ToDouble(Console.ReadLine());
        }
        public static int HienThi(double a, double b, double c, ref double x1, ref double x2)
        {
            
            double detar = b * b - 4 * a * c;
            if( detar < 0)          
                return  0;
              
            else if  ( detar == 0)
            {
                 x1 = x2= -b / (2 * a);
                return  1;
            }
            else
            {
                x1 = (-b - Math.Sqrt(detar)) / (2 * a);
                x2 =  (-b + Math.Sqrt(detar)) / (2 * a);
                return 2;

            }
          
        }
    }
}
