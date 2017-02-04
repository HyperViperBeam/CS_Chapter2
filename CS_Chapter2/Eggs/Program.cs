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
            int Chicken1 = 120;
            int Chicken2 = 533;
            int Chicken3 = 477;
            int Chicken4 = 999;
            int total = Chicken1 + Chicken2 + Chicken3 + Chicken4;

            Console.WriteLine("Dozen: " + total / 12 + "eggs: " + total % 12);
        }
    }
}
