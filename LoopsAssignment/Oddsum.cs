using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Oddsum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 30; i++)
            {
                if (i % 2 != 0)
                {
                     sum = sum + i;
                    Console.WriteLine(i);
                    Console.WriteLine("The sum of odd is : "+sum);
                }
                


            }
        }
    }
}
