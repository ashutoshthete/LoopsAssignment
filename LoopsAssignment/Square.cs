using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Square
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i <= 20; i++)
            {
                int Square = i * i;
                Console.WriteLine("square of :"+i+ " = " +Square);
            }
        }
    }
}
