using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    //indexers

    //access modifier return type this [agrunmnets_list]
    class IndexerCreation
    {
        private string[] val = new string[3];

        public string this[int index]
        {
            get
            {
                return val[index];
            }
            set
            {
                val[index] = value;
            }
        }

    }

    class Program4
    {
        public static void Main4()
        {
            IndexerCreation ic = new IndexerCreation();
            ic[0] = "JAVA";
            ic[1] = "C#";
            ic[2] = "PYTHON";
            Console.WriteLine("First Value= {0}", ic[0]);
            Console.WriteLine("Second Value = {0}", ic[01]);
            Console.WriteLine("Third Value = {0}", ic[2]);
            Console.ReadLine();
        }
    }
}
