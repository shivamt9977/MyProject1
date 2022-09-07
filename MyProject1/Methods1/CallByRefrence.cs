using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class m2
    {
        public void m1(ref int a ,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }

    class CallByRefrence
    {
        static void Main(string[] args)
        {
            int x = 90, y = 100;
            m2 m = new m2();
            m.m1(ref x, ref y);
            Console.WriteLine("X is "+x+" Y is "+y);
        }
      

    }
}
