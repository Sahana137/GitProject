using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class JaggedArray
    {
        public static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 20, 15, 30, 40, 50 };
            arr[1] = new int[] { 90, 76, 50 };
            arr[2] = new int[] { 70, 50, 30, 20, 48 };
            Console.WriteLine("elements of arr are");
            foreach (int[] x in arr)
            {
                foreach(int y in x)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
