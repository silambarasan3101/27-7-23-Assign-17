using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_7_23_Assign_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Circle circle = new Circle(3);
            circle.PrintInfo();
            Console.WriteLine($"Area of Circle: {circle.Area}");
            Console.WriteLine($"Perimeter of Circle: {circle.Perimeter}");
            Console.WriteLine("----------------------");

            Rectangle rectangle = new Rectangle(4, 7);
            rectangle.PrintInfo();
            Console.WriteLine($"Area of Rectangle: {rectangle.Area}");
            Console.WriteLine($"Perimeter of Rectangle: {rectangle.Perimeter}");
            Console.WriteLine("----------------------");

            Triangle triangle = new Triangle(5,6,7);           
            triangle.PrintInfo();                              
            Console.WriteLine($"Area of Triangle: {triangle.Area}");
            Console.WriteLine($"Perimeter of Triangle: {triangle.Perimeter}");

            Console.ReadKey();
        }
    }
}
