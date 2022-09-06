using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._3_sep
{
    class IMEI
    {
        public void check(long num)
        {
            long sum = 0;
            long sum1 = 0;
            long c = 0;
            while(num!=0)
            {
                long r = num % 10;
                sum = sum + r;
               if(c%2==0)
                {
                    sum = sum + r;
                }
                if(c%2==1)
                {
                    r = r * r;
                    if(r>9)
                    {
                        
                        while(r!=0)
                        {
                            long r1 = r % 10;
                            sum1 = sum1 + r1;
                            r = r / 10;
                        }
                    }
                }

             c++;
                num = num / 10;
            }
            long ans = sum + sum1;
            Console.WriteLine(ans);
        }

        static void Main(string[] args)
        {
            //490154203237518
            long num = long.Parse(Console.ReadLine());
            IMEI i = new IMEI();
            i.check(num);



        }
    }
}
