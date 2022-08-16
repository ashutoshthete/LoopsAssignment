using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Even
    {
        public static void Main(string[] args)
        {
            for(int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
