using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Room
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 25;
            Console.WriteLine("The width of the room is {0} feet", width);
            double length = 30;
            Console.WriteLine("The length of the room is {0} feet", length);
            double area = length*width;
            Console.WriteLine("The area of the room is {0} square feet", area);
        }
    }
}
