using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class Krishnamurthy
    {
        public int Krishna(int n)
        {
            int copy = n;
            int sum = 0;

            //134
            while (n>0)
            {
                int r = n % 10;
                int f = 1;
                for(int i=1;i<=r;i++)
                {
                    f = f * i;
                }
                sum = sum + f;
                n = n / 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            Krishnamurthy ob = new Krishnamurthy();

            int isKrishna = ob.Krishna(num);
            if(isKrishna==num)
            {
                Console.WriteLine("KrishnaMurthy Number");
            }
            else
            {
                Console.WriteLine("Not a KrishnaMurthy Number");

            }
        }
    }
}
