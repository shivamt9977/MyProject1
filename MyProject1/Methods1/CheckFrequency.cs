using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class CheckFrequency
    {
        public void number(int num, int d)
        {
            int count = 0;
            while (num != 0)
            {
                int r = num % 10;
                if (r == d)
                {
                    count++;
                }
                num = num / 10;
            }
            Console.WriteLine("frequency is " + count);

        }

        static void Main(string[] args)
        {
            CheckFrequency freq = new CheckFrequency();
            int nm = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            freq.number(nm, f);
        }
    }
}
