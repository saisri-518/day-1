using System;

namespace three
{

    class A
    {
        int amember;
        public A(int _amember)
        {
            amember = _amember;
        }
        public void PrintA()
        {
            Console.WriteLine(amember);
        }
    }
    class B : A
    {
        int bmember;
        public B(int _bmember) : base(_bmember)
        {
            bmember = _bmember;
        }
        public void PrintB()
        {
            Console.WriteLine(bmember);
        }
    }
    class C : B
    {
        int cmember;
        public C(int _cmember) : base(_cmember)
        {
            cmember = _cmember;
        }
        public void PrintC()
        {
            Console.WriteLine(cmember);
        }
    }
    class Pg2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            C cobject = new C(3);
            cobject.PrintA();
            cobject.PrintB();
            cobject.PrintC();

        }
    }
}
