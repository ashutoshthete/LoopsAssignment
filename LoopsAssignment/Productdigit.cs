using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Productdigit
    {
        public static void Main(string[] args)
        {
            int count = 0;
            long product = 0;
            Console.WriteLine("Enter the input :");
            long n = long.Parse(Console.ReadLine());

            do
            {
                n /= 10;
                
                ++count;
               

            } while (n != 0);
        }
    }
}
