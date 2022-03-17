using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static int Menu()
        {
            int choice;
            Console.WriteLine("1.Thêm");
            Console.WriteLine("2. Hiên thị");
            Console.WriteLine("3. Xóa");
            Console.WriteLine("4. Thoát");
        inputChoice:
            try
            {
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid choice!");
                goto inputChoice;
            }
            return choice;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ProductManager productManager = new ProductManager();
           
            int choice;
            do
            {
                Console.Clear();
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        productManager.AddProduct();
                        break;
                    case 2:
                        Console.Clear();
                        productManager.DisplayProducts();
                        break;
                    case 3:
                        Console.Clear();
                        productManager.DeleteProduct();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            } while (choice != 4);
        }

    }
}
