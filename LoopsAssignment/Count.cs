using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Count
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter input to count digit :");
            long n= long.Parse(Console.ReadLine());

            do
            {
                n /= 10;
                ++count;

            } while (n != 0);
            Console.WriteLine("Number of digits is : "+count);

        }
        
    }
}
