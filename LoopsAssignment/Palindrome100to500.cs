using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Palindrome100to500
    {
        public static void Main(string[] args)
        {
            int range1 = 100;
            int range2 = 500;
            int num1 = 0;
            int num2 = 0;
            for(int i = range1; i <= range2; i++)
            {
                num1 = i;
                num2 = 0;
                while (num1 != 0)
                {
                    int rem = num1 % 10;
                    num1 /= 10;
                    num2 = num2 * 10 + rem;
                }
                if (i == num2)
                {
                    Console.WriteLine(i+" ");
                }
            }
            
        }
        

    }
}

