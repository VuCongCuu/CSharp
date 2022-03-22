using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class Animal
    {
        private string name;
        private double weight;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }

        public Animal() { }
        public Animal(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public void Nhap()
        {
            Console.WriteLine("Name");
            this.Name =Console.ReadLine();
            inputWeight:
            try
            {
                Console.WriteLine("Weight:");
                this.Weight = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Nhap cho dung");
                goto inputWeight;
            }
        }
        public void DisPlay()
        {
            Console.WriteLine("Name:" +Name + " | Weight :" +Weight);
        }
    }
}
