using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class SumOfCube
    {
        public static void Main(string[] args)
        {
            int num = 234;
            int sum = 0;
            while (num > 0)
            {
                int rem = num % 10;
                sum = sum + (rem * rem * rem);
                num /= 10;
               
            }
            Console.WriteLine(sum);
        }
    }
}
