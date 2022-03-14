using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicle
{
    public  class Vehicles: IVehicle
    {
       private string maker;
       private string model;
        private double price;

        public string Maker { get => maker; set => maker = value; }
        public string Model { get => model; set => model = value; }
        public double Price { get => price; set => price = value; }
        public Vehicles() { }
        public Vehicles(string maker,string model,double price)
        {
            this.maker = maker;
            this.model = model;
            this.price = price;
        }
        public virtual void display()
        {
            Console.WriteLine("Maker :" + Maker);
            Console.WriteLine("Model :" + Model);
            Console.WriteLine("Price :" + Price);

        }

        public virtual void input()
        {
            Console.WriteLine("Nhập Maker:");
            this.maker= Console.ReadLine();
            Console.WriteLine("Nhập Model:");
            this.model = Console.ReadLine();
            Console.WriteLine("Nhập Price:");
            this.price = Convert.ToDouble(Console.ReadLine());
        }
    }
}
