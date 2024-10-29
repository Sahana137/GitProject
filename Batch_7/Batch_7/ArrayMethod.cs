using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class ArrayMethod
    {
        public static void Main(string[] args)
        {
            int[] arrA = new int[6] { 50, 10, 40, 60, 20, 30 };
            int[] arrB = new int[12] { 15,25,35,0,0,0,0,0,0,0,0,0};
            Console.WriteLine("elements of array A are");
            foreach(int i in arrA)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n elements of array B are");
            foreach (int i in arrB)
            {
                Console.Write(i + " ");
            }
            Array.Copy(arrA, 0, arrB, 3, 6);
            Console.WriteLine("\n element of array B are");
            foreach(int i in arrB)
            {
                Console.Write(i + " ");

            }
            Array.Reverse(arrA);
            Console.WriteLine("\n elements of array A after reversing");
            foreach(int i in arrA)
            {
                Console.Write(i + " ");
            }
            Array.Sort(arrA);
            Console.WriteLine("\n elements of array A after sorting");
            foreach (int i in arrA)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n enter the search elements : ");
            int s = int.Parse(Console.ReadLine());
            int f = Array.BinarySearch(arrA, s);
            if (f >= 0)
            {
                Console.WriteLine("search elements found in a {0} loacation",(f+1));
            }
            else
            {
                Console.WriteLine("search elements  is not found ");
            }
            Array.Clear(arrA, 2, 3);
            Console.WriteLine("element of arrA after clearing");
            foreach (int i in arrA)
            {
                Console.Write(i + " ");
            }

        }
        }
    }

