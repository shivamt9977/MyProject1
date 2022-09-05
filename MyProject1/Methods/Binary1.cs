using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Binary1
    {

        public void bin1(int num)
        {
            int pos = 1;
            int deci = 0;
            while (num!=0)
            {
                int r = num % 10;
                
                if(r==1)
                {
                    deci=deci*pos;
                }

                pos = pos * 2;

            }
            Console.WriteLine(deci);
        }
        static void Main(string[] args)
        {
            Binary1 b1 = new Binary1();
            b1.bin1(1010);
            
        }
    }
}
