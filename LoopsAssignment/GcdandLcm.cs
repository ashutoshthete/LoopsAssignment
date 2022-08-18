using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class GcdandLcm
    {
      
        public static void Main(string[] args)
        {
            int num1, num2, gcd, lcm, remainder, numerator, denominator;
            Console.WriteLine("Enter first numbers ");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second numbers ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                numerator = num1;
                denominator = num2;
            }
            else
            {
                numerator = num2;
                denominator = num1;
            }

            remainder = numerator % denominator;

            while (remainder != 0)
            {
                numerator = denominator;
                denominator = remainder;
                remainder = numerator % denominator;

            }
            gcd = denominator;
            lcm = num1 * num2 / gcd;
            Console.WriteLine("GCD of "+num1+" and "+num2+" is :"+gcd);
            Console.WriteLine("LCM of "+num1+" and "+num2+" is :"+lcm);

            

        }
    }
}
