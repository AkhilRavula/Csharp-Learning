using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate_2
{
    internal class Rectangle
    {
        public void GetArea(double width,double length)
        {
            Console.WriteLine(width * length);
        }

        public void GetPerimeter(double width,double heiight)
        {
            Console.WriteLine(2 * (width + heiight));
        }
    }
}
