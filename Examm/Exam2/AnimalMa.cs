using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class AnimalMa
    {
        public Animal animal = new Animal();
        public List<Animal> list = new List<Animal>();

        public void Add()
        {
            animal.Nhap();
            list.Add(animal);
        }
        public void showL()
        {
            foreach(Animal animal in list)
            {
                animal.DisPlay();
            }
        }
    }
}
