using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT
{
    internal class B4SumAm
    {
      static void Main()
        {
            int n = default;
            int[] N = new int[10];
            int biếnđếm = 0;
            
            for (int i = 0; i < N.Length; i++)

            {
                Nhap(out n);
                if (n <= 100)
                {
                    N[i] = n;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("============================");
            Console.Write("Liet Ke:");
            for (int i = 0; i < N.Length; i++)
            {
              
                
                    Console.Write(N[i] + " ");
               
            }
            Console.WriteLine();
            Console.Write("So am: ");
            foreach (var item in N)
            {
            
                if (item < 0)
                {
                    biếnđếm++;
                    Console.Write(item + " ");
                }
              
            }
            Console.WriteLine();
            Console.WriteLine("Tong so am = " + biếnđếm);
            
            
        }
        public static void Nhap(out int i)
        {
            Console.WriteLine("Nhap so N:");
            i = Convert.ToInt32(Console.ReadLine());
        }
    }
}
