using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    internal class Program
    {
        public static int Menu()
        {
            int chon;
            Console.WriteLine("1.Nhâp nhân viên kinh doanh");
            Console.WriteLine("2.Nhập nhân viên kỹ thuật");           
            Console.WriteLine("3.Hiển thị thông tin");
            Console.WriteLine("4.Thoat");
            Console.WriteLine("Mời chọn");
            chon = Convert.ToInt32(Console.ReadLine());
            return chon;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien[] dsNhanVien = new NhanVien[10];

            while (true)
            {
            int choose = Menu();
            switch (choose)
            {
                case 1:
                        Console.WriteLine("Nhập sô lượng nhân Viên Kinh doanh");
                        int slm = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap nhan vien kinh doanh");
                    for(int i = 0; i < slm; i++)
                    {
                        dsNhanVien[i] = new NhanVienKinhDoanh();
                        dsNhanVien[i].nhap();
                    }
                    break;
                case 2:
                   Console.WriteLine("Nhập sô lượng nhân viên Kỹ thuật");
                    int sln = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap nhan vien kỹ thuât");
                        int biendem1 = 0;
                        for (int i = 0; i < dsNhanVien.Length; i++)
                        {
                            if (dsNhanVien[i] != null)
                            {
                                biendem1++;
                            }
                        }
                        for (int i = biendem1; i < biendem1+sln; i++)
                    {
                        dsNhanVien[biendem1] = new NhanVienKyThuat();
                        dsNhanVien[biendem1].nhap();
                    }
                    break;
                case 3:
                        Console.WriteLine("3.Hiển thị thông tin\n");
                        
                        int biendem = 0;
                        for( int i = 0; i < dsNhanVien.Length; i++)
                        {
                            if (dsNhanVien[i] != null)
                            {
                                biendem++;
                            }
                        }
                        for (int i = 0; i < biendem; i++)
                    {
                        dsNhanVien[i].hienthi();
                    }
                    break;
                if(choose >= 4)
                        {
                            break;
                        }
            }

            }
        }
    }
}
