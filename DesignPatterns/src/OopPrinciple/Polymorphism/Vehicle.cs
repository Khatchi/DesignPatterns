using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciple.Polymorphism
{
    public class Vehicle
    {
        
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }

        
        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping.");
        }
    }
}