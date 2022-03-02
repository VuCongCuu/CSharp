using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT
{
    internal class B5.SNT
    {
        static void Main (string[] args) 
        {
            int a,biendem;
            biendem = 0;
            Console.Write("Nhap so a: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================");
            for(int i = 1; i <= a; i++)
            {
                if ( a % i == 0)
                {
                  biendem++;
                }
            }
            if(biendem > 2)
            {
                Console.WriteLine($"{a} khong la so nguyen to");
            } else
            {
                Console.WriteLine($"{a} la so nguyen to");

            }

        }
    }
}
