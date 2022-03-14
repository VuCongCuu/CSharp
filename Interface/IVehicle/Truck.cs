using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicle
{
    public class Truck : Vehicles
    {
        private int truckload;

        public int Truckload { get => truckload; set => truckload = value; }
        public Truck() :base(){}
        public Truck(string maker, string model, double price,int truckload) : base(maker, model, price)
        {
            this.truckload = truckload;
        }
        public override void display()
        {
            Console.WriteLine("Truck:");
            base.display();
            Console.WriteLine("Truckload : " +truckload);
            Console.WriteLine("===========================");
        }

        public override void input()
        {     
            base.input();
            Console.WriteLine("Nhập Truckload:");
            this.truckload = Convert.ToInt32(Console.ReadLine());
        }
    }
}
