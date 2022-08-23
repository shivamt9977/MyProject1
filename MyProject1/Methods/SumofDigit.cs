using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class SumofDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int copy = num;
            //12345
            int r1 = copy % 10;
            int num1 = 0;
            while (num!=0)
            {
                int r = num % 10;
                num1 = (num1 * 10) + r;
                num = num / 10;
            }

            int firstnum = num1%10;

            if(r1%2==1 && firstnum%2==1)
            {
                int sum = r1 + firstnum;

                Console.WriteLine("Sum is "+sum);
            }
            else
            {
                Console.WriteLine("Not odd digits found");
            }




            //Console.WriteLine();
            //Console.WriteLine(count);
        }
    }
}
