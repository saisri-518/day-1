using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public struct Person
    {
        public string Name;
        public int Age;
        public int Weight;
    }
    class Program
    {
        public static void Main1()
        {
            Person person;
            person.Name = "saisri";
            person.Age = 21;
            person.Weight = 55;

            Console.WriteLine("Data is stored in person Name:" + person.Name);
            Console.WriteLine("Data is stored in person Age:" + person.Age);
            Console.WriteLine("Data is stored in person Weight" + person.Weight);
            Console.ReadLine();
        }
    }
}
