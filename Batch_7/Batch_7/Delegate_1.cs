using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
    public delegate void Math(int x, int y);
    class Delegate_1
    {
        public void add(int x, int y)
        {
            Console.WriteLine("add : " + (x + y));

        }
        public void sub(int x, int y)
        {
            Console.WriteLine("sub : " + (x - y));
        }
        public void mul(int x, int y)
        {
            Console.WriteLine("mul: " + (x * y));
        }
        public void div(int x, int y)
        {
            Console.WriteLine("div : " + (x / y));
        }
        static void Main(string[] args)
        {
            Delegate_1 obj = new Delegate_1();
            Math m = new Math(obj.add);
            m+= obj.sub;
            m+= obj.mul;
            m += obj.div;
            m(100, 50);
            Console.WriteLine();
            m(450, 70);
            Console.WriteLine();
            m -= obj.div;
            m(625, 25);
            Console.WriteLine();

        }

    }

}
