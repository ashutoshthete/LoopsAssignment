using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Break
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i <= 30; i++)
            {
                Console.WriteLine(i);
                if (i >= 15)
                {
                    
                    break;
                }
            }
        }
    }
}
