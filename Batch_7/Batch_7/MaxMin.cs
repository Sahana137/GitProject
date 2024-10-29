using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class MaxMin
    {
        // finding maximum and minimum value
        //public static void Main(string[] args)
        //{
        //    int[] arr = new int[10] { 10, 3, 5, 6, 8, 14, 15, 25, 14, 17 };
        //    int[] max = new int[10];
        //    int[] min = new int[10];
        //    max[0] = arr[0];
        //    min[0] = arr[0];

        //for(int i = 0; i < arr.Length; i++)
        //    {
        //        for(int j=i+1; j < arr.Length; j++)
        //        {
        //            if (arr[i] > arr[j] )
        //            {
        //                max[i] = arr[i];
        //            }
        //            if (arr[i] < arr[j])
        //            {
        //                min[i] = arr[i];
        //            }
        //        }
        //    }
        //    Array.Sort(max);
        //    Array.Sort(min);
        //    Console.WriteLine(max[0]);
        //    Console.WriteLine(max[1]);
        //    Console.WriteLine(min[0]);
        //    Console.WriteLine(min[1]);
        //}


        // using built in functions
        //static void Main(string[] args)
        //{
        //    int[] myNumbers = { 5, 1, 8, 9 };
        //    Console.WriteLine(myNumbers.Max());  // returns the largest value
        //    Console.WriteLine(myNumbers.Min());  // returns the smallest value
        //    Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
        //}


        //summing second largest and second smallest value in an array
        public static void Main(string[] args)
        {
            int[] arr = { 2, 4, 5, 1, 8 };
            int result = SumSecondLargestAndSmallest(arr);
            Console.WriteLine("The sum of second smallest and second largest is: " + result);
        }
        static int SumSecondLargestAndSmallest(int[] arr)
        {
            int n = arr.Length;
            int smallest = arr[0], secondSmallest = arr[0];
            int largest = arr[0], secondLargest = arr[0];

        
            for (int i = 1; i < n; i++)
            {
                
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }


                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }

            }
            return secondSmallest + secondLargest;
        }
    }
}
