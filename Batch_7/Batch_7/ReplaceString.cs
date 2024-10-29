using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class ReplaceString
    {
        public static void Main(string[] args)
        {
            int input2 = Convert.ToInt32(Console.ReadLine());
            string[] input1 = new string[input2];
            for(int i=0; i < input2; i++)
            {
                input1[i] = Console.ReadLine();
            }
            int result = UserReplaceString.(input1, input2);
        }
    }
}
