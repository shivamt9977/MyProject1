using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Inheritance
{
    class P
    {
        int i;
        public P()
        {
            Console.WriteLine("In parents Default");

        }

        public P(int i)
        {
            this.i = i;
            Console.WriteLine(i);
            Console.WriteLine("In parents parametarised");
        }

       

    }

    class C:P
    {
        int j;
        public C():base(10)
        {
            Console.WriteLine("In child default");
        }
        public C(int i,int j):base(i)
        {
            this.j = j;
            Console.WriteLine("In chid para");
        }
    }

    class M
    {
        static void Main(string[] args)
        {
            C c1=new C();
            C c2 = new C(10,15);

        }
    }

}
