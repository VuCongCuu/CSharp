using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT
{
    internal class B2GTLN
    {
        static void Main()
        {
            int[] avg = new int[100];
            for(int i = 0; i < avg.Length; i++)
            {
                Console.Write("Nhap so " +(i+1)+":");
                avg[i] = Convert.ToInt32(Console.ReadLine());
                if(avg[i] == 0)
                {
                    break;
                }
            }
            int maxValue = avg[0];
            for (int i = 1; i < avg.Length; i++)
            {
                if (avg[i] > maxValue)
                {
                    maxValue = avg[i];
                }
            }
            Console.WriteLine("===========================");
            Console.WriteLine("GTLN : " +maxValue);
            
        }
    }
}
