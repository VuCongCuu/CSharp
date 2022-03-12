using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    internal class SinhVienDao
    {
        public static SinhVien[] listSV = new SinhVien[30];

        //index

        public SinhVien this[int i]
        {
            get { return listSV[i]; }
            set { listSV[i] = value; }
        }

        public static SinhVien[] addSV(int sl)
        {
            if (sl != null)
            {
                for (int i = 0; i < sl; i++)
                {
                    listSV[i] = new SinhVien();
                    listSV[i].nhap();
                }

            }
            return listSV;
        }
        public static void DsSinhVien(int sl)
        {
            for (int i = 0; i < sl; i++)
            {
                listSV[i].hienthi();
            }

        }
        public static void SapXep(int n)
        {
            
          
        }
   

        public static void TimKiem(int sl)
        {
            Console.WriteLine("Nhập từ khóa tìm kiếm:");
            string s = Console.ReadLine( );
            for (int i = 0; i < sl; i++)
            {
                if (listSV[i].Name.Contains(s))
                {
                    listSV[i].hienthi();
                }
            }        
        }
    }
}
