using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.SOLID.L
{
    public class Square : Shape
    {
       public double SideLength { get; set; }

       public override double Area =>  SideLength * SideLength;
    }
}