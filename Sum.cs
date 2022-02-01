using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Demosai
    {
        static void Main(string[] args)
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
