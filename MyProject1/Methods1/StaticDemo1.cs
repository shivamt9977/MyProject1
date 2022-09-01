using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class StaticDemo1
    {
        int a = 10;
        static int c = 20;

        public static void m1()
        {
            Console.WriteLine("In static m1");
            Console.WriteLine(c);
            
        }

        public static void m2()
        {
            Console.WriteLine("In m2");
            m1();
           // m3();
          //  Console.WriteLine(a);

        }
        public  void m3()
        {
            Console.WriteLine("In m3");

        }
        public  void m4()
        {
            Console.WriteLine("In m4");
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
             StaticDemo1.m1();

            StaticDemo1 s = new StaticDemo1();
            s.m4();

        }

        static class f
        {
           static int g = 18;
            static string abc = "abc";

        }

    }
}
