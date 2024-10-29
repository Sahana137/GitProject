using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class IfCondition
    {
         public static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter the x value");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the y value");
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (x < y)
            {
                Console.WriteLine("x is less than y");
            }
            else
            {
                Console.WriteLine("x is equal to y: x=y");
            }
        }
    }
}
