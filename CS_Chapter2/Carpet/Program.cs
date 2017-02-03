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
            int length = 10;
            int width = 6;
            double carpeting = 762.86;
            Console.WriteLine("For a room " + length + "ft long" + " and " + width + "ft wide and a carpeting cost of " + "$" + carpeting + " per a square foot it'll cost you " + (length * width) * carpeting);
        }
    }
}
