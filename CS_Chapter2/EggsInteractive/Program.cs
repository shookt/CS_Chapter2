using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            string one, two, three, four;
            int Hen1, Hen2, Hen3, Hen4, eggtotal, dozen, eggs;
            Console.WriteLine("Enter egg number");
            one = Console.ReadLine();
            Hen1 = Convert.ToInt32(one);
            Console.WriteLine("Enter egg number");
            two = Console.ReadLine();
            Hen2 = Convert.ToInt32(two);
            Console.WriteLine("Enter egg number");
            three = Console.ReadLine();
            Hen3 = Convert.ToInt32(three);
            Console.WriteLine("Enter egg number");
            four = Console.ReadLine();
            Hen4 = Convert.ToInt32(four);
            eggtotal = Hen1 + Hen2 + Hen3 + Hen4;
            dozen = eggtotal / 12;
            eggs = eggtotal % 12;
            Console.WriteLine("{0} dozen and {1} eggs", dozen, eggs);
        }
    }
}
