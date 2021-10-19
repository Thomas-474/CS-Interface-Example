using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_Example
{
    class Program
    {
        static void EL() => Console.WriteLine("");

        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            Sedan d = new Sedan(70);
            Truck t = new Truck(45, 500);

            Console.WriteLine($"The first sedan has a speed of {s.Speed}, {s.Wheels} wheels, and the license plate is {s.LicensePlate}.");
            Console.WriteLine($"The second sedan has a speed of {d.Speed}, {d.Wheels} wheels, and the license plate is {d.LicensePlate}.");
            Console.WriteLine($"The truck has a speed of {t.Speed}, {t.Wheels} wheels, and the license plate is {t.LicensePlate}.");
            EL();

            s.SpeedUp();
            d.SpeedUp();
            t.SpeedUp();

            Console.WriteLine($"The first sedan has a new speed of {s.Speed}.");
            Console.WriteLine($"The second sedan has a new speed of {d.Speed}.");
            Console.WriteLine($"The truck has a new speed of {t.Speed}.");

            Console.ReadKey();
        }
    }
}
