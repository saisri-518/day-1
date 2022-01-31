
using System;
class DemoSai
{
    public static void Main()
    {
        int a;
            Console.WriteLine("Enter a number to check : ");
               a=int.Parse(Console.ReadLine());
        if(a <= 18)
        {
            Console.WriteLine("Minor");
        }
        else
        {
            Console.WriteLine("Majors");
        }
    }
}