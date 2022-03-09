using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT
{
    internal class B1TinhGiaiThua
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so n");
            int n;
            int S = 1;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                S *= i;
            }
            Console.WriteLine("Cach 1");
            Console.WriteLine("n! = " + S);
            Console.WriteLine("Cach 2");
            Console.WriteLine("n! = " + GiaiThua(n));
            Console.WriteLine("Cach 3");
            Console.WriteLine("n! = " + GT(n));

        }
        public static int GiaiThua(int k)
        {
            int j = 1;
            for (int i = 1; i <= k; i++)
            {
                j *= i;
            }
            return j;
        }
        //đê quy
        public static int GT (int n)
         {
                if(n==1||n==0){
                return 1;
            } else{
                return n*GT(n-1);
            }

         }
    }
}
