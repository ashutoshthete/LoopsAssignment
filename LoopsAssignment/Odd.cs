using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Odd
    {
        public static void Main(string[] args)
        {

            int i = 521;
            int n = 229;
            while (i>=n)
            {
                
                i--;
                i = i - 2;
                Console.WriteLine(i);


            }
        }
    }
}
