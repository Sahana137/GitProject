using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class SeparateCharacters
    {
        public static void Main(string[] args)
        {
            string input1 = "sahana.com";
            foreach(char ch in input1)
            {
                Console.Write(ch + " ");
            }

        }
    }
}
