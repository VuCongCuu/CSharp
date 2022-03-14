using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicle
{
    internal class Program
    {
        public static int Menu()
        {
            int chon;
            Console.WriteLine("1. Input");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Sort by price");
            Console.WriteLine("4. Search by model.");
            Console.WriteLine("Mời chọn");
            chon = Convert.ToInt32(Console.ReadLine());
            return chon;
        }
        public void Timkiem(Vehicles v)
        {
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Vehicles[] vehicles = new Vehicles[20];
             Console.WriteLine("Nhâp số lượng:");
            int loaixe;
             int sl= Convert.ToInt32(Console.ReadLine());
            while (true)
            {
            int choose= Menu();
            switch (choose)
            {
                    case 1:
                        for (int i = 0; i < sl; i++)
                        {
                            do
                            {
                                Console.WriteLine("Nhập loại(1-Car|2- Truck)");
                                loaixe = Convert.ToInt32(Console.ReadLine());
                            } while (loaixe < 1 || loaixe > 2);
                            if (loaixe == 1)
                            {
                                vehicles[i] = new Car();
                            }
                            else
                            {
                                vehicles[i] = new Truck();
                            }
                            vehicles[i].input();
                        }
                        break;
                     case 2:
                        Console.WriteLine("Hiển thị danh sách \n");
                            for(int i = 0; i < sl; i++)
                        {
                            vehicles[i].display();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Sắp xếp \n");
                        Vehicles v;
                        for(int i = 0; i < sl-1; i++)
                        {
                            for(int j = i+1; j < sl; j++)
                            {
                                if(vehicles[i].Price > vehicles[j].Price)
                                {
                                    v = vehicles[i];
                                    vehicles[i] = vehicles[j];
                                    vehicles[j] = v;
                                }
                            }
                        }
                        for (int k = 0; k < sl; k++)
                        {
                            vehicles[k].display();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Tìm kiếm \n");
                            Console.WriteLine("Nhâp tư khóa");
                            string tk= Console.ReadLine();
                        for(int j = 0; j < sl; j++)
                        {
                            if (vehicles[j].Model.Contains(tk))
                            {
                                vehicles[j].display();
                            }
                        }
                        break;
                        default:
                        break;


            }
                if(choose> 4 || choose < 1)
                {
                    break;
                }
            }
               
        }
    }
}
