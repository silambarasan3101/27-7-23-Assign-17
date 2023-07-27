using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_7_23_Assign_17
{
    public class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }   
        public Rectangle(double width, double height)
        {
            ShapeType = "Rectangle";
            Width = width;
            Height = height;
        }      
        public override double Area => Width * Height;
        public override double Perimeter => 2 * (Width + Height);
    }
}
