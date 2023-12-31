﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_7_23_Assign_17
{
    public class Shape
    {
        public string ShapeType { get; protected set; }
        public virtual double Area { get; }
        public virtual double Perimeter { get; }

        public void PrintInfo()
        {
            Console.WriteLine("ShapeType: " + ShapeType);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Perimeter: " + Perimeter);
            Console.WriteLine("\n");
        }
    }
}
