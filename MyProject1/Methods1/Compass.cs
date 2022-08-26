using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Compass
    {
        string compassbrand;
        int price;
        Pen p;



        static void Main(string[] args)
        {
            Compass c1 = new Compass();
            c1.compassbrand = "Cello";
            c1.price = 250;
            Pen p1 = new Pen("Reynolds",45,"Blue");

            c1.p = p1;

            Console.WriteLine("CompassBrand is "+c1.compassbrand);
            Console.WriteLine("CompassPrice is "+c1.price);
            Console.WriteLine("\nPen Details"+c1.p.Penbrand);
           // Console.WriteLine("PenBrand"+c1.penbrand);
        }
    }
    class Pen
    {
        string penbrand;
        int price;
        string inkcolor;

        public string Penbrand
        {
            set { penbrand = value; }
            get { return penbrand; }
        }
        public Pen(string penbrand,int price,string inkcolor)
        {
            this.penbrand = penbrand;
            this.price = price;
            this.inkcolor = inkcolor;
        }
    
    }

   

}
