
using System;
class DemoSai
{
    public static void Main()
    {
        int a;
            Console.WriteLine("Enter a number to check : ");
               a=int.Parse(Console.ReadLine());
        if(a%2 == 0)
        {
            Console.WriteLine("Even Number");
        }
        else
        {
            Console.WriteLine("Odd Number");
        }
    }
}