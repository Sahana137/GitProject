using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Batch_7
{
    internal class Thread_2
    {
        Thread t1, t2, t3;
        public Thread_2()
        {
            t1 = new Thread(Display);
            t2 = new Thread(Display);
            t3 = new Thread(Display);
            t1.Start();
            t2.Start();
            t3.Start();

        }
        public void Display()
        {
            lock (this)
            {
                Console.WriteLine("C# is");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented");
            }
        }
        static void Main()
        {
            Thread_2 obj = new Thread_2();
            obj.t1.Join();
            obj.t2.Join();
            obj.t3.Join();
            
        }
    }
}
