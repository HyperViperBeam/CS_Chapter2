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
            int minutes = 367;
            int hours =  367 / 60;

            minutes = minutes - (hours * 60);

            Console.WriteLine("Hours: " + hours + " Minutes: " + minutes);
        }
    }
}
