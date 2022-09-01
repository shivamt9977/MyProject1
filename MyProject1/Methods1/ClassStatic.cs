using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Statics
    {

        string bankName;
        static float roi; 

        static Statics()
        {

        }

        public Statics()
        {

        }

        static void Main(string[] args)
        {
            Statics.roi = 6.5f;
        }
    }
}
