
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class DemoSai
    {
        static void Main(string[] args)
        {
            int year=int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) 
                Console.WriteLine("Entered year "+year+" is a Leap Year");
            else
                Console.WriteLine("Entered year "+year+" is a not a Leap Year");
            Console.ReadLine();
        }
    }
}