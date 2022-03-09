using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT
{

    internal class Mang
    {
        static int nhap (int[] arr)
        {
            int n;
            do
            {
                Console.WriteLine("Nhập số phần tử (0-50):");
                n = Convert.ToInt32(Console.ReadLine());
             
            } while (n <= 0 || n > 50);
            Console.WriteLine("Nhập các phần tử của mảng");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Phan tử thứ " +(i+1) +":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
                
            return n;
        }
        static void Hienthimang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = new int[52];
            int i;
            Console.WriteLine("Nhập mảng:");
            i = nhap(arr);
            Console.WriteLine("Hiển thị mảng");
            Hienthimang(arr,i);

        }
    }
}
