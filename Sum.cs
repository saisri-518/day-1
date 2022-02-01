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
            int i,j;
            int r=int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=1;i<=r;i++)
            {
                for(int j=1;j<=i;j++){
                    Console.Write("*");
                    Console.WriteLine("/n");

                }
                Console.ReadLine();
            }
            
        }
    }
}
