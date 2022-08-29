using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Disarium
    {

        public int Power(int b,int idx)
        {
            int result = 1;
            for(int i=1;i<=idx;i++)
            {
                result = result * b;

            }
            return result;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Disarium d1 = new Disarium();
            //135
            int copy = num;
            int r = 0;
            int c = 0;
            int sum = 0;
            //number of digits
            while(num != 0)
            {
               
                c++;
                num = num / 10;
               
            }
            num = copy;


            while(num>0)
            {
                 r = num % 10;
                sum = sum + d1.Power(r, c);
                c--;
                num= num/ 10;
                
            }



            
        }
    }
}
