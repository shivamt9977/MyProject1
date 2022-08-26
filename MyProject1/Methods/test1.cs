using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods
{
    class test1
    {

        public void div(int a)
        {
            if(a%3==0 && a%5==0)
            {
                Console.WriteLine("ThreeFive");
            }
            else if(a%3==0)
                Console.WriteLine("Three");
            else if(a%5==0)         
                Console.WriteLine("Five");           
            else
                Console.WriteLine("Not");
            
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            test1 t1 = new test1();
            t1.div(a);
        }
    }
}
