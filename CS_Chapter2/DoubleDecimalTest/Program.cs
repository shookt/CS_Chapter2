using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleDecimalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double someMoney = 5.25;
            Console.WriteLine("The money is ${0}", someMoney);
            decimal someDecimal = 6.9m;
            Console.WriteLine(" The decimal is {0}", someDecimal);
        }
    }
}
