using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Fibbonacci
    {
        //0 1 1 2 3 5 8
        public void fib(int nm)
        {
            int a = 0;
            Console.Write(a+",");
            int b = 1;
            Console.Write(b);
            int i = 1;
            int c = 0;
            while(i<nm)
            {
                c = a + b;
                Console.Write(","+c);
                a = b;
                b = c;
                i++;
            }
        }

        static void Main(string[] args)
        {
            Fibbonacci fb = new Fibbonacci();
            int num = int.Parse(Console.ReadLine());
            fb.fib(num);
        }
    }
}
