using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class RepeatedString
    {
        public static void Main(string[] args)
        {
            string[] arr = new string[10];

            
            Console.WriteLine("enter the 10 elements ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            bool[] check = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {

                if (!check[i])
                {
                    int count = 0;
                    check[i] = true;
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            check[j] = true;
                        }

                    }

                    Console.WriteLine($"the element  {arr[i]} is  repeating {count} times");

                }
            }
        }
    }
}
