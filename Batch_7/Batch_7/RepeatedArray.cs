using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class RepeatedArray
    {
        static void Main()
        {
            int[] array = { 1, 2, 2, 3, 4, 4, 5, 5 };

            
            bool[] counted = new bool[array.Length];

            
            for (int i = 0; i < array.Length; i++)
            {
                
                if (counted[i])
                    continue;

                int count = 1; 

                
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        counted[j] = true; 
                    }
                }

               
                Console.WriteLine($"Element {array[i]} occurs {count} times.");
            }
        }
    }
    }


       
    
