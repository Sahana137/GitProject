using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class UserProgramCode
    {
        public static string[] getEmployee(string[] input1,string input2)
        {
            List<string> list = new List<string>();

            for(int i = 0; i < input1.Length; i++)
            {
                if(input2.ToLower() == input1[i].ToLower())
                {
                    list.Add(input1[i - 1]);
                }
            }
            return list.ToArray();
        }
    }
}
