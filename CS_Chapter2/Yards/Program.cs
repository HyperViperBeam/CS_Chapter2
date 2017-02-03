using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            double carpeting = 69.69;
            int length = 25;
            int width = 42;

            int yards = (length * width) / 9;
            Console.WriteLine("Room carpeting will cost " + (yards * carpeting));
        }
    }
}
