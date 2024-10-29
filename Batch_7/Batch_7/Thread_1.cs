using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Batch_7
{
    internal class Thread_1
    {
        Thread t1, t2;
        public Thread_1()
        {
            t1 = new Thread(Test1);
            t2 = new Thread(Test2);
            t1.Start();
            t2.Start();

        }
        public void Test1()
        {
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine("test1: " + i);
                if (i == 10)
                {
                    Thread.Sleep(10000);
                }
                Console.WriteLine("test1 existing");
            }
            
           
        }
        public void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("test2: " + i);
              
            }
            Console.WriteLine("test2 existing");

        }
        public static void Main(string[] args)
        {
            Thread_1 obj = new Thread_1();
            obj.t1.Join();
            obj.t2.Join();
            Console.WriteLine("main thread existing");
            Console.WriteLine();

        }
    }
}
