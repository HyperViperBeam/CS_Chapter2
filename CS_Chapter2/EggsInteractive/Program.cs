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
            String Chicken1, Chicken2, Chicken3, Chicken4;
            int C1, C2, C3, C4;
            Console.WriteLine("Enter first number ");
            Chicken1 = Console.ReadLine();
            Console.WriteLine("Enter second number ");
            Chicken2 = Console.ReadLine();
            Console.WriteLine("Enter third number ");
            Chicken3 = Console.ReadLine();
            Console.WriteLine("Enter fourth number ");
            Chicken4 = Console.ReadLine();
            C1 = Convert.ToInt32(Chicken1);
            C2 = Convert.ToInt32(Chicken2);
            C3 = Convert.ToInt32(Chicken3);
            C4 = Convert.ToInt32(Chicken4);

            int total = C1 + C2 + C3 + C4;
            Console.WriteLine("Dozen: " + (total / 12) + " Eggs: " + (total % 10));
        }
    }
}
