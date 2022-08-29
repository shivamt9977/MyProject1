using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._27_Aug
{
    class IsPrime
    {
        public bool isPrime(int nm)
        {
            for(int i=2;i<=nm/2;i++)
            {
                if (nm % i == 0)
                    return false;
                
            }
            return true;
        }


        static void Main(string[] args)
        {
            IsPrime pr = new IsPrime();
            int num = int.Parse(Console.ReadLine());

           bool result = pr.isPrime(num);
            Console.WriteLine(result);


            for (int j = 2; j <= 500; j++)
            {
                int c = 0;
                for (int k = 1; k <= j; k++)
                {

                    if (j % k == 0)
                    {
                        c++;
                    }


                }
                if (c == 2)
                {
                    Console.WriteLine(j);

                }


            }
        }
    }
}
