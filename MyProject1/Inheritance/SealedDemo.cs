using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Inheritance
{
    class SealedDemo
    {
        public virtual void M1()
        {
            Console.WriteLine("parent M1");
        }
    }

     class childof:SealedDemo
    {
        public override sealed void M1()
        {
            Console.WriteLine("Child of M1");
        }
    }
    

    class tmain
    {
        static void Main(string[] args)
        {
            SealedDemo d = new childof();
            d.M1();
            childof c = new childof();
            c.M1(); 
        }
    }

}
