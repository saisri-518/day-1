using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Day11
{
    internal class Program3
    {
        static void Main2(string[] args)
        {
            Thread thread = new Thread(MethodJoin);
            thread.Start();
            thread.Join();
            thread.Abort();
        }
        static void MethodJoin()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work in progress");
            }
        }
    }
}
