using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class ProductManager
    {
        public List<Product> products = new List<Product>();

        public void AddProduct()
        {
            Product product = new Product();
            product.Input();
            products.Add(product);
        }

        public void DeleteProduct()
        {
            Console.Write("Enter product id to delete: ");
            string productId = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductId == productId)
                {
                    count++;
                    products.RemoveAt(i);
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Product not found!");
            }
            else
            {
                Console.WriteLine("Product deleted!");
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("{0, -10} {1, -20} {2, -10}", "ID", "Name", "Price");
            foreach (Product product in products)
            {
                product.Output();
            }
        }
    }
}
