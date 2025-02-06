using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciple.Inheritance
{
    public class Vehicle
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }


        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }


        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping.");
        }
    }
}