using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 198;
            int remainder = minutes % 60;
            int hours = minutes / 60;
            Console.WriteLine("{0} hours and {1} minutes", hours, remainder);

        }
    }
}
