using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__6___Option_2__Shape_.Classes
{
    public class Shape
    {
        private string _name;
        private string _color;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                Console.WriteLine($"Setting name to {value}");
                _name = value;
            }
        }
        public string Color
        {
            get { return _color; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Color cannot be null or empty");
                }
                Console.WriteLine($"Setting color to {value}");
                _color = value;
            }
        }
        public int[] Position { get; set; }

        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area");
        }
        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }
        public virtual void Move(Shape shape) {
            shape.Position[0] += 5;
            shape.Position[1] += 5;
        }
    }
}
