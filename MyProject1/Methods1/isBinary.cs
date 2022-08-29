using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class isBinary
    {
        public bool checkBinary(int n1)
        {
            int c=0;
            while(n1!=0)
            {
                int r = n1 % 10;
                c++;
                if(c%2==1)
                {
                    if (r>1)
                        return false;

                }

                n1 = n1 / 10;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //101010101

            isBinary b = new isBinary();
            bool result=b.checkBinary(num);
            if(result)
            {
                Console.WriteLine("Binary Number");
            }
            else
                Console.WriteLine("Not a Binary Number");
        }
    }
}
