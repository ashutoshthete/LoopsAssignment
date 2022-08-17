using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int copy = num;

            while (num > 0)
            {
                int r = num % 10;
                sum = sum * 10 + r;

                num = num / 10;

            }
            if (sum == copy)
            {
                Console.WriteLine($"{copy} is palindrome");
            }
            else
            {
                Console.WriteLine($"{copy} is not palindrome");
            }
        }
    }
}
