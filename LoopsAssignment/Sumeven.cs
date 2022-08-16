using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Sumeven
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 20; i++)
            {
                if (i%2==0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                    Console.WriteLine("the sum of even " +sum);
                }

            }
        }
    }
}
