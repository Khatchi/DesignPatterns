using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.SOLID.D
{
    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine started");

        }
    }
}