using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Binary
    {
        public int Bin(int num)
        {
            //1010
            int dnum = 0;
            int basev = 1;
            while(num>0)
            {
                int r = num % 10;//0,1,0
                dnum = dnum + (r * basev);//0,2,2
                num = num / 10;//101,10,1
                basev = basev * 2;//2,4,8
            }
            return dnum;
        }
        static void Main(string[] args)
        {
            Binary b = new Binary();
            int num = int.Parse(Console.ReadLine());
            int ans=b.Bin(num);
            Console.WriteLine(ans);
        }

    }

}
