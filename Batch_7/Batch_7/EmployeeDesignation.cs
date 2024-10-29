using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class EmployeeDesignation
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[n];
            for(int i=0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            string find = Console.ReadLine();
            string[] op = UserProgramCode.getEmployee( str,find);
            int count = 0;
            foreach(string item in str)
            {
                foreach(char c in item)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        count++;
                    }
                }
            }
            foreach(char item in find)
            {
                if(!char.IsLetterOrDigit(item) && (!char.IsWhiteSpace(item))){
                    count++;
                }
            }
            if(count != 0)
            {
                Console.WriteLine(value: "invalid input");
            }
            else
            {
                if (op.Length == str.Length/2)
                {
                    Console.WriteLine(format: "all employees belong to same {0} designation", find);
                }
                else if(op.Length == 0)
                {
                    Console.WriteLine(format: "no employee for {0} designnation", find);
                }
                else
                {
                    foreach(string item in op)
                    {
                        Console.WriteLine(item);



                    }
                }
            }
        }
    }
}
