using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsAssignment
{
    class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the range: ");
            int range = int.Parse(Console.ReadLine());
            for (int i= 1; i <= range; i++)
            {
                 
                Console.WriteLine(num*i);
            }
        }
    }
}
