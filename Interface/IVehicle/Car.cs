using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicle
{
    public class Car : Vehicles
    {
        private string color;
        
        public Car() :base() { }
        public string Color { get => color; set => color = value; }
        public Car(string maker, string model, double price,string color) : base(maker, model, price)
        {
            this.color = color;
        }
        public override void display()
        {
            Console.WriteLine("Car:");
            base.display();
            Console.WriteLine("Color :" +Color);
            Console.WriteLine("===========================");

        }
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhập Color:");
            this.color = Console.ReadLine();
        }

    }
}
