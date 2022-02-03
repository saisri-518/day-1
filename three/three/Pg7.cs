using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three
{
    class Pg7
    {
        static void Main7(string[] args)
        {
            Laptop lp = new Laptop();
            Console.ReadLine();


            lp.ShowDetails(Laptop.Lenovo, Laptop.Price1000, Laptop.i3, Laptop.Ram2GB, Laptop.HD500GB);
            Console.WriteLine("\n\n*************************************\n");
            Console.ReadLine();

            lp.ShowDetails(Laptop.Dell, Laptop.Price1500, Laptop.i5, Laptop.Ram4GB, Laptop.HD1TB);
            Console.WriteLine("\n\n*************************************\n");
            Console.ReadLine();

            lp.ShowDetails(Laptop.Sony, Laptop.Price2000, Laptop.i9, Laptop.Ram8GB, Laptop.HD1TB);
            Console.WriteLine("\n\n*************************************\n");
            

            Console.ReadKey();
        }
    }
    class Laptop : LaptopBase
    {
        public void ShowDetails(string name, string price, string processor, string ram, string hdd)
        {
            Console.WriteLine("Name : " + name);
            
            Console.WriteLine("Price : " + price);
            
            Console.WriteLine("Processor : " + processor);
            
            Console.WriteLine("Ram : " + ram);
            
            Console.WriteLine("HDD : " + hdd);
            
        }
    }

    class LaptopBase
    {
        public const string i3 = "i3";
        public const string i5 = "i5";
        public const string i7 = "i7";
        public const string i9 = "i9";

        public const string Ram2GB = "2GB";
        public const string Ram4GB = "4GB";
        public const string Ram8GB = "8GB";

        public const string HD500GB = "500GB";
        public const string HD1TB = "1TB";

        public const string Price1000 = "$1000";
        public const string Price1500 = "$1500";
        public const string Price2000 = "$2000";

        public const string Lenovo = "Lenovo";
        public const string Sony = "Sony";
        public const string Dell = "Dell";
    }
}