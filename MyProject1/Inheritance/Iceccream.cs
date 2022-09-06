using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Inheritance
{
    interface IceCream
    {
        void eat();

    }
    interface Juice
    {
        void drink();
    }

    class mastani : IceCream, Juice
    {
        public void eat()
        {
            Console.WriteLine("Eating IceCeam");
        }
        public void drink()
        {
            Console.WriteLine("Drinking Juice");
        }

       
    }
    class Icecreamtest
    {
        static void Main(string[] args)
        {
            IceCream i = new mastani();
            i.eat();
            Juice j = new mastani();
            j.drink();
            
        }
    }

}
