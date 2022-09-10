using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
    class _5_num_calc
    {
        
        void num_calc(int num,char ch)
        {
            int ans=0;
            if (ch == 's')
            {
                ans = num * num;
            }
            else
            {
                ans = num * num * num;
            }
            Console.WriteLine(ans);
        }

        void num_calc(int a,int b,char ch)
        {
            int ans=0;
            if(ch=='p')
            {
                ans = a * b;
            }
            else
            {
                ans = a + b;
            }
            Console.WriteLine(ans);
        }

        static void Main(string[] args)
        {
            _5_num_calc c = new _5_num_calc();

            Console.WriteLine("Enter num,ch");
            int num = int.Parse(Console.ReadLine());
            char ch = Convert.ToChar(Console.ReadLine());
            c.num_calc(num,ch);

            Console.WriteLine("Enter a,b,ch");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char ch1 = Convert.ToChar(Console.ReadLine());

            c.num_calc(a,b,ch1);


        }
    }
}
