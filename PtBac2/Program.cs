using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtBac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a,b,c,x1,x2;
            
            x1 = 0; x2 = 0;
            Function.nhap(out a, out b, out c);
            int i = Function.HienThi(a,b,c,ref x1,ref x2);
            if(i == 0)
            {
                Console.WriteLine("Phương trinh vô nghiệm");
            } else if(i == 1)
            {
                Console.WriteLine("Phương trinh có 1 nghiêm x1=x2={0}",x1);
            }
            else
            {
                Console.WriteLine("Phương trình có 2 nghiệm x1 = {0}, x2 = {1}",x1,x2);
            }
        }
    }
}
