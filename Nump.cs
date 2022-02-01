using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class DemoSai
    {
        static void Main(string[] args)
        {
            int n = 1;
            for(int i=1;i<=4;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n+" ");
                    n++;
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}