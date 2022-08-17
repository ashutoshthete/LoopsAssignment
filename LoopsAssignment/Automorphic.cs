using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Automorphic
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number to check:");
            num = int.Parse(Console.ReadLine());
            int sqrt = num * num;
            int t = num;
            int l = 0;
            while (t > 0)
            {
                t = t / 10;
                l++;
            }
            int end = sqrt %(int)Math.Pow(10, l);
            if (num == end)
            {
                Console.WriteLine("It is automorphic number");
            }
            else
            {
                Console.WriteLine("It is not automorphic number");
            }
        }
    }
}
