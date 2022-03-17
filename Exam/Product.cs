using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Product
    {
        protected string productId;
        protected string productName;
        protected double price;

        public Product()
        {
            this.productId = "";
            this.productName = "";
            this.price = 0;
        }

        public Product(string productId, string productName, double price)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
        }

        public string ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public void Input()
        {
            Console.Write("Enter product id: ");
            this.productId = Console.ReadLine();
            Console.Write("Enter product name: ");
            this.productName = Console.ReadLine();
        inputPrice:
            try
            {
                Console.Write("Enter product price: ");
                this.price = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid price!");
                goto inputPrice;
            }
        }

        public override string ToString()
        {
            return "ID: " + productId + " | Name: " + productName + " | Price: " + price;
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
