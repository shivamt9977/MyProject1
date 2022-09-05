using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Series
    {
        //0,3,8,15,24,35

        public void seri(int nm)
        {
            int i = 1;
            while(i<=nm)
            {
                int a = (i * i) - 1;
                Console.Write(a+" ");
                i++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers UpTo");
            int num = int.Parse(Console.ReadLine());
            Series sr = new Series();
            sr.seri(num);
        }
    }
}
