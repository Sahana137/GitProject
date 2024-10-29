using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class MaxElements
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("enter the 10 elements ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            for (int i = arr.Length-1; i>arr.Length-4; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
