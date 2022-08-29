using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._27_Aug
{
    class Pallindrom
    {

        public bool isPallindrome(int nm)
        {
            //1551
            int copy = nm;
            int rev = 0;
            while(nm!=0)
            {
                int r=nm % 10;
                rev = rev *10+r;
                nm = nm / 10;

            }

            if (copy == rev)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Pallindrom p = new Pallindrom();
            int num = int.Parse(Console.ReadLine());

           bool result= p.isPallindrome(num);
            Console.WriteLine(result);
        }
    }
}
