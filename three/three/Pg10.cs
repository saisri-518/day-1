using System;
using System.Collections.Generic;
using System.Text;

namespace three
{

    public interface IA
    {
        void method1();
    }

    //interface inheritance
    public interface IB : IA
    {
        void method2();
    }
    class Z : IB
    {

        public void method2()
        {
            Console.Read();
            Console.WriteLine("Implemented method 2");
            
        }
        public void method1()
        {
            Console.Read();
            Console.WriteLine("Implemented method 1");
            

        }
    }
    class Pg10
    {

        public static void Main()
        {
            Z z = new Z();
            z.method1();
            z.method2();
        }

    }
}
