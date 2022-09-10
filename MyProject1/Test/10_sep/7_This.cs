using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
   class _7_This
    {
        //Instance variable
        int a;
        int b;

        public _7_This()
        {

        }
        public _7_This(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A
        {
            set { a = value; }
            get { return a; }
        }
        public int B
        {
            set { b = value; }
            get { return b; }
        }

    }

    class t1
    {
        static void Main(string[] args)
        {
            _7_This t = new _7_This(5,6);
            

           // Console.WriteLine(_7_This.a);
        }
    }

   
    
}
