using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._27_Aug
{
    class Time
    {
        int hour, min, sec;
        public void set_time(int hr,int mn,int sc)
        {
            hour = hr;
            min = mn;
            sec = sc;

            Console.WriteLine(hour);
            Console.WriteLine(min);
            Console.WriteLine(sec);
        }
        public void show_time()
        {
           // Console.WriteLine(hour);
        }


        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.set_time(10, 10, 10);
            
        }
    }
}
