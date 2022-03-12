using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien[] listSV;
                Console.WriteLine("Nhập sô lương sinh viên của lớp:");
                int sl= Convert.ToInt32(Console.ReadLine()); ; 
            while (true)
            {
                Console.WriteLine("========================================");
                menu();
                int choose;
                choose= Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                   
                    case 1:
                        Console.WriteLine("Nhập Danh sách sinh viên");
                        listSV = SinhVienDao.addSV(sl);
                                     
                        break;
                    case 2:
                        Console.WriteLine(" Danh sách sinh viên");
                        SinhVienDao.DsSinhVien(sl);
                        break;   
                    case 3:
                        Console.WriteLine("3.Sắp xếp Danh sách theo Điểm giảm dần");
                     
                        break;
                    case 4:
                        Console.WriteLine("Tìm họ tên theo từ khóa");
                        SinhVienDao.TimKiem(sl);
                       
                        break;

                    default:
                        break;

                }

                if (choose == 5)
                {
                    break;
                }
            }
        }
        public static void menu (){
            Console.WriteLine("1.Nhập Danh sách sinh viên");
            Console.WriteLine("2.Hiển thị Danh sách sinh viên");
            Console.WriteLine("3.Sắp xếp Danh sách theo Điểm giảm dần");
            Console.WriteLine("4.Tìm họ tên theo từ khóa");
            Console.WriteLine("5.Thoát");
            Console.WriteLine("Nhap lựa chọn");

        }
    }
}
