using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
    class A
    {
        int a;
        int b;

        public A() { }
        public A(int a,int b) 
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public A(int a,int b,int c)
        {
            int d = a + b + c;
            Console.WriteLine(d);
        }

    }
    class B
    {
        static void Main(string[] args)
        {
            A aa = new A(5, 6);
            A a1 = new A(5, 6, 7);
        }

    }

}
