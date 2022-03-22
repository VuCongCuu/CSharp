using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinder
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double Radius, Height, BaseArea, LateralArea, TotalArea, Volume;
            Radius = 0;
            Height = 0;
            Cylin.nhap(out Radius, out Height);
            Cylin.HienThi(Radius, Height);
        }
    }

    
}
