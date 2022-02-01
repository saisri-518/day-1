
using System;
class DemoSai
{
    public static void Main()
    {
        int n1=int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=1;i<=n1;i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}