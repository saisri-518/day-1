using System;
using System.Collections.Generic;
using System.Text;

namespace three
{

    class DummyA
    {
        public void show()
        {
            Console.WriteLine("I am coming from A");
            Console.ReadLine();
        }
    }
    class DummyB : DummyA
    {
        public void show()
        {
            Console.WriteLine("I am coming from B");
            Console.ReadLine();
        }
    }
    class Pg4
    {

        static void Main5(string[] args)
        {
            DummyB B = new DummyB();
            B.show();//B

            DummyA A = new DummyB();
            A.show();//A  ==>B

            DummyA Obj = new DummyA();
            Obj.show(); //A

            Obj = new DummyB();
            Obj.show();//A  ===>B
        }
    }
}
