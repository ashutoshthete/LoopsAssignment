using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Primenumbers
    {
        public static void Main(string[] args)
        {
            
            int c = 0;
            for(int i=302;i<400;i++)
            {
                if (400 % i == 0)
                {
                    Console.WriteLine("not prime"+i);
                    c = 1;
                    continue;
                }
                else if (c == 0)
                {
                    Console.WriteLine("prime" + i);
                }
            }
           
            
        }
    }
}
