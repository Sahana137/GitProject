using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class ChangeArraySize
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[] { 50, 10, 40, 60, 20 };
            Console.WriteLine("elements of array are");
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("enter the new size of array");

            int s = Convert.ToInt32((Console.ReadLine()));
            Array.Resize(ref arr, s);
            Console.WriteLine("element of new size array");
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
