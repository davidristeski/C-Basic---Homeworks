using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__6___Option_2__Shape_.Classes
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public Rectangle(int sideA, int sideB) {
            SideA = sideA;
            SideB = sideB;
        }

        public override void GetArea()
        {
            int area = SideA * SideB;
            Console.WriteLine($"The area is {area}");
        }
        public override void GetPerimeter()
        {
            int perimeter = (SideA * 2) + (SideB*2);
            Console.WriteLine($"The perimeter is {perimeter}");
        }

    }
}
