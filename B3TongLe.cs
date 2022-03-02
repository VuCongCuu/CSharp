using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT
{
    internal class B3TongLe
    {
        static void Main()
        {
            int n=default;
            int [] N = new int[10];
            int biếnđếm = 0;
            int sum = 0;
            for (int i = 0; i <N.Length; i++)
            
            {
                Nhap(out n);
                if (n <= 100)
                {
                    N[i] = n;
                }else
                {
                    break;
                }
            }
            foreach (var item in N)
            {
                Console.Write(item+" ");
                if (item % 2 != 0)
                {
                    biếnđếm++;
                    sum +=item;
                }
            }
            Console.WriteLine();
           Console.WriteLine("Tong le = "+sum);
           

        }
        public static void Nhap(out int i)
        {
            Console.WriteLine("Nhap so N:");
             i=Convert.ToInt32(Console.ReadLine());
        }
    }
}
