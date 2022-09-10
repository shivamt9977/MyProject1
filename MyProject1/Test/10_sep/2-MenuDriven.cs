using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Test._10_sep
{
    class _2_MenuDriven
    {
        public void Menu()
        {
            Console.WriteLine("1.Area of Circle\n2.Area of Square\n3.Area of Rectangle");
            Console.WriteLine("Enter the Choice");
            int choice = int.Parse(Console.ReadLine());

            double ans;
            int radius = 5;
            int length = 6;
            int breadth = 7;
            switch (choice)
            {

                case 1: ans = 3.14 * radius * radius;
                    Console.WriteLine("Area of Circle = "+ans);
                    break;

                case 2:ans = length * length;
                    Console.WriteLine("Area of Square = " + ans);
                    break;

                case 3:ans = length * breadth;
                    Console.WriteLine("Area of Rectangle = " + ans);
                    break;

            }


        }
        static void Main(string[] args)
        {
            _2_MenuDriven m = new _2_MenuDriven();
            m.Menu();
        }
    }
}
