using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{

    class Person
    {
        int id;
        string name;
        Vehicle v;

        public Person()
        {

        }
        public Person(int id,string name,Vehicle v)
        {
            this.id = id;
            this.name = name;
            this.v = v;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public Vehicle V
        {
            set { v = value; }
            get { return v; }
        }

    }

    class Vehicle
    {

        int vid;
        string vname;
        public Vehicle()
        {

        }
        public Vehicle(int vid, string vname)
        {
            this.vid = vid;
            this.vname = vname;
         
        }
        public int Vid
        {
            set { vid = value; }
            get { return vid; }
        }
        public string Vname
        {
            set { vname = value; }
            get { return vname; }
        }

    }

    class vehicle1
    {
        static void Main(string[] args)
        {
            Vehicle vh = new Vehicle(2010, "Figo");
            Person pr = new Person(301, "Shivam", vh);

            Console.WriteLine(pr.V.Vname);
        }
    }

}
