﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_7_23_Assign_17
{
    public class Triangle : Shape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }      
        public Triangle(double sideA, double sideB, double sideC)
        {
            ShapeType = "Triangle";
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override double Area
        {
            get
            {
               
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }

        public override double Perimeter => SideA + SideB + SideC;
    }

}


