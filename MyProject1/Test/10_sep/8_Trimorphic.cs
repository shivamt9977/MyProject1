using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
    class _8_Trimorphic
    {

        public void Check(int num)
        {
            int c = num * num * num;

            c = c % 10;

            if(c==num)            
                Console.WriteLine("Trimorphic NUmber");         
            else           
                Console.WriteLine("Not a Trimorphic NUmber");            
        }


        static void Main(string[] args)
        {
            _8_Trimorphic t = new _8_Trimorphic();
            int num = int.Parse(Console.ReadLine());

            t.Check(num);
        }
    }
}
