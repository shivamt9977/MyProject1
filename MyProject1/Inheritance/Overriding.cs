using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Inheritance
{
    class Overriding
    {
        public virtual void riding()
        {
            Console.WriteLine("Riding on road");
        }

    }

    class child:Overriding
    {
        public override void riding()
        {
            Console.WriteLine("Riding in a game");
        }


    }
    class M2
    {

        static void Main(string[] args)
        {
            child c = new child();
            c.riding();

            Overriding ov = new child();
            ov.riding();

            Overriding o = new Overriding();
            o.riding();
            
        }
    }

}
