using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
    class _1_Overload
    {
        
       public void Number(int num, int d)
      {
                //2565685
                //d=5
                //f=3
                int c = 0;
                while (num != 0)
                {
                    int r = num % 10;
                    if (r == 5)
                    {
                        c++;
                    }
                    num = num / 10;
                }
            Console.WriteLine("Frequency of Didit "+d+" = "+c);

       }

        public void Number(int n1)
       {
            //29865
            //2+8+6=16
            int sum = 0;
            while(n1!=0)
            {
                int r = n1 % 10;
                if(r%2==0)
                {
                    sum = sum + r;
                }
                n1 = n1 / 10;
            }
            Console.WriteLine("Sum of Even Digits = "+sum);

       }
        static void Main(string[] args)
       {
            _1_Overload o = new _1_Overload();

            int num = int.Parse(Console.ReadLine());
          int d = int.Parse(Console.ReadLine());
            o.Number(num,d);

            int n1 = int.Parse(Console.ReadLine());
            o.Number(n1);
        }
            
    }
}
