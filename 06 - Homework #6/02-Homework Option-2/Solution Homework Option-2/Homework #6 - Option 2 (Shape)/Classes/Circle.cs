using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__6___Option_2__Shape_.Classes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) {
            Radius = radius;
        }

        public override void GetArea()
        {
            double area = (Radius * Radius) * 3.14;
            Console.WriteLine($"The circle area is {area}");

        }
        public override void GetPerimeter()
        {
            double perimeter = 2 * 3.14 * Radius;
            Console.WriteLine($"The circle perimeter is {perimeter}");
        }
    }
}

