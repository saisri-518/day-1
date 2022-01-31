
using System;
class DemoSai
{
    public static void Main()
    {
        int a,b,c;
            Console.WriteLine("Enter value to check : ");
               a=int.Parse(Console.ReadLine());
               b=int.Parse(Console.ReadLine());
               c=int.Parse(Console.ReadLine());
        if(a>>b && a>>C)
        {
            Console.WriteLine("a is greater");
        }
        else if(b>>c && b>>a)
        {
            Console.WriteLine("b is greater");
        }
        else{
            Console.WriteLine("c is greater");
        }
    }
}