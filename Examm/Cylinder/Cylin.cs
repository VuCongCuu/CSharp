using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder
{
    internal class Cylin
    {
        public static double BaseArea;
        public static double LateralArea;
        public static double TotalArea;
        public static double Volume;

        public static void nhap(out double Radius, out double Height)
        {
            Console.WriteLine("Nhập Radius :");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập Height:");
            Height = Convert.ToDouble(Console.ReadLine());          
        }
        public static void HienThi(double Radius, double Height)
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
            Console.WriteLine("Radius: "+Radius + "| Height :" + Height);
            Console.WriteLine("BaseArea: " + BaseArea + "|LateralArea :" + LateralArea + "|TotalArea " + TotalArea + " | Volume " + Volume);
          

        }
    }
}
