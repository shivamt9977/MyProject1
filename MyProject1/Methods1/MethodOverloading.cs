using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class MethodOverloading
    {

        public int area(int l,int b)
        {
            return l * b;
        }

        public int area(int side)
        {
            return side * side; 
        }

        public float area(float r)
        {
            float ans = 3.14f * r * r;
            return ans;
        }


        static void Main(string[] args)
        {
            MethodOverloading M = new MethodOverloading();
            int areaOfrec = M.area(5, 5);
            Console.WriteLine("Area of Rec is "+areaOfrec);

            int areaOFsquare = M.area(6);
            Console.WriteLine("Area of Sq is "+areaOFsquare);

            float areaOfCircle = M.area(5f);
            Console.WriteLine("Area of Circle is "+areaOfCircle);
        }
    }
}
