using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    internal class Interface1
    {
        interface Inter1
        {
            void f1();
        }
        interface Inter2
        {
            void f1();
        }
        class C3 : Inter1, Inter2
        {
            public void f1()
            {
                Console.WriteLine("this is overriding function of inter1 and inter2 interface");
            }
         
        }
        class ClsInterface1
        {
            static void Main(string[] args)
            {
                C3 obj1 = new C3();
                Inter1 obj2 = (Inter1)obj1;
                Inter2 obj3 = (Inter2)obj1;
                obj1.f1();
                obj3.f1();
                Console.Read();

            }
        }
        }
    
}

