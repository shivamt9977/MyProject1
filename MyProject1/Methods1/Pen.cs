using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{

    // Contenment
    class Pen2
    {
        Refill r;
        int caplength;
        string brand;

        public Pen2()
        {

        }
        public Pen2(Refill r,int caplength,string brand)
        {
            this.r = r;
            this.caplength = caplength;
            this.brand = brand;
        }
        public Refill R
        {
            set { r = value; }
            get { return r; }
        }
        public int Caplength
        {
            set { caplength = value; }
            get { return caplength; }
        }
        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }
    }
    class Refill
    {
        string color;
        int length;
        Nib tip;

        public Refill()
        {

        }
        public Refill(string color, int length, Nib tip)
        {
            this.color = color;
            this.length = length;
            this.tip = tip;
        }
        public string Color
        {
            set { color = value; }
            get { return color; }
        }
        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        public Nib Tip
        {
            set { tip = value; }
            get { return tip; }
        }

    }
    class Nib
    {
        string material;
        double width;

        public Nib()
        {

        }
        public Nib(string material, double width)
        {
            this.material = material;
            this.width = width;
        }
        public string Material
        {
            set { material = value; }
            get { return material; }
        }
        public double Width
        {
            set { width = value; }
            get { return width ; }
        }
    }

    class pen1
    {
        static void Main(string[] args)
        {
            Nib n = new Nib("SS", 0.1);
            Refill re = new Refill("Red", 5, n);
            Pen2 pen = new Pen2(re,2,"Cello");

           // Console.WriteLine(pen.Brand);
            Console.WriteLine(pen.R.Color);

        }
    }



}
