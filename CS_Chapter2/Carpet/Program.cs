using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 25;
            Console.WriteLine("The width of the room is {0} feet", width);
            double length = 30;
            Console.WriteLine("The length of the room is {0} feet", length);
            double area = length * width;
            Console.WriteLine("The area of the room is {0} square feet", area);
            Console.WriteLine("The cost of carpeting is $1.53 per square foot.");
            double price = area * 1.53;
            Console.WriteLine("The total cost of your carpeting is {0}", price.ToString("C"));
        }
    }
}
