using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hen1 = 8;
            int Hen2 = 13;
            int Hen3 = 6;
            int Hen4 = 73;
            int eggtotal = Hen1 + Hen2 + Hen3 + Hen4;
            int dozen = eggtotal / 12;
            int eggs = eggtotal % 12;
            Console.WriteLine("{0} dozen and {1} eggs", dozen, eggs);
        }
    }
}
