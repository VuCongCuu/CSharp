using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT
{
    internal class B1SapXep
    {
         static void Main()
        {
            int[] N = new int[100];
            Random random = new Random();
            for (int i = 0; i <N.Length; i++)
            {
                N[i] = random.Next(1,100);
                Console.Write(N[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine("Đô dai mang: "+N.Length);
            //săp xếp
            Array.Sort(N); //Tăng dần
            Array.Reverse(N);//Giam dần
            Console.WriteLine("=============================");
            Console.WriteLine("Sap xep giam dân");
            foreach (var item in N)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
